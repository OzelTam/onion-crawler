using OnionCrawler.Lib;
using OnionCrawler.Lib.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnionCrawler.Win
{
    public partial class CrawlerForm : Form
    {
        public CrawlerForm()
        {
            InitializeComponent();
        }
        public CrawlerClient Crawler { get; set; }

        private void CrawlerForm_Load(object sender, EventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;
        }

        public async void RenewIdentity(bool renew = false)
        {
            if (renew)
                await Program._interProx.GetNewIdentity();
            if (InvokeRequired)
            {
                Invoke((MethodInvoker)(() =>
                {
                    ipLABEL.Text = Lib.InternalProxy._ipAddress;
                    proxyLABEL.Text = InternalProxy._proxyAddress;
                }));
            }
            else
            {
                ipLABEL.Text = Lib.InternalProxy._ipAddress;
                proxyLABEL.Text = InternalProxy._proxyAddress;
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            try
            {
                if (btnStart.Text == "Start")
                {
                    btnStart.Text = "Pause";
                    StartCrawl();
                    btnContinue.Enabled = false;
                    lblStatus.Text = "Crawling...";
                }
                else
                {
                    btnStart.Text = "Start";
                    btnContinue.Enabled = true;
                    lblStatus.Text = "Pause Requested.";
                    lblStatus.Text = "Pause Requested.";
                    if(Crawler != null)
                        Crawler.RequestCrawlCancellation();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private async void StartCrawl()
        {
            try
            {
                txtInitialURL.Text = txtInitialURL.Text.ToLower();

                var url = txtInitialURL.Text;
                var proxyHost = txtProxyHost.Text;

                if (String.IsNullOrWhiteSpace(url))
                {
                    LogSync("Please enter a valid URL", "ERROR");
                    return;
                }

                if (!url.StartsWith("http"))
                {
                    txtInitialURL.Text = $"http://{txtInitialURL.Text}/";
                    url = txtInitialURL.Text;
                }

                if (String.IsNullOrWhiteSpace(proxyHost))
                    proxyHost = "127.0.0.1";

                CrawlerOptions options = new CrawlerOptions()
                {
                    MaxSubPageCount = (int)numMaxSubpage.Value,
                    MaxQueue = (int)numMaxQueue.Value,
                    MaxWebsiteCount = (int)numMaxWebsite.Value,
                    ProxyPort = (int)numProxyPort.Value,
                    RootWebsite = url,
                    ProxyHost = proxyHost,
                    TimeoutSpan = new TimeSpan(0, 0, (int)numTimeout.Value),
                    IncludeClearWeb = checkSurface.Checked,
                    IncludeIpHosts = checkIp.Checked
                };

                try
                {
                    LogSync("Checking Ip...");
                    LogSync($"Proxy Ip: {Program.proxyAddr}");
                }
                catch (Exception ex)
                {
                    LogSync($"Error while connecting: {ex.Message}", "ERROR");
                    return;
                }

                Crawler = new CrawlerClient(options);

                Crawler.EventResponse += Crawler_EventResponse;

                Crawler.QueuedLinks.CollectionChanged += QueuedLinks_CollectionChanged;
                Crawler.WebStructureObject.CollectionChanged += WebStructureObject_CollectionChanged;


                new Thread(() => Crawler.CrawlAsync().Wait()).Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
         
        }

        private void WebStructureObject_CollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            try
            {
                Application.DoEvents();
                ObservableCollection<WebsiteModel> ts = (ObservableCollection<WebsiteModel>)sender;
                listCrawled.DataSource = ts.ToList();
                listCrawled.DisplayMember = "Title";
                lblCrawled.Text = $"Crawled Count: {ts.Count}";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void QueuedLinks_CollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            try
            {
                Application.DoEvents();
                ObservableCollection<QueuedWebsite> ts = (ObservableCollection<QueuedWebsite>)sender;
                listQueued.DataSource = ts.ToList();
                listQueued.DisplayMember = "Url";
                lblQueued.Text = $"Queued Count: {ts.Count}";
            }
            catch ( Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Crawler_EventResponse(object sender, string e)
        {
            if (e.ToLower().Contains("cancelled"))
            {
                lblStatus.Text = "Crawling Paused";

            }else if(e.Contains("DONE CRAWLING"))
            {
                btnContinue.Enabled = false;
                btnStart.Enabled = false;
                btnStart.Text = "Start";
                lblStatus.Text = "Done Crawling";
                btnStart.Enabled = true;
            }

            if (!e.StartsWith("ERROR"))
                LogSync(e);
            else
                LogSync(e.Replace("ERROR:", ""), "ERROR");
        }

        private void CheckKeyword(string word, Color color, int startIndex = 0)
        {
            if (rtbOutput.Text.Contains(word))
            {
                int index = -1;
                int selectStart = rtbOutput.SelectionStart;

                while ((index = rtbOutput.Text.IndexOf(word, (index + 1))) != -1)
                {
                    rtbOutput.Select((index + startIndex), word.Length);
                    rtbOutput.SelectionColor = color;
                    rtbOutput.Select(selectStart, 0);
                    rtbOutput.SelectionColor = Color.Black;
                }
            }
        }
        private void LogSync(string input, string logType = "EVENT")
        {
            if (rtbOutput.InvokeRequired)
            {
                rtbOutput.Invoke((MethodInvoker)(() => rtbOutput.Text += ">" + logType + ": " + input + "\n"));
            }
            else { rtbOutput.Text += ">" + logType + ": " + input + "\n"; }
        }


        private async void button1_Click(object sender, EventArgs e)
        {


            try
            {
                var url = txtInitialURL.Text;
                if (!url.StartsWith("http"))
                {
                    txtInitialURL.Text = $"http://{txtInitialURL.Text}/";
                    url = txtInitialURL.Text;
                }


                Crawler = new CrawlerClient(new CrawlerOptions()
                {
                    RootWebsite = url
                });
                var q = await Crawler.DownloadWebsiteAsync(url);
                LogSync(q);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void rtbOutput_TextChanged_1(object sender, EventArgs e)
        {
            CheckKeyword(">ERROR: ", Color.Red);
            CheckKeyword(">WARNING: ", Color.OrangeRed);
            CheckKeyword(">EVENT: ", Color.BlueViolet);
            CheckKeyword("Error Message:", Color.IndianRed);
            rtbOutput.SelectionStart = rtbOutput.Text.Length;
            rtbOutput.ScrollToCaret();
        }

        private void listCrawled_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                if (listCrawled.SelectedIndex > -1)
                {
                    var websites = (List<WebsiteModel>)listCrawled.DataSource;
                    var form = new LinkPropertiesForm() { Website = websites[listCrawled.SelectedIndex] };
                    form.Show();
                }
            }
            catch ( Exception ex)
            {

                MessageBox.Show(ex.Message, "Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnContinue_Click(object sender, EventArgs e)
        {
            try
            {
                if (Crawler != null)
                {
                    lblStatus.Text = "Crawling Resumed.";
                    btnStart.Text = "Pause";
                    btnContinue.Enabled = false;
                    new Thread(() => { Crawler.CrawlAsync(true).Wait(); }).Start();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }

        private void listQueued_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                if(listQueued.SelectedIndex > -1)
                {
                    var queue = (List<QueuedWebsite>) listQueued.DataSource;
                    var form = new QueuedPropertisForm() { Website = queue[listCrawled.SelectedIndex] };
                    form.Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void pbxSave_Click(object sender, EventArgs e)
        {
       
            var QueuedList = (List<QueuedWebsite>)listQueued.DataSource;
            var WebsitesList = (List<WebsiteModel>)listCrawled.DataSource;

            if (QueuedList == null || WebsitesList == null)
                return;

            var sfrm = new SaveResultsForm() { WebsiteModels = WebsitesList, QueuedWebsites = QueuedList };
            sfrm.Show(); 

        }

        private void CrawlerForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Program._interProx.GracefulClose();
            Environment.Exit(0);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            RenewIdentity(true);
        }
    }
}
