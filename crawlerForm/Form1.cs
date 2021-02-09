using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OnionCrawLib;
using System.Windows.Forms;
using System.IO;
using System.Collections.ObjectModel;
using System.Threading;
using System.Diagnostics;

namespace crawlerForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private WebStructure webStructure = null;



        private void txtRootWP_TextChanged(object sender, EventArgs e)
        {
            btnInitWebStrucure.Enabled = OnionCr.UrlValidator(txtRootWP.Text);
        }


        /// <summary>
        /// Initialize Web structure.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void btnInitWebStrucure_Click(object sender, EventArgs e)
        {
            if (!txtRootWP.Text.StartsWith("http")) { txtRootWP.Text = "http://" + txtRootWP.Text + "/"; }
            groupInit.Enabled = false;
            try
            {
                WebStructureOptions options = new WebStructureOptions()
                {
                    RootWebsite = txtRootWP.Text,
                    MaxHostCount = Convert.ToInt32(numMaxHosts.Value),
                    MaxSubpages = Convert.ToInt32(numMaxSubPages.Value),
                    TorClientDirectory = Path.Combine(Application.StartupPath, "Tor Files"),
                    includeClearWeb = checkClearNet.Checked,
                    includeIpHosts = checkIpHosts.Checked
                    ,maxQueue = Convert.ToInt32(numMaxQueue.Value),

                };
                switch (cbArch.Text){
                    case "x86":
                        options.is32bit = true;
                        break;
                    case "x64":
                        options.is32bit = false;
                        break;
                    default:
                        break;
                }
                webStructure = new WebStructure(options);
                webStructure.EventResponse += WebStructure_EventResponse;
                await webStructure.InitAsync();
            }
            catch (Exception ex)
            {
                groupInit.Enabled = true;
                LogSync(ex.Message, "ERROR");
            }
        
        }


        private void WebStructure_EventResponse(object sender, string e)
        {
            if (e.StartsWith("ERROR:"))
            {
                LogSync(e.Remove(0, 6), "ERROR");
                return;
            }
            if(e.Contains("initialization completed"))
            {
                if (this.InvokeRequired)
                {
                    this.Invoke((MethodInvoker)(() => this.groupInit.Visible = false));
                    this.Invoke((MethodInvoker)(() => this.toolBar.Enabled = true));
                    this.Invoke((MethodInvoker)(() => this.groupWebStructure.Enabled = true));
                    this.Invoke((MethodInvoker)(() => this.groupWebStructure.Dock= DockStyle.Fill));
                }
                else
                {
                    this.groupInit.Visible = false;
                    this.toolBar.Enabled = true;
                    this.groupWebStructure.Enabled = true;
                    this.groupWebStructure.Dock = DockStyle.Fill;
                }
            }
            if(e =="DONE CRAWLING.") { stopWatch.Stop();
                time.Stop();
                stopWatch = null;
            }
            LogSync(e);

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
        private void LogSync(string input,string logType = "EVENT")
        {
            if (rtbOutput.InvokeRequired)
            {
                rtbOutput.Invoke((MethodInvoker)(() => rtbOutput.Text += ">"+logType+": " + input + "\n"));
            }
            else { rtbOutput.Text += ">" + logType + ": " + input + "\n"; }
        }
        private void rtbOutput_TextChanged(object sender, EventArgs e)
        {
            CheckKeyword(">ERROR: ", Color.Red);
            CheckKeyword(">WARNING: ", Color.OrangeRed);
            CheckKeyword(">EVENT: ", Color.BlueViolet);
            CheckKeyword("Error Message:", Color.IndianRed);
            rtbOutput.SelectionStart = rtbOutput.Text.Length;
            rtbOutput.ScrollToCaret();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LogSync("Hi there, this software is made by Me!: https://github.com/OzelTam. \n " +
                "Feel free to contribute and mess with my source code.", "Broadcast");
        // CheckForIllegalCrossThreadCalls = false;
        }


        private void resetAll()
        {
            try
            {
                
                time.Stop();
                stopWatch = null;
                webStructure.RequestCrawlCancellation();
                webStructure = null;
                groupInit.Visible = true;
                toolBar.Enabled = false;
                groupInit.Enabled = true;
                lblHostCount.Text = "0";
                lblQueuedLinks.Text = "0";
                lblTotalCount.Text = "0";
                listHosts.Items.Clear();
                listQueuedUrls.Items.Clear();
            }
            catch { }

            LogSync("Layout reset.");
        }




        private async void toolBar_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            try
            {
                if (e.ClickedItem.Text == "re-Install Tor Files")
                {
                    await webStructure.InstallTorAsync();
                }
                else if (e.ClickedItem.Text == "Uninstall Tor Files")
                {
                    webStructure.UninstallTor();
                    groupInit.Enabled = true;
                    groupWebStructure.Enabled = false;
                }
                else if(e.ClickedItem.Text == "Check For Updates")
                {
                    var update = await webStructure.CheckForTorUpdatesAsyc();
                    if (update)
                    {
                        var q = MessageBox.Show("There is an update available. Would you like to install ?","Update Available",MessageBoxButtons.YesNo);
                        if(q == DialogResult.Yes)
                        {
                            await webStructure.InstallTorAsync();
                        }
                    }
                    else
                    {
                        MessageBox.Show("You are up to date.", "No Update Available.");
                    }

                }
            }catch (Exception ex)
            {
                LogSync(ex.Message, "ERROR");
            }
          
        }


        Stopwatch stopWatch = null;

        private async void btnCrawl_Click(object sender, EventArgs e)
        {
            stopWatch = new Stopwatch();
            stopWatch.Start();
            time.Start();
            webStructure.queuedLinks.CollectionChanged += QueuedLinks_CollectionChanged;
            webStructure.WebStructureObject.CollectionChanged += WebStructureObject_CollectionChanged;
            try
            {
                if (checkSepThreads.Checked)
                {
                    CheckForIllegalCrossThreadCalls = false;
                new Thread(() =>
                      {
                          webStructure.CrawlAsync().Wait();
                      }).Start();
                }
                else
                {
                    await webStructure.CrawlAsync();
                }
                btnCrawl.Enabled = false;
            }
            catch(Exception ex)
            {
                LogSync(ex.Message, "ERROR");
                
            }
           
        }

        private void WebStructureObject_CollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            Application.DoEvents();
            ObservableCollection<OnionSite> ts = (ObservableCollection<OnionSite>)sender;
            listHosts.DataSource = ts.ToList();
            listHosts.DisplayMember = "Host";
            lblHostCount.Text = ts.Count.ToString();
        }

        private void QueuedLinks_CollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            Application.DoEvents();
            ObservableCollection<QueuedUrl> ts = (ObservableCollection<QueuedUrl>)sender;
            listQueuedUrls.DataSource = ts.ToList();
            listQueuedUrls.DisplayMember = "url";
            lblQueuedLinks.Text = ts.Count.ToString();
        }



        private void groupInit_VisibleChanged(object sender, EventArgs e)
        {
            groupWebStructure.Visible = !groupInit.Visible;
            btnCrawl.Enabled = !groupInit.Visible;
            button1.Enabled = !groupInit.Visible;
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            try
            {

                panel1.Enabled = false;
                var htmlText = await webStructure.DownloadWebsiteAsync(txtRootWP.Text);
                btnCrawl.Enabled = true;
                panel1.Enabled = true;
                button1.Enabled = false;
            }
            catch(Exception ex)
            {
                LogSync("While Testing the page.\n Error Message:"+ex.Message, "ERROR");
                resetAll();
                
            }
            
        }

        private async void button2_Click(object sender, EventArgs e)
        {
            if(button2.Text == "Pause")
            {
                webStructure.RequestCrawlCancellation();
                button2.Text = "continue";
                try
                {
                    Thread.Sleep(3000);
                 LinkProperties linkProperties = new LinkProperties(webStructure.WebStructureObject.ToList(), webStructure.queuedLinks.ToList());
                 linkProperties.Show();
                }
                catch { }
                stopWatch.Stop();
                time.Stop();
            }
            else
            {
                button2.Text = "Pause";

                if (checkSepThreads.Checked)
                {
                    CheckForIllegalCrossThreadCalls = false;
                    new Thread(() =>
                    {
                        webStructure.CrawlAsync(true).Wait();
                    }).Start();
                }
                else
                {
                    await webStructure.CrawlAsync(true);
                }
                stopWatch.Start();
                time.Start();
            }


        }

        private void button3_Click(object sender, EventArgs e)
        {
            resetAll();
        }

        private void listHosts_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void time_Tick(object sender, EventArgs e)
        {
            if(stopWatch != null)
            {
                if (stopWatch.IsRunning)
                {

                    TimeSpan ts = stopWatch.Elapsed;
                    string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
           ts.Hours, ts.Minutes, ts.Seconds,
           ts.Milliseconds / 10);
                    lblTime.Text = elapsedTime;
                }
            }
        }

        //  Using I As New WebClient
        // I.Encoding = Encoding.UTF8
        // I.Proxy = TorClient.Proxy.WebProxy
        // w_Line("Proxy: " + TorClient.Proxy.Address)
        //             w_Line("Requesting the page. (" + Link + ")")
        //             HTML = I.DownloadString(New Uri(Link))
        //
        //         End Using
    } 
}
