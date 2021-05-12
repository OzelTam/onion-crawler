using System;
using System.Collections.Generic;
using System.Text;

namespace OnionCrawler.Lib.Models
{
    public class CrawlerOptions
    {
        public string RootWebsite { get; set; }

        /// <summary>
        /// Maximum page to crawl for each Host.
        /// </summary>
        public int MaxSubPageCount { get; set; }  = 5;

        /// <summary>
        /// Maximum Hosts to crawl.
        /// </summary>
        public int MaxWebsiteCount { get; set; } = 150;

        /// <summary>
        /// Include hosts without domain names
        /// </summary>
        public bool IncludeIpHosts { get; set; } = false;

        /// <summary>
        ///  Include surface web hosts.
        /// </summary>
        public bool IncludeClearWeb { get; set; } = true;


        /// <summary>
        /// max link to queue
        /// </summary>
        public int MaxQueue { get; set; } = 150;


        /// <summary>
        /// Tor Socks Proxy Port
        /// </summary>
        public int ProxyPort { get; set; } = 9050;

        /// <summary>
        /// Tor Socks Proxy Host
        /// </summary>
        public string ProxyHost { get; set; } = "127.0.0.1";


        public TimeSpan TimeoutSpan { get; set; } = new TimeSpan(0,0,15);
    }
}
