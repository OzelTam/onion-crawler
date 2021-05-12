using MihaZupan;
using OnionCrawler.Lib.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace OnionCrawler.Lib
{
    public class CrawlerClient
    {
        public event EventHandler<string> EventResponse;
        private void RaiseEventResponse(string eventMessage)
        {
            EventResponse?.Invoke(this, eventMessage);
        }

        public readonly CrawlerOptions Options = null;
        public ObservableCollection<WebsiteModel> WebStructureObject = new ObservableCollection<WebsiteModel>();
        public ObservableCollection<QueuedWebsite> QueuedLinks = new ObservableCollection<QueuedWebsite>();


        public CrawlerClient(CrawlerOptions webStructureOptions)
        {
            Options = webStructureOptions;
            if (!Common.UrlIsValid(Options.RootWebsite)) { throw new Exception($"Invalid root page. '{Options.RootWebsite}'"); }
            if (Options.MaxSubPageCount < 1 || Options.MaxSubPageCount > 1000) { throw new Exception("Subpages must be between 1 and 1.000"); }
            if (Options.MaxWebsiteCount < 1 || Options.MaxWebsiteCount > 1000000) { throw new Exception("Max Website count must be between 1 and 1.000.000"); }
        }
        public CrawlerClient(string rootPage)
        {
            Options = new CrawlerOptions() { RootWebsite = rootPage};
            if (!Common.UrlIsValid(Options.RootWebsite)) { throw new Exception($"Invalid root page. '{Options.RootWebsite}'"); }
            if (Options.MaxSubPageCount < 1 || Options.MaxSubPageCount > 1000) { throw new Exception("Max Subpages Count must be between 1 and 1.000"); }
            if (Options.MaxWebsiteCount < 1 || Options.MaxWebsiteCount > 1000000) { throw new Exception("Max Website count must be between 1 and 1.000.000"); }

        }

        public async Task<string> DownloadWebsiteAsync(string url)
        {
            var proxy = new HttpToSocks5Proxy(Options.ProxyHost, Options.ProxyPort);
            var handler = new HttpClientHandler { Proxy = proxy };
            HttpClient client = new HttpClient(handler, true);
            client.Timeout = Options.TimeoutSpan;
            RaiseEventResponse($"Downloading webpage. '{url}'");
            string htmlStr = await client.GetStringAsync(url);
            RaiseEventResponse($"Done downloading webpage. '{url}'");
            client.Dispose();
            return htmlStr;
        }

        #region URL EXTRACTORS
        public List<string> ExtractUrls(string InputString)
        {
            List<string> res = new List<string>();
            res.AddRange(Common.ExtractOnionUrls(InputString).Where(x => Common.UrlIsValid(x)).ToList());
            if (Options.IncludeClearWeb)
            {
                res.AddRange(Common.ExtractSurfaceUrls(InputString).Where(x => Common.UrlIsValid(x)).ToList());
            }
            if (Options.IncludeIpHosts)
            {
                res.AddRange(Common.ExtractIpUrls(InputString).Where(x => Common.UrlIsValid(x)).ToList());
            }
            return res;
        }
        public List<string> ExtractExternalUrls(string URL, string htmlContent)
        {
            var allUrls = ExtractUrls(htmlContent);
            var result = new List<string>();
            result.AddRange(allUrls.Where(x => Common.GetHost(x) != Common.GetHost(URL)).ToList());
            return result.Where(x => WebStructureObject.Count(y => y.Host == Common.GetHost(x)) < 1).ToList();
        }
        public List<string> ExtractSubUrls(string URL, string htmlContent)
        {
            List<string> allUrls = ExtractUrls(htmlContent);
            List<string> result = new List<string>();
            result.AddRange(allUrls.Where(x => Common.GetHost(x) == Common.GetHost(URL)).ToList());
            return result;
        }

        #endregion

        public async Task CrawlAsync(bool continueExistingCrawl = false)
        {
            if (continueExistingCrawl && QueuedLinks.Count > 0)
            {
                RaiseEventResponse("Continuing the crawl process.");
                goto bypass;
            }
            else if (continueExistingCrawl)
            {
                RaiseEventResponse("There is'nt any url in queue. Please re-initialize.");
                return;
            }

            var seedQueue = new QueuedWebsite();
            seedQueue.Url = Options.RootWebsite;
            seedQueue.Parent = null;
            QueuedLinks.Add(seedQueue);

        bypass:
            cancellationTokenSource = new CancellationTokenSource();
            while (QueuedLinks.Count > 0)
            {
                // Check For Cancelation Request
                if (cancellationTokenSource == null || cancellationTokenSource.IsCancellationRequested)
                {
                    cancellationTokenSource.Dispose();
                    cancellationTokenSource = null;
                    RaiseEventResponse("Crawling is Cancelled.");
                    return;
                }

                try
                {
                    // Website Count Acceed
                    if (WebStructureObject.GroupBy(x => x.Host).ToList().Count >= Options.MaxWebsiteCount)
                    {
                        break;
                    } 



                    string URL = QueuedLinks[0].Url;
                    
                    var htmlContent = await DownloadWebsiteAsync(URL); //Downloads HTML CODE


                    var NewOnionSite = new WebsiteModel(Common.GetHost(URL));
                    var externalLinksList = ExtractExternalUrls(URL, htmlContent);
                    var subLinksList = ExtractSubUrls(URL, htmlContent).Take(Options.MaxSubPageCount).ToList();
                    NewOnionSite.ParentSite = QueuedLinks[0].Parent;
                    NewOnionSite.ParentLink = QueuedLinks[0].Parent?.Host;
                    NewOnionSite.Title = Common.GetPageTitle(htmlContent);
                    NewOnionSite.ExternalLinks.AddRange(externalLinksList.Where(x => Common.GetHost(x) != Common.GetHost(URL)));
                    NewOnionSite.SubLinks.AddRange(externalLinksList.Where(x => Common.GetHost(x) == Common.GetHost(URL)));



                    if (WebStructureObject.Any(x => x.Host == Common.GetHost(URL)))
                    {
                        var parent = WebStructureObject.Where(w => w.Host == Common.GetHost(URL)).FirstOrDefault();
                        parent.SubLinks.Add(URL);

                    } // If Host is visited before
                    else
                    {
                        WebStructureObject.Add(NewOnionSite);
                    }


                    var externalLinksQueue = ConvertToQueuedUrl(NewOnionSite, externalLinksList);
                    if (QueuedLinks.Count <= Options.MaxQueue)
                    {
                        QueuedLinks.AddRange(externalLinksQueue.Take(Options.MaxQueue - QueuedLinks.Count).ToList()); // QUEUE EXTERNAL LINKS LEADS TO OTHER HOSTS.
                    }

                    QueuedLinks.RemoveAt(0);

                }
                catch (Exception ex)
                {
                    QueuedLinks.RemoveAt(0);
                    RaiseEventResponse("ERROR:" + ex.Message);
                    continue;
                }

            }

            RaiseEventResponse("DONE CRAWLING.");
        }

        public List<QueuedWebsite> ConvertToQueuedUrl(WebsiteModel parent, List<string> urlList)
        {
            var result = new List<QueuedWebsite>();
            foreach (var url in urlList)
            {
                result.Add(new QueuedWebsite() { Url = url, Parent = parent });
            }

            return result;
        }



        private CancellationTokenSource cancellationTokenSource = null;
        public void RequestCrawlCancellation()
        {
            if (cancellationTokenSource != null)
            {
                cancellationTokenSource.Cancel();
                RaiseEventResponse("Crawl Cancellation Requested.");
            }
            else
            {
                RaiseEventResponse("There isn't any ongoing crawling process.");
            }

        }



    }
}
