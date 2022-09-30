using OraclesBridge;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace OnionCrawler.Lib
{
    public class InternalProxy
    {
        public InternalProxy()
        {
        }
        public async Task<bool> Configure()
        {
            await Proxify(9987, 9988, 9989);
            do { int i = 0; i++; Thread.Sleep(1000); } while (!_Configured);
            _ipAddress = ipAddress;
            _proxyAddress = proxyAddress;
            return true;
        }
        public void GracefulClose()
        {
            _proxy.Stop();
        }
        public async Task<bool> GetNewIdentity()
        {
            try
            {
                await getProxiedIP(true);
                _proxyAddress = proxyAddress;
                return true;
            }
            catch (Exception ex)
            {
                await LogException(ex.Message);
                return false;
            }
        }
        internal static TorSharpProxy _proxy { get; set; }
        internal static HttpClient _httpClient { get; set; }
        private string ipAddress { get; set; }
        public static string _ipAddress { get; set; }
        private string proxyAddress { get; set; }
        public static string _proxyAddress = "127.0.0.1";
        private static bool _Configured = false;
        public TimeSpan TimeoutSpan { get; set; } = new TimeSpan(0, 0, 60);

        private async Task<bool> Proxify(int p1, int p2, int p3)
        {
            try
            {
                HttpClient val = new HttpClient();
                try
                {
                    ipAddress = await val.GetStringAsync("http://api.ipify.org");
                }
                catch (Exception ex)
                {
                    await LogException(ex.Message);
                    ipAddress = "127.0.0.1";
                }
                TorSharpSettings settings = new TorSharpSettings
                {
                    ZippedToolsDirectory = Path.Combine(Directory.GetCurrentDirectory(), "TorZipped"),
                    ExtractedToolsDirectory = Path.Combine(Directory.GetCurrentDirectory(), "TorExtracted"),
                    PrivoxySettings =
                    {
                        Port = p1
                    },
                    ToolRunnerType = ToolRunnerType.VirtualDesktop,
                    TorSettings =
                    {
                        SocksPort = p2,
                        ControlPort = p3,
                        ControlPassword = "foobar"
                    }
                };
                await new TorSharpToolFetcher(settings, new HttpClient()).FetchAsync();
                _proxy = new TorSharpProxy(settings);
                var handler = new HttpClientHandler
                {
                    Proxy = new WebProxy(new Uri("http://localhost:" + settings.PrivoxySettings.Port))
                };
                _httpClient = new HttpClient(handler);
                InternalProxy._httpClient.Timeout = TimeoutSpan;
                await _proxy.ConfigureAndStartAsync();
                Thread.Sleep(5000);
                await getProxiedIP();
                return _Configured = true;
            }
            catch (Exception ex)
            {
                await LogException(ex.Message);
                return false;
            }
        }

        private async Task<bool> getProxiedIP(bool switchIdentities = false) 
        {
            try
            {
                if (switchIdentities)
                {
                    proxyAddress = null;
                    await _proxy.GetNewIdentityAsync();
                }
                proxyAddress = await _httpClient.GetStringAsync("http://api.ipify.org");
                return true;
            }
            catch (Exception ex)
            {
                await LogException(ex.Message);
                proxyAddress = "127.0.0.1";
                return false;
            }
        }
        private async Task LogException(string error)
        {
            if (!File.Exists("proxy.logs"))
                File.WriteAllText("proxy.logs", "===== Proxy Logs =====" + Environment.NewLine);
            File.AppendAllText("proxy.logs", DateTime.Now.ToString("g") + " Error: " + error + Environment.NewLine);
        }
    }
}
