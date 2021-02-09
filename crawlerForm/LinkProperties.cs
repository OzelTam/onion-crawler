using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Windows.Forms;
using OnionCrawLib;
namespace crawlerForm
{
    public partial class LinkProperties : Form
    {
        public LinkProperties(List<OnionSite> webStructureObject_, List<QueuedUrl> queuedUrls_)
        {
            InitializeComponent();
            webStructureObject = webStructureObject_;
            queuedUrls = queuedUrls_;
        }

        public List<OnionSite> webStructureObject { get; set; }
        public List<QueuedUrl> queuedUrls { get; set; }

        private void LinkProperties_Load(object sender, EventArgs e)
        {
            crawledHosts.DataSource = webStructureObject;
            crawledHosts.DisplayMember = "Host";
            queuedLinks.DataSource = queuedUrls;
            queuedLinks.DisplayMember = "url";
        }


        private OnionSite currentParSide = null;
        private void crawledHosts_SelectedIndexChanged(object sender, EventArgs e)
        {
            listExternalUrls.Items.Clear();
            listSubUrls.DataSource = null;
            listSubUrls.Items.Clear();

            if(crawledHosts.SelectedIndex > -1)
            {
                var site = webStructureObject[crawledHosts.SelectedIndex];
                lblHost.Text = site.Host;
                lblParentLink.Text = site.parentLink;
                lblTitle.Text = site.title;
                listExternalUrls.Items.AddRange(site.externalLinks.ToArray());
                listSubUrls.DataSource = site.subLinks;
                listSubUrls.DisplayMember = "url";
                if(site.parentSite == null)
                {
                    linkParentSite.Text = "<null>";
                }
                else
                {
                    linkParentSite.Text = site.parentSite.Host;
                }
               
                currentParSide = site.parentSite;
            }
        }

        private void queuedLinks_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (queuedLinks.SelectedIndex > -1)
            {
                var site = queuedUrls[queuedLinks.SelectedIndex];
                lblqHost.Text = site.url;
                lblqParent.Text = site.parent;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string SaveText = "";
            foreach(var site in webStructureObject)
            {
                var item = site.Host + "    -   " + site.title;
                SaveText += item + "\n";
            }


            if (checkBox1.Checked)
            {
                SaveText += "\n Queued \n\n";
                foreach (var site in queuedUrls)
                {
                    var item = site.url + "    -   " ;
                    SaveText += item + "\n";
                }
            }

            SaveFileDialog sfd = new SaveFileDialog()
            {
                Filter = "txt|*.txt|All Files|*.*"
            };
            if(sfd.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(sfd.FileName, SaveText);
            }

        }

        private void linkParentSite_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if(currentParSide != null)
            {
                crawledHosts.SelectedIndex = webStructureObject.IndexOf(currentParSide);
            }
        }
    }
}
