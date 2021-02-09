
namespace crawlerForm
{
    partial class LinkProperties
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.listExternalUrls = new System.Windows.Forms.ListBox();
            this.listSubUrls = new System.Windows.Forms.ListBox();
            this.linkParentSite = new System.Windows.Forms.LinkLabel();
            this.lblParentLink = new System.Windows.Forms.Label();
            this.lblHost = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.crawledHosts = new System.Windows.Forms.ListBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lblqHost = new System.Windows.Forms.Label();
            this.lblqParent = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.queuedLinks = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(1, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(818, 409);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.listExternalUrls);
            this.tabPage1.Controls.Add(this.listSubUrls);
            this.tabPage1.Controls.Add(this.linkParentSite);
            this.tabPage1.Controls.Add(this.lblParentLink);
            this.tabPage1.Controls.Add(this.lblHost);
            this.tabPage1.Controls.Add(this.lblTitle);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.crawledHosts);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(810, 380);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Crawled";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // listExternalUrls
            // 
            this.listExternalUrls.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listExternalUrls.FormattingEnabled = true;
            this.listExternalUrls.ItemHeight = 16;
            this.listExternalUrls.Location = new System.Drawing.Point(444, 271);
            this.listExternalUrls.Name = "listExternalUrls";
            this.listExternalUrls.Size = new System.Drawing.Size(288, 68);
            this.listExternalUrls.TabIndex = 25;
            // 
            // listSubUrls
            // 
            this.listSubUrls.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listSubUrls.FormattingEnabled = true;
            this.listSubUrls.ItemHeight = 16;
            this.listSubUrls.Location = new System.Drawing.Point(444, 172);
            this.listSubUrls.Name = "listSubUrls";
            this.listSubUrls.Size = new System.Drawing.Size(288, 68);
            this.listSubUrls.TabIndex = 24;
            // 
            // linkParentSite
            // 
            this.linkParentSite.AutoSize = true;
            this.linkParentSite.Location = new System.Drawing.Point(444, 135);
            this.linkParentSite.Name = "linkParentSite";
            this.linkParentSite.Size = new System.Drawing.Size(47, 16);
            this.linkParentSite.TabIndex = 23;
            this.linkParentSite.TabStop = true;
            this.linkParentSite.Text = "<null>";
            this.linkParentSite.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkParentSite_LinkClicked);
            // 
            // lblParentLink
            // 
            this.lblParentLink.AutoSize = true;
            this.lblParentLink.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblParentLink.Location = new System.Drawing.Point(444, 100);
            this.lblParentLink.Name = "lblParentLink";
            this.lblParentLink.Size = new System.Drawing.Size(50, 17);
            this.lblParentLink.TabIndex = 22;
            this.lblParentLink.Text = "<null>";
            // 
            // lblHost
            // 
            this.lblHost.AutoSize = true;
            this.lblHost.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblHost.Location = new System.Drawing.Point(444, 68);
            this.lblHost.Name = "lblHost";
            this.lblHost.Size = new System.Drawing.Size(50, 17);
            this.lblHost.TabIndex = 21;
            this.lblHost.Text = "<null>";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitle.Location = new System.Drawing.Point(444, 40);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(50, 17);
            this.lblTitle.TabIndex = 20;
            this.lblTitle.Text = "<null>";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(402, 40);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 16);
            this.label6.TabIndex = 19;
            this.label6.Text = "Title";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(337, 271);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 16);
            this.label5.TabIndex = 18;
            this.label5.Text = "External Url(s)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(365, 172);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 16);
            this.label4.TabIndex = 17;
            this.label4.Text = "Sub Url(s)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(357, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 16);
            this.label3.TabIndex = 16;
            this.label3.Text = "Parent Site";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(358, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 16);
            this.label2.TabIndex = 15;
            this.label2.Text = "Parent Link";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(401, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 16);
            this.label1.TabIndex = 14;
            this.label1.Text = "Host";
            // 
            // crawledHosts
            // 
            this.crawledHosts.FormattingEnabled = true;
            this.crawledHosts.ItemHeight = 16;
            this.crawledHosts.Location = new System.Drawing.Point(12, 15);
            this.crawledHosts.Name = "crawledHosts";
            this.crawledHosts.Size = new System.Drawing.Size(315, 356);
            this.crawledHosts.TabIndex = 13;
            this.crawledHosts.SelectedIndexChanged += new System.EventHandler(this.crawledHosts_SelectedIndexChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.lblqHost);
            this.tabPage2.Controls.Add(this.lblqParent);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.queuedLinks);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(810, 380);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Queued";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // lblqHost
            // 
            this.lblqHost.AutoSize = true;
            this.lblqHost.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblqHost.Location = new System.Drawing.Point(606, 60);
            this.lblqHost.Name = "lblqHost";
            this.lblqHost.Size = new System.Drawing.Size(50, 17);
            this.lblqHost.TabIndex = 25;
            this.lblqHost.Text = "<null>";
            // 
            // lblqParent
            // 
            this.lblqParent.AutoSize = true;
            this.lblqParent.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblqParent.Location = new System.Drawing.Point(606, 32);
            this.lblqParent.Name = "lblqParent";
            this.lblqParent.Size = new System.Drawing.Size(50, 17);
            this.lblqParent.TabIndex = 24;
            this.lblqParent.Text = "<null>";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(550, 32);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(50, 16);
            this.label9.TabIndex = 23;
            this.label9.Text = "Parent";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(549, 60);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(24, 16);
            this.label10.TabIndex = 22;
            this.label10.Text = "Url";
            // 
            // queuedLinks
            // 
            this.queuedLinks.FormattingEnabled = true;
            this.queuedLinks.ItemHeight = 16;
            this.queuedLinks.Location = new System.Drawing.Point(7, 12);
            this.queuedLinks.Name = "queuedLinks";
            this.queuedLinks.Size = new System.Drawing.Size(512, 356);
            this.queuedLinks.TabIndex = 0;
            this.queuedLinks.SelectedIndexChanged += new System.EventHandler(this.queuedLinks_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(698, 417);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 37);
            this.button1.TabIndex = 1;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(565, 426);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(127, 20);
            this.checkBox1.TabIndex = 2;
            this.checkBox1.Text = "Include queued";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // LinkProperties
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(818, 459);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "LinkProperties";
            this.Text = "LinkProperties";
            this.Load += new System.EventHandler(this.LinkProperties_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.ListBox listExternalUrls;
        private System.Windows.Forms.ListBox listSubUrls;
        private System.Windows.Forms.LinkLabel linkParentSite;
        private System.Windows.Forms.Label lblParentLink;
        private System.Windows.Forms.Label lblHost;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox crawledHosts;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblqHost;
        private System.Windows.Forms.Label lblqParent;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ListBox queuedLinks;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}