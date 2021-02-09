using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionCrawLib
{
    public class WebStructureOptions
    {
        public string RootWebsite = "";

        /// <summary>
        /// Maximum page to crawl for each Host.
        /// </summary>
        public int MaxSubpages = 5;

        /// <summary>
        /// Maximum Hosts to crawl.
        /// </summary>
        public long MaxHostCount = 100;

        /// <summary>
        /// System bit for Tor.exe.
        /// </summary>
        public bool is32bit = ! Environment.Is64BitProcess;

        /// <summary>
        /// Include hosts without domain names
        /// </summary>
        public bool includeIpHosts = true;

        /// <summary>
        ///  Include surface web hosts.
        /// </summary>
        public bool includeClearWeb = false;


        /// <summary>
        /// max link to queue
        /// </summary>
        public long maxQueue = 150;

        public string TorClientDirectory = "Tor";
    }
}
