
namespace OnionCrawler.Win
{
    partial class CrawlerForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkIp = new System.Windows.Forms.CheckBox();
            this.checkSurface = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.numTimeout = new System.Windows.Forms.NumericUpDown();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pbxSave = new System.Windows.Forms.PictureBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblStat = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnContinue = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.numProxyPort = new System.Windows.Forms.NumericUpDown();
            this.txtInitialURL = new System.Windows.Forms.TextBox();
            this.txtProxyHost = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.numMaxQueue = new System.Windows.Forms.NumericUpDown();
            this.numMaxSubpage = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.numMaxWebsite = new System.Windows.Forms.NumericUpDown();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.listCrawled = new System.Windows.Forms.ListBox();
            this.lblCrawled = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.listQueued = new System.Windows.Forms.ListBox();
            this.lblQueued = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.rtbOutput = new System.Windows.Forms.RichTextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numTimeout)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxSave)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numProxyPort)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMaxQueue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMaxSubpage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMaxWebsite)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkIp);
            this.groupBox1.Controls.Add(this.checkSurface);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.numTimeout);
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.numProxyPort);
            this.groupBox1.Controls.Add(this.txtInitialURL);
            this.groupBox1.Controls.Add(this.txtProxyHost);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.numMaxQueue);
            this.groupBox1.Controls.Add(this.numMaxSubpage);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.numMaxWebsite);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(298, 451);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Settings";
            // 
            // checkIp
            // 
            this.checkIp.AutoSize = true;
            this.checkIp.Enabled = false;
            this.checkIp.Location = new System.Drawing.Point(25, 281);
            this.checkIp.Name = "checkIp";
            this.checkIp.Size = new System.Drawing.Size(110, 19);
            this.checkIp.TabIndex = 12;
            this.checkIp.Text = "Include IP Links";
            this.checkIp.UseVisualStyleBackColor = true;
            // 
            // checkSurface
            // 
            this.checkSurface.AutoSize = true;
            this.checkSurface.Checked = true;
            this.checkSurface.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkSurface.Location = new System.Drawing.Point(25, 256);
            this.checkSurface.Name = "checkSurface";
            this.checkSurface.Size = new System.Drawing.Size(167, 19);
            this.checkSurface.TabIndex = 11;
            this.checkSurface.Text = "Include Surface Web Links";
            this.checkSurface.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 210);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 15);
            this.label6.TabIndex = 10;
            this.label6.Text = "Timeout Seconds:";
            // 
            // numTimeout
            // 
            this.numTimeout.Location = new System.Drawing.Point(132, 208);
            this.numTimeout.Maximum = new decimal(new int[] {
            240,
            0,
            0,
            0});
            this.numTimeout.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numTimeout.Name = "numTimeout";
            this.numTimeout.Size = new System.Drawing.Size(151, 23);
            this.numTimeout.TabIndex = 9;
            this.numTimeout.Value = new decimal(new int[] {
            15,
            0,
            0,
            0});
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.pbxSave);
            this.panel1.Controls.Add(this.lblStatus);
            this.panel1.Controls.Add(this.lblStat);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(14, 329);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(10);
            this.panel1.Size = new System.Drawing.Size(271, 101);
            this.panel1.TabIndex = 1;
            // 
            // pbxSave
            // 
            this.pbxSave.Image = global::OnionCrawler.Win.Properties.Resources._256_2567927_free_floppy_disk_icon_download_floppy_disk_icon;
            this.pbxSave.Location = new System.Drawing.Point(229, 65);
            this.pbxSave.Name = "pbxSave";
            this.pbxSave.Size = new System.Drawing.Size(27, 25);
            this.pbxSave.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxSave.TabIndex = 4;
            this.pbxSave.TabStop = false;
            this.pbxSave.Click += new System.EventHandler(this.pbxSave_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(53, 70);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(58, 15);
            this.lblStatus.TabIndex = 3;
            this.lblStatus.Text = "Waiting...";
            // 
            // lblStat
            // 
            this.lblStat.AutoSize = true;
            this.lblStat.Location = new System.Drawing.Point(10, 70);
            this.lblStat.Name = "lblStat";
            this.lblStat.Size = new System.Drawing.Size(43, 15);
            this.lblStat.TabIndex = 1;
            this.lblStat.Text = "Status:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnContinue);
            this.panel2.Controls.Add(this.btnStart);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(10, 10);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(249, 52);
            this.panel2.TabIndex = 2;
            // 
            // btnContinue
            // 
            this.btnContinue.Enabled = false;
            this.btnContinue.Location = new System.Drawing.Point(146, 11);
            this.btnContinue.Name = "btnContinue";
            this.btnContinue.Size = new System.Drawing.Size(85, 29);
            this.btnContinue.TabIndex = 2;
            this.btnContinue.Text = "Continue";
            this.btnContinue.UseVisualStyleBackColor = true;
            this.btnContinue.Click += new System.EventHandler(this.btnContinue_Click);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(23, 11);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(85, 29);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "Proxy Port";
            // 
            // numProxyPort
            // 
            this.numProxyPort.Location = new System.Drawing.Point(132, 92);
            this.numProxyPort.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.numProxyPort.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numProxyPort.Name = "numProxyPort";
            this.numProxyPort.Size = new System.Drawing.Size(151, 23);
            this.numProxyPort.TabIndex = 7;
            this.numProxyPort.Value = new decimal(new int[] {
            9050,
            0,
            0,
            0});
            // 
            // txtInitialURL
            // 
            this.txtInitialURL.Location = new System.Drawing.Point(12, 34);
            this.txtInitialURL.Name = "txtInitialURL";
            this.txtInitialURL.PlaceholderText = "Initial Website URL";
            this.txtInitialURL.Size = new System.Drawing.Size(271, 23);
            this.txtInitialURL.TabIndex = 1;
            // 
            // txtProxyHost
            // 
            this.txtProxyHost.Location = new System.Drawing.Point(12, 63);
            this.txtProxyHost.Name = "txtProxyHost";
            this.txtProxyHost.PlaceholderText = "Proxy Host (127.0.0.1 default)";
            this.txtProxyHost.Size = new System.Drawing.Size(271, 23);
            this.txtProxyHost.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 181);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 15);
            this.label3.TabIndex = 1;
            this.label3.Text = "Max Queue Count:";
            // 
            // numMaxQueue
            // 
            this.numMaxQueue.Location = new System.Drawing.Point(132, 179);
            this.numMaxQueue.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.numMaxQueue.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numMaxQueue.Name = "numMaxQueue";
            this.numMaxQueue.Size = new System.Drawing.Size(151, 23);
            this.numMaxQueue.TabIndex = 6;
            this.numMaxQueue.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // numMaxSubpage
            // 
            this.numMaxSubpage.Location = new System.Drawing.Point(132, 150);
            this.numMaxSubpage.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numMaxSubpage.Name = "numMaxSubpage";
            this.numMaxSubpage.Size = new System.Drawing.Size(151, 23);
            this.numMaxSubpage.TabIndex = 5;
            this.numMaxSubpage.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Max Subpage Count:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Max Website Conut:";
            // 
            // numMaxWebsite
            // 
            this.numMaxWebsite.Location = new System.Drawing.Point(132, 121);
            this.numMaxWebsite.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numMaxWebsite.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numMaxWebsite.Name = "numMaxWebsite";
            this.numMaxWebsite.Size = new System.Drawing.Size(151, 23);
            this.numMaxWebsite.TabIndex = 2;
            this.numMaxWebsite.Value = new decimal(new int[] {
            150,
            0,
            0,
            0});
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox4);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox2.Location = new System.Drawing.Point(298, 0);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(10);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(15);
            this.groupBox2.Size = new System.Drawing.Size(744, 451);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Crawling Status";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.listCrawled);
            this.groupBox4.Controls.Add(this.lblCrawled);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox4.Location = new System.Drawing.Point(436, 31);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(10);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(5);
            this.groupBox4.Size = new System.Drawing.Size(293, 405);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Crawled";
            // 
            // listCrawled
            // 
            this.listCrawled.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listCrawled.FormattingEnabled = true;
            this.listCrawled.ItemHeight = 15;
            this.listCrawled.Location = new System.Drawing.Point(5, 21);
            this.listCrawled.Name = "listCrawled";
            this.listCrawled.Size = new System.Drawing.Size(283, 364);
            this.listCrawled.TabIndex = 1;
            this.listCrawled.DoubleClick += new System.EventHandler(this.listCrawled_DoubleClick);
            // 
            // lblCrawled
            // 
            this.lblCrawled.AutoSize = true;
            this.lblCrawled.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblCrawled.Location = new System.Drawing.Point(5, 385);
            this.lblCrawled.Name = "lblCrawled";
            this.lblCrawled.Size = new System.Drawing.Size(97, 15);
            this.lblCrawled.TabIndex = 0;
            this.lblCrawled.Text = "Crawled Count: 0";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.listQueued);
            this.groupBox3.Controls.Add(this.lblQueued);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox3.Location = new System.Drawing.Point(15, 31);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(10);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(5);
            this.groupBox3.Size = new System.Drawing.Size(421, 405);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Queued";
            // 
            // listQueued
            // 
            this.listQueued.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listQueued.FormattingEnabled = true;
            this.listQueued.ItemHeight = 15;
            this.listQueued.Location = new System.Drawing.Point(5, 21);
            this.listQueued.Name = "listQueued";
            this.listQueued.Size = new System.Drawing.Size(411, 364);
            this.listQueued.TabIndex = 0;
            this.listQueued.DoubleClick += new System.EventHandler(this.listQueued_DoubleClick);
            // 
            // lblQueued
            // 
            this.lblQueued.AutoSize = true;
            this.lblQueued.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblQueued.Location = new System.Drawing.Point(5, 385);
            this.lblQueued.Name = "lblQueued";
            this.lblQueued.Size = new System.Drawing.Size(97, 15);
            this.lblQueued.TabIndex = 0;
            this.lblQueued.Text = "Queued Count: 0";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.rtbOutput);
            this.groupBox5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox5.Location = new System.Drawing.Point(0, 451);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(1042, 140);
            this.groupBox5.TabIndex = 2;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Output";
            // 
            // rtbOutput
            // 
            this.rtbOutput.BackColor = System.Drawing.Color.White;
            this.rtbOutput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbOutput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbOutput.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rtbOutput.Location = new System.Drawing.Point(3, 19);
            this.rtbOutput.Name = "rtbOutput";
            this.rtbOutput.ReadOnly = true;
            this.rtbOutput.Size = new System.Drawing.Size(1036, 118);
            this.rtbOutput.TabIndex = 0;
            this.rtbOutput.Text = "";
            this.rtbOutput.TextChanged += new System.EventHandler(this.rtbOutput_TextChanged_1);
            // 
            // CrawlerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1042, 591);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox5);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.MinimumSize = new System.Drawing.Size(16, 630);
            this.Name = "CrawlerForm";
            this.Text = "Onion Crawler";
            this.Load += new System.EventHandler(this.CrawlerForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numTimeout)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxSave)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numProxyPort)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMaxQueue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMaxSubpage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMaxWebsite)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numProxyPort;
        private System.Windows.Forms.TextBox txtInitialURL;
        private System.Windows.Forms.TextBox txtProxyHost;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numMaxQueue;
        private System.Windows.Forms.NumericUpDown numMaxSubpage;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numMaxWebsite;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblStat;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ListBox listCrawled;
        private System.Windows.Forms.Label lblCrawled;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ListBox listQueued;
        private System.Windows.Forms.Label lblQueued;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.RichTextBox rtbOutput;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown numTimeout;
        private System.Windows.Forms.CheckBox checkSurface;
        private System.Windows.Forms.CheckBox checkIp;
        private System.Windows.Forms.Button btnContinue;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.PictureBox pbxSave;
    }
}

