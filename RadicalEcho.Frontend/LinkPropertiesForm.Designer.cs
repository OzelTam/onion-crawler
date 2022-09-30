
namespace OnionCrawler.Win
{
    partial class LinkPropertiesForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.listExternalURL = new System.Windows.Forms.ListBox();
            this.listSubURL = new System.Windows.Forms.ListBox();
            this.lblParentSite = new System.Windows.Forms.LinkLabel();
            this.lblParentLink = new System.Windows.Forms.Label();
            this.lblHost = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.listExternalURL);
            this.panel1.Controls.Add(this.listSubURL);
            this.panel1.Controls.Add(this.lblParentSite);
            this.panel1.Controls.Add(this.lblParentLink);
            this.panel1.Controls.Add(this.lblHost);
            this.panel1.Controls.Add(this.lblTitle);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(445, 349);
            this.panel1.TabIndex = 0;
            // 
            // listExternalURL
            // 
            this.listExternalURL.FormattingEnabled = true;
            this.listExternalURL.ItemHeight = 17;
            this.listExternalURL.Location = new System.Drawing.Point(43, 271);
            this.listExternalURL.Name = "listExternalURL";
            this.listExternalURL.Size = new System.Drawing.Size(358, 55);
            this.listExternalURL.TabIndex = 11;
            // 
            // listSubURL
            // 
            this.listSubURL.FormattingEnabled = true;
            this.listSubURL.ItemHeight = 17;
            this.listSubURL.Location = new System.Drawing.Point(43, 171);
            this.listSubURL.Name = "listSubURL";
            this.listSubURL.Size = new System.Drawing.Size(358, 55);
            this.listSubURL.TabIndex = 10;
            // 
            // lblParentSite
            // 
            this.lblParentSite.AutoSize = true;
            this.lblParentSite.Location = new System.Drawing.Point(127, 105);
            this.lblParentSite.Name = "lblParentSite";
            this.lblParentSite.Size = new System.Drawing.Size(46, 17);
            this.lblParentSite.TabIndex = 9;
            this.lblParentSite.TabStop = true;
            this.lblParentSite.Text = "<null>";
            this.lblParentSite.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblParentSite_LinkClicked);
            // 
            // lblParentLink
            // 
            this.lblParentLink.AutoSize = true;
            this.lblParentLink.Location = new System.Drawing.Point(127, 73);
            this.lblParentLink.Name = "lblParentLink";
            this.lblParentLink.Size = new System.Drawing.Size(46, 17);
            this.lblParentLink.TabIndex = 8;
            this.lblParentLink.Text = "<null>";
            // 
            // lblHost
            // 
            this.lblHost.AutoSize = true;
            this.lblHost.Location = new System.Drawing.Point(127, 45);
            this.lblHost.Name = "lblHost";
            this.lblHost.Size = new System.Drawing.Size(46, 17);
            this.lblHost.TabIndex = 7;
            this.lblHost.Text = "<null>";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(127, 18);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(46, 17);
            this.lblTitle.TabIndex = 6;
            this.lblTitle.Text = "<null>";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(164, 251);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "EXTERNAL URL(s)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(185, 151);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "SUBURL(s)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(22, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "PARENT SITE:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(22, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "PARENT URL:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(22, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "HOST:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(22, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "TITLE:";
            // 
            // LinkPropertiesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(475, 373);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "LinkPropertiesForm";
            this.ShowInTaskbar = false;
            this.Text = "Website Properties";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.LinkPropertiesForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListBox listExternalURL;
        private System.Windows.Forms.ListBox listSubURL;
        private System.Windows.Forms.LinkLabel lblParentSite;
        private System.Windows.Forms.Label lblParentLink;
        private System.Windows.Forms.Label lblHost;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}