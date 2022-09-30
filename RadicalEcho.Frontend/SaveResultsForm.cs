using OnionCrawler.Lib;
using OnionCrawler.Lib.Models;
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

namespace OnionCrawler.Win
{
    public partial class SaveResultsForm : Form
    {
        private List<WebsiteModel> websiteModels;
        private List<QueuedWebsite> queuedWebsites;

        public SaveResultsForm()
        {
            InitializeComponent();
        }
        public List<WebsiteModel> WebsiteModels { get => websiteModels; set 
            { 
                websiteModels = value;
                checkCrawled.Text += $"({value.Count})"; 
            } }
        public List<QueuedWebsite> QueuedWebsites { get => queuedWebsites; set 
            { 
                queuedWebsites = value; 
                checkQueued.Text += $"({value.Count})";
            } }



        private void btnBrowse_Click(object sender, EventArgs e)
        {
            var sfd = new SaveFileDialog() { AddExtension = true, Filter = "Excel Files|*.xlsx", Title = "Save Path" };
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                txtBrowsedPath.Text = sfd.FileName;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtBrowsedPath.Text))
            { MessageBox.Show("Please specify save path.", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; }
            else
            {
                var path = txtBrowsedPath.Text;
                if (checkQueued.Checked && checkCrawled.Checked)
                {
                    new Thread(() =>
                    {
                        Common.SaveResults(path, websiteModels, QueuedWebsites);
                        this.Close();
                    }).Start();
                }else if(checkCrawled.Checked)
                {
                    new Thread(() =>
                    {
                        Common.SaveResults(path, websiteModels, new List<QueuedWebsite>());
                        this.Close();
                    }).Start();
                }else if (checkQueued.Checked)
                {
                    new Thread(() =>
                    {
                        Common.SaveResults(path, new List<WebsiteModel>(), QueuedWebsites);
                        this.Close();
                    }).Start();
                }
               
            }
            
        }
    }
}
