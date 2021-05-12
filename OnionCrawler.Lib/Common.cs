using HtmlAgilityPack;
using MihaZupan;
using OfficeOpenXml;
using OnionCrawler.Lib.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
namespace OnionCrawler.Lib
{
    public static class Common
    {
        public async static Task<string> CheckProxyIp(string proxyHost = "127.0.0.1", int proxyPort = 9050)
       {
            string requestUri = "http://icanhazip.com/";
            var proxy = new HttpToSocks5Proxy(proxyHost, proxyPort);
            var handler = new HttpClientHandler { Proxy = proxy };
            HttpClient client = new HttpClient(handler, true);
            string ip = await client.GetStringAsync(requestUri);
            client.Dispose();

            return ip;

        }
        public async static Task<string> CheckProxyIp()
        {
            string requestUri = "http://icanhazip.com/";
            var client = new HttpClient();
            var ip =  await client.GetStringAsync(requestUri);
            client.Dispose();
            return ip;
        }



        public static List<string> ExtractOnionUrls(string htmlString)
        {

            List<string> result = new List<string>();
            var doc = new HtmlDocument();
            doc.LoadHtml(htmlString);
            var linkTags = doc.DocumentNode.Descendants("link");
            var linkedPages = doc.DocumentNode.Descendants("a")
                                              .Select(a => a.GetAttributeValue("href", null))
                                              .Where(u => !String.IsNullOrEmpty(u)).ToList();
            result.AddRange(linkedPages.Where(x => x.Contains(".onion") || x.Contains(".i2p")).ToList());
            return result;
        }


        public static List<string> ExtractSurfaceUrls(string htmlString)
        {
            List<string> result = new List<string>();
            var doc = new HtmlDocument();
            doc.LoadHtml(htmlString);
            var linkTags = doc.DocumentNode.Descendants("link");
            var linkedPages = doc.DocumentNode.Descendants("a")
                                              .Select(a => a.GetAttributeValue("href", null))
                                              .Where(u => !String.IsNullOrEmpty(u)).ToList();
            result.AddRange(linkedPages.Where(x => !x.Contains(".onion") && !x.Contains(".i2p")).ToList());
            return result;
        }


        public static List<string> ExtractIpUrls(string htmlContent)
        {
            throw new NotImplementedException();
        }

        public static string GetPageTitle(string htmlContent)
        {
            try
            {
                var doc = new HtmlDocument();
                doc.LoadHtml(htmlContent);
                var title = doc.DocumentNode.SelectSingleNode("html/head/title").InnerText;
                return title;
            }
            catch
            {
                return "Null";
            }

        }


        public static void AddRange(this ObservableCollection<Models.QueuedWebsite> collection, List<Models.QueuedWebsite> list)
        {
            foreach (var item in list)
            {
                collection.Add(item);
            }
        }

        /// <summary>
        /// Checks if given url is valid
        /// </summary>
        /// <param name="url"></param>
        /// <returns></returns>
        public static bool UrlIsValid(string url)
        {
            Regex UrlSyntax = new Regex(@"^(?:http(s)?:\/\/)?[\w.-]+(?:\.[\w\.-]+)+[\w\-\._~:/?#[\]@!\$&'\(\)\*\+,;=.]+$");
            if (UrlSyntax.IsMatch(url)) { return true; } else { return false; }
        }

        public static string GetHost(string Url)
        {
            var uri = new Uri(Url);
            return uri.GetLeftPart(UriPartial.Authority);
        }


        public static void SaveResults(string path, List<WebsiteModel> websites = null, List<QueuedWebsite> queuedWebsites= null)
        {
            var file = new FileInfo(path);
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;

            using (var package = new ExcelPackage(file))
            {
                if (File.Exists(path))
                    File.Delete(path);

                var sheet = package.Workbook.Worksheets.Add("Crawled Websites");
                sheet.Cells["A1"].Value = "Title";
                sheet.Cells["B1"].Value = "Host";
                sheet.Cells["C1"].Value = "Parent Link";
                sheet.Cells["D1"].Value = "External Links";
                sheet.Cells["E1"].Value = "Sub Links";
                sheet.Cells["F1"].Value = "Status";

                for (int i = 0; i < websites.Count; i++)
                {
                    var site = websites[i];
                    sheet.Cells[$"A{i + 2}"].Value = site.Title;
                    sheet.Cells[$"B{i + 2}"].Value = site.Host;
                    sheet.Cells[$"C{i + 2}"].Value = site.ParentLink;
                    sheet.Cells[$"D{i + 2}"].Value = site.ExternalLinks;
                    sheet.Cells[$"E{i + 2}"].Value = site.SubLinks.ToList(); ;
                    sheet.Cells[$"F{i + 2}"].Value = "Crawled";
                }

                for (int i = 0; i < queuedWebsites.Count; i++)
                {
                    var site = queuedWebsites[i];
                    var index = i + websites.Count + 2;
                    sheet.Cells[$"B{index}"].Value = site.Url;
                    sheet.Cells[$"C{index}"].Value = site.Parent?.Host + "(Parent)";
                    sheet.Cells[$"F{index}"].Value = "Queued";
                }

                sheet.Column(1).AutoFit();
                sheet.Column(2).AutoFit();
                sheet.Column(3).BestFit = true;
                sheet.Column(4).BestFit = true;
                sheet.Column(5).BestFit = true;
               // sheet.Column(3).ColumnMax = 450;
               // sheet.Column(4).ColumnMax = 450;
               // sheet.Column(5).ColumnMax = 450;

                // Save to file
                package.Save();
            }
        }

        
    }
}
