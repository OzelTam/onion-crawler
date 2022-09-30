using OnionCrawler.Lib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnionCrawler.Win
{
    public static class Program
    {
        public static string ipAddr { get; set; }
        public static string proxyAddr { get; set; }
        public static HttpClient torClient { get; set; }

        public static InternalProxy _interProx { get; set; }
        public static Form1 splash { get; set; }
        public static CrawlerForm crawler { get; set; }
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            splash = new Form1();
            crawler = new CrawlerForm();
            Application.Run(splash);
        }
    }
}
