using Microsoft.VisualBasic.Logging;
using OnionCrawler.Lib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Timer = System.Windows.Forms.Timer;

namespace OnionCrawler.Win
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            progressBar1.Value = 0;

        }

        private Mutex mutex = new Mutex();
        public void SyncedClose()
        {
            mutex.WaitOne();
            this.Close();
            mutex.ReleaseMutex();
        }
        public void UpdateProgressBar(int percentage)
        {

            if (this.InvokeRequired)
            {
                mutex.WaitOne();
                if (!IsDisposed)
                    this.BeginInvoke(new Action<int>(UpdateProgresPRV), percentage);
                mutex.ReleaseMutex();
            }
            else
            {
                UpdateProgresPRV(percentage);
            }
        }

        private void UpdateProgresPRV(int per)
        {
            if (progressBar1.IsDisposed) return;
            progressBar1.Value += per;
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Value += 2; //we will increment the value of the progressbar by +2
            progressBar1.Text = progressBar1.Value.ToString() + "%";
            //UpdateProgressBar(2);
            if (progressBar1.Value >= 92 && !_ok)
            {
                progressBar1.Value = 2;
            }
            if (_ok && InternalProxy._proxyAddress != "127.0.0.1")
            { 
                timer1.Enabled = false;
                Program.crawler.RenewIdentity();
                Program.crawler.Show(); // to show the login form
                this.Hide(); // to hide this screen
            }
            if (progressBar1.Value > 0 && progressBar1.Value <= 33 && !blabel1.Visible)
            {
                blabel1.Visible = true;
            }
            if (progressBar1.Value > 33 && progressBar1.Value <= 66 && !blabel2.Visible)
            {
                blabel2.Visible = true;
            }
            if (progressBar1.Value > 66 && progressBar1.Value <= 99 && !blabel3.Visible)
            {
                blabel3.Visible = true;
            }
        }
        private static int _count = -1;
        private void labelTimer_Tick(object sender, EventArgs e)
        {
            _count++;
            switch (_count)
            {
                case 0:
                    pbpLabel.Text = "Please be Patient";
                    break;
                case 1:
                    pbpLabel.Text = "Please be Patient.";
                    break;
                case 2:
                    pbpLabel.Text = "Please be Patient..";
                    break;
                case 3:
                    pbpLabel.Text = "Please be Patient...";
                    break;
                default:
                    _count = -1;
                    break;
            }
        }
        private static bool _ok = false;
        private static Timer labelTimer;
        private async void Splash_Screen_Load(object sender, EventArgs e)
        {
            labelTimer = new Timer();
            labelTimer.Enabled = true;
            labelTimer.Interval = 150;
            labelTimer.Tick += labelTimer_Tick;
            labelTimer.Start();
            timer1.Enabled = true;
            timer1.Interval = 400;
            timer1.Start();
            Program._interProx = new Lib.InternalProxy();
            _ok = await Program._interProx.Configure();

        }
    }
}
