using OnionCrawler.Lib.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnionCrawler.Win
{
    public partial class LinkPropertiesForm : Form
    {
        public LinkPropertiesForm()
        {
            InitializeComponent();
        }


        private WebsiteModel website;
        public WebsiteModel Website { get{ return website; } 
            set
            {
                website = value;
                if (!String.IsNullOrWhiteSpace(value.Title))
                    lblTitle.Text = value.Title;
                if (!String.IsNullOrWhiteSpace(value.Host))
                    lblHost.Text = value.Host;
                if (!String.IsNullOrWhiteSpace(value.ParentLink))
                    lblParentLink.Text = value.ParentLink;
                if (value.ParentSite != null)
                    lblParentSite.Text = value.ParentSite.Title;

                listSubURL.Items.AddRange(value.SubLinks?.ToArray());
                listExternalURL.Items.AddRange(value.ExternalLinks?.ToArray());
                this.Text += $" ({value.Title})";
            } 
        }

        private void LinkPropertiesForm_Load(object sender, EventArgs e)
        {

        }

        private void lblParentSite_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if(website.ParentSite != null)
            {
                var form = new LinkPropertiesForm() { Website = website.ParentSite };
                form.Show();
            }
        }
    }
}
