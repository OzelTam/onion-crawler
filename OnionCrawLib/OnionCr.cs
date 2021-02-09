using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace OnionCrawLib
{
    /// <summary>
    /// A class that contains Static methods.
    /// </summary>
    public static class OnionCr
    {
        public async static Task<string> GetIpAsync(HttpClient httpClient = null)
        {
            var requestUri = "http://icanhazip.com/";
            string Ip = "";

            if(httpClient == null) {
                using (httpClient = new HttpClient())
                {
                    var message = await httpClient.GetAsync(requestUri);
                    var content = await message.Content.ReadAsStringAsync();
                    Ip= content;               
                }
             //   if (httpClient != null) { httpClient.Dispose(); }
            }
            else
            {
                    var message = await httpClient.GetAsync(requestUri);
                    var content = await message.Content.ReadAsStringAsync();
                    Ip= content;
            }
            
            return Ip;
            
        }

        public static bool UrlValidator(string url)
        {
            Regex UrlSyntax = new Regex(@"^(?:http(s)?:\/\/)?[\w.-]+(?:\.[\w\.-]+)+[\w\-\._~:/?#[\]@!\$&'\(\)\*\+,;=.]+$");
            if (UrlSyntax.IsMatch(url)) { return true; } else { return false; }
        }





        //private static Regex onionRegEx = new Regex(@"http://(\S*)\.onion", RegexOptions.Compiled|RegexOptions.IgnoreCase);

        public static List<string> ExtractOnionUrls(string htmlString)
        {

            List<string> result = new List<string>();
            var doc = new HtmlDocument();
            doc.LoadHtml(htmlString);
            var linkTags = doc.DocumentNode.Descendants("link");
            var linkedPages = doc.DocumentNode.Descendants("a")
                                              .Select(a => a.GetAttributeValue("href", null))
                                              .Where(u => !String.IsNullOrEmpty(u)).ToList();
            result.AddRange(linkedPages.Where(x=> x.Contains(".onion") || x.Contains(".i2p")).ToList());
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
            result.AddRange(linkedPages.Where(x => !x.Contains(".onion")&& !x.Contains(".i2p")).ToList());
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


        public static void AddRange(this ObservableCollection<QueuedUrl> collection, List<QueuedUrl> list)
        {
            foreach(var item in list)
            {
                collection.Add(item);
            }
        }
    }
}
