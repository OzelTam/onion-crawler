using System;
using System.IO;
using System.Threading;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using System.Net;
using Tor4NET;
using System.Collections.ObjectModel;

namespace OnionCrawLib
{


    public class WebStructure
    {
        public event EventHandler<string> EventResponse;
        
        private void RaiseEventResponse(string eventMessage)
        {
            EventResponse?.Invoke(this, eventMessage);
        }




        public readonly WebStructureOptions Options = null;
        public Tor4NET.Tor torClientSource;
        public ObservableCollection<OnionSite> WebStructureObject = new ObservableCollection<OnionSite>();
        public ObservableCollection<QueuedUrl> queuedLinks = new ObservableCollection<QueuedUrl>();


       

        public WebStructure(WebStructureOptions webStructureOptions)
        {
            Options = webStructureOptions;
            if (!OnionCr.UrlValidator(Options.RootWebsite)) { throw new Exception($"Invalid root page. '{Options.RootWebsite}'"); }
            if (Options.MaxSubpages < 1 || Options.MaxSubpages > 100) { throw new Exception("Subpages must be between 1 and 1000"); }
            if (Options.MaxHostCount < 1 || Options.MaxHostCount > 100000) { throw new Exception("Maximum page count must be between 1 and 100000"); }
        }

  

        public async Task InitAsync()
        {
          torClientSource = new Tor4NET.Tor(Options.TorClientDirectory, Options.is32bit);
            if (Directory.Exists(Options.TorClientDirectory)==false) {await InstallTorAsync();}
            RaiseEventResponse($"Web structure initialization completed with the seed url of '{Options.RootWebsite}'.");
        }



        public async Task InstallTorAsync()
        {
            RaiseEventResponse($"Installing Tor Files. '{Options.TorClientDirectory}'");
            try
            {
                await torClientSource.Install();
                RaiseEventResponse($"Done installing Tor Files.");
            }
            catch(Exception ex)
            {
                try
                {
                    if (Directory.Exists(Options.TorClientDirectory)) { Directory.Delete(Options.TorClientDirectory); }
                }
                catch { }
                
                throw new Exception("Error while installing Tor. \n" +
                    "if Tor is restricted in your area please consider using a VPN \n" +
                    "Error Message: " + ex.Message, innerException: ex.InnerException);
            }
        
        }
        public void UninstallTor()
        {
            RaiseEventResponse($"Unistalling Tor Files. '{Options.TorClientDirectory}'");
            try
            {
                 torClientSource.Uninstall();
                RaiseEventResponse($"Done uninstalling Tor Files.");
            }
            catch (Exception ex)
            {
                throw new Exception("Error while unstalling Tor Files. \n"
                    + ex.Message);
            }

        }
        public async Task<bool> CheckForTorUpdatesAsyc()
        {
            RaiseEventResponse("Checking for Tor Updates.");
            var outpt = await torClientSource.CheckForUpdates();
            RaiseEventResponse("Done checking Updates.");
            return outpt;
        }


        public async Task<string> DownloadWebsiteAsync(string webAddress)
        {
            

         //   torClientSource = new Tor4NET.Tor(Options.TorClientDirectory, Options.is32bit);


            string htmlStr = "";
            using (var client = torClientSource.InitializeClient(true))
            {
               
                using (var http = new WebClient { Proxy = client.Proxy.WebProxy })
                {
                    RaiseEventResponse($"Downloading webpage. '{webAddress}'");
                    htmlStr = await http.DownloadStringTaskAsync(webAddress);
                    RaiseEventResponse($"Done downloading webpage. '{webAddress}'");
                }
    

            }

            return htmlStr;

        }



        public List<string> ExtractUrls(string InputString)
        {
            List<string> resutlt = new List<string>();

            resutlt.AddRange(OnionCr.ExtractOnionUrls(InputString).Where(x => OnionCr.UrlValidator(x)).ToList());
            if (Options.includeClearWeb)
            {
                resutlt.AddRange(OnionCr.ExtractSurfaceUrls(InputString).Where(x => OnionCr.UrlValidator(x)).ToList());
            }

            if (Options.includeIpHosts)
            {
                resutlt.AddRange(OnionCr.ExtractIpUrls(InputString).Where(x=> OnionCr.UrlValidator(x)).ToList());
            }
            return resutlt;
        }








     



        public List<string> ExtractSubUrls(string URL,string htmlContent)
        {
            var allUrls = ExtractUrls(htmlContent);
            var result = new List<string>();
            result.AddRange(allUrls.Where(x => GetHost(x) == GetHost(URL)).ToList());
            return result;
        }






        private CancellationTokenSource cancellationTokenSource = null;



        public void RequestCrawlCancellation()
        {
            if(cancellationTokenSource != null)
            {
                cancellationTokenSource.Cancel();
                RaiseEventResponse("Crawl Cancellation Requested.");

            }
            else
            {
                RaiseEventResponse("There isn't any ongoing crawling process.");
            }
            
        }


        public List<string> ExtractExternalUrls(string URL, string htmlContent)
        {
            var allUrls = ExtractUrls(htmlContent);
            var result = new List<string>();
            result.AddRange(allUrls.Where(x => GetHost(x) != GetHost(URL)).ToList());
            return result.Where(x => WebStructureObject.Count(y=> y.Host == GetHost(x)) < 1).ToList();
        }
        public string GetHost(string Url)
        {
            var uri = new Uri(Url);
              return   uri.GetLeftPart(UriPartial.Authority);
        }
        public List<QueuedUrl> ConvertToQueuedUrl(string parentUrl,List<string> urlList)
        {
            var result = new List<QueuedUrl>();
            foreach(var url in urlList)
            {
                result.Add(new QueuedUrl() { url = url,parent = parentUrl});
            }

            return result;
        }

       




  
        public async Task CrawlAsync(bool continueExistingCrawl = false)
        {
            if (continueExistingCrawl && queuedLinks.Count > 0)
            {
                RaiseEventResponse("Continuing the crawl process.");
                goto bypass;
            }
            else if(continueExistingCrawl)
            {
                RaiseEventResponse("There is'nt any url in queue. Please re-initialize.");
                return;
            }
         
            var seedQueue = new QueuedUrl();
            seedQueue.url = Options.RootWebsite;
            seedQueue.parent = Options.RootWebsite;
            queuedLinks.Add(seedQueue);


            bypass:
           cancellationTokenSource = new CancellationTokenSource();
            while (queuedLinks.Count > 0)
            {
                if (cancellationTokenSource.IsCancellationRequested)
                {
                    cancellationTokenSource = null;
                    RaiseEventResponse("Crawling is Cancelled.");
                    return;
                }




                try
                {
                    if (WebStructureObject.GroupBy(x => x.Host).ToList().Count >= Options.MaxHostCount)
                    {
                        break;
                    } //If max host count acceed



                    string URL = queuedLinks[0].url;

                 //  if (WebStructureObject.Count(x => x.Host == GetHost(URL)) >= Options.MaxSubpages)
                 //  {
                 //      queuedLinks.RemoveAt(0);
                 //      continue;
                 //  } //  <==Old code

                    var NewOnionSite = new OnionSite(GetHost(URL));

                    var htmlContent = await DownloadWebsiteAsync(URL); //Downloads HTML CODE
                    
                    var externalLinksList = ExtractExternalUrls(URL, htmlContent);
                    var subLinksList = ExtractSubUrls(URL, htmlContent).Take(Options.MaxSubpages).ToList();


                    NewOnionSite.title = OnionCr.GetPageTitle(URL);
                    NewOnionSite.externalLinks.AddRange(externalLinksList.Where(x => !isWebStrObjContains_hostOf(x)).ToList());
                    NewOnionSite.parentLink = queuedLinks[0].parent; // COMMON CODE TO CREATE ONION SITE OBJECT CLASS 




                    if (isWebStrObjContains_hostOf(URL))
                    {
                        OnionSite PARENTonionSite = WebStructureObject.Where(x => x.Host == GetHost(URL)).ToList()[0];
                        PARENTonionSite.subLinks.Add(NewOnionSite);
                        NewOnionSite.parentSite = PARENTonionSite;
                    } // If Host is visited before
                    else 
                    {

                       var subLinksQueue = ConvertToQueuedUrl(URL, subLinksList);
                        if (queuedLinks.Count <= Options.maxQueue)
                        {
                        queuedLinks.AddRange(subLinksQueue);
                        }
                            
                       WebStructureObject.Add(NewOnionSite);
                    } //if host is not visited before.


                    var externalLinksQueue = ConvertToQueuedUrl(URL, externalLinksList);
                    if (queuedLinks.Count <= Options.maxQueue)
                    {
                        queuedLinks.AddRange(externalLinksQueue); // QUEUE EXTERNAL LINKS LEADS TO OTHER HOSTS.
                    }
                  
                    queuedLinks.RemoveAt(0);
                    
                }catch(Exception ex)
                {
                    queuedLinks.RemoveAt(0);
                    RaiseEventResponse("ERROR:" + ex.Message);
                    continue;
                }
                
            }

            RaiseEventResponse("DONE CRAWLING.");

        }
       

     private bool isWebStrObjContains_hostOf(string url)
        {
            var host = GetHost(url);
            if(WebStructureObject.Count(x => x.Host == host) > 0)
            {
                return true;
            }
            else {
                return false;
            }
        }






    }
    public class QueuedUrl
    {
        public string url { get; set; }
        public string parent { get; set; }
    }

}
