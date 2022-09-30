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
    public partial class QueuedPropertisForm : Form
    {
        public QueuedPropertisForm()
        {
            InitializeComponent();
        }

        private QueuedWebsite website;
        public QueuedWebsite Website { get { return website; }
            set
            {
                website = value;
                lblParent.Text = value.Parent?.Title;
                lblUrl.Text = value.Url;
            } 
        }

        private void lblParent_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if(website.Parent != null)
            {
                var form = new LinkPropertiesForm() { Website = website.Parent };
                form.Show();
            }
        }
    }
}
