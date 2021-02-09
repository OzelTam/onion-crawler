using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionCrawLib
{
    public class OnionSite
    {

        public OnionSite(string Host_, string ParantWebsite_ = null)
        {
            Host = Host_;
            parentLink = ParantWebsite_;
        }

        public string Host { get; set; }
        public string parentLink { get; set; }
        public OnionSite parentSite { get; set; }
        public List<OnionSite> subLinks = new List<OnionSite>();
        public List<string> externalLinks = new List<string>();
        public string title = "";
    }
}
