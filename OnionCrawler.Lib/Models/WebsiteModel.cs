using System;
using System.Collections.Generic;
using System.Text;

namespace OnionCrawler.Lib.Models
{
    public class WebsiteModel
    {
        public string Title { get; set; }
        public string Host { get; set; }
        public string ParentLink { get; set; }
        public WebsiteModel ParentSite { get; set; }
        public List<string> SubLinks { get; set; } = new List<string>();
        public List<string> ExternalLinks { get; set; }  = new List<string>();
        public WebsiteModel(string host, string parentLink = null)
        {
            Host = host;
            ParentLink = parentLink;
        }
    }
}
