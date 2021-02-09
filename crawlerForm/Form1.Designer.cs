
namespace crawlerForm
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rtbOutput = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtRootWP = new System.Windows.Forms.TextBox();
            this.toolBar = new System.Windows.Forms.ToolStrip();
            this.btnInstallTorFiles = new System.Windows.Forms.ToolStripButton();
            this.btnUninstall = new System.Windows.Forms.ToolStripButton();
            this.btnCheckForUpdates = new System.Windows.Forms.ToolStripButton();
            this.btnInitWebStrucure = new System.Windows.Forms.Button();
            this.groupWebStructure = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.checkSepThreads = new System.Windows.Forms.CheckBox();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblTotalCount = new System.Windows.Forms.Label();
            this.lblHostCount = new System.Windows.Forms.Label();
            this.lblQueuedLinks = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.listQueuedUrls = new System.Windows.Forms.ListBox();
            this.listHosts = new System.Windows.Forms.ListBox();
            this.label8 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnCrawl = new System.Windows.Forms.Button();
            this.cbArch = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.numMaxHosts = new System.Windows.Forms.NumericUpDown();
            this.numMaxSubPages = new System.Windows.Forms.NumericUpDown();
            this.groupInit = new System.Windows.Forms.GroupBox();
            this.numMaxQueue = new System.Windows.Forms.NumericUpDown();
            this.label14 = new System.Windows.Forms.Label();
            this.checkIpHosts = new System.Windows.Forms.CheckBox();
            this.checkClearNet = new System.Windows.Forms.CheckBox();
            this.time = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            this.toolBar.SuspendLayout();
            this.groupWebStructure.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numMaxHosts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMaxSubPages)).BeginInit();
            this.groupInit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numMaxQueue)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.rtbOutput);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.groupBox1.Location = new System.Drawing.Point(0, 361);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(924, 153);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Output";
            // 
            // rtbOutput
            // 
            this.rtbOutput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.rtbOutput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbOutput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbOutput.Font = new System.Drawing.Font("Sitka Display", 15.7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rtbOutput.Location = new System.Drawing.Point(3, 21);
            this.rtbOutput.Name = "rtbOutput";
            this.rtbOutput.ReadOnly = true;
            this.rtbOutput.Size = new System.Drawing.Size(918, 129);
            this.rtbOutput.TabIndex = 0;
            this.rtbOutput.Text = "";
            this.rtbOutput.TextChanged += new System.EventHandler(this.rtbOutput_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(88, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Seed Url:";
            // 
            // txtRootWP
            // 
            this.txtRootWP.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtRootWP.Location = new System.Drawing.Point(157, 33);
            this.txtRootWP.Name = "txtRootWP";
            this.txtRootWP.Size = new System.Drawing.Size(747, 25);
            this.txtRootWP.TabIndex = 2;
            this.txtRootWP.TextChanged += new System.EventHandler(this.txtRootWP_TextChanged);
            // 
            // toolBar
            // 
            this.toolBar.Enabled = false;
            this.toolBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnInstallTorFiles,
            this.btnUninstall,
            this.btnCheckForUpdates});
            this.toolBar.Location = new System.Drawing.Point(0, 0);
            this.toolBar.Name = "toolBar";
            this.toolBar.Size = new System.Drawing.Size(924, 25);
            this.toolBar.TabIndex = 3;
            this.toolBar.Text = "Tool Bar";
            this.toolBar.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolBar_ItemClicked);
            // 
            // btnInstallTorFiles
            // 
            this.btnInstallTorFiles.Image = ((System.Drawing.Image)(resources.GetObject("btnInstallTorFiles.Image")));
            this.btnInstallTorFiles.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnInstallTorFiles.Name = "btnInstallTorFiles";
            this.btnInstallTorFiles.Size = new System.Drawing.Size(103, 22);
            this.btnInstallTorFiles.Text = "Install Tor Files";
            // 
            // btnUninstall
            // 
            this.btnUninstall.Image = ((System.Drawing.Image)(resources.GetObject("btnUninstall.Image")));
            this.btnUninstall.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnUninstall.Name = "btnUninstall";
            this.btnUninstall.Size = new System.Drawing.Size(118, 22);
            this.btnUninstall.Text = "Uninstall Tor Files";
            // 
            // btnCheckForUpdates
            // 
            this.btnCheckForUpdates.Image = ((System.Drawing.Image)(resources.GetObject("btnCheckForUpdates.Image")));
            this.btnCheckForUpdates.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCheckForUpdates.Name = "btnCheckForUpdates";
            this.btnCheckForUpdates.Size = new System.Drawing.Size(126, 22);
            this.btnCheckForUpdates.Text = "Check For Updates";
            // 
            // btnInitWebStrucure
            // 
            this.btnInitWebStrucure.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnInitWebStrucure.Enabled = false;
            this.btnInitWebStrucure.Location = new System.Drawing.Point(803, 146);
            this.btnInitWebStrucure.Name = "btnInitWebStrucure";
            this.btnInitWebStrucure.Size = new System.Drawing.Size(101, 42);
            this.btnInitWebStrucure.TabIndex = 4;
            this.btnInitWebStrucure.Text = "Intialize";
            this.btnInitWebStrucure.UseVisualStyleBackColor = true;
            this.btnInitWebStrucure.Click += new System.EventHandler(this.btnInitWebStrucure_Click);
            // 
            // groupWebStructure
            // 
            this.groupWebStructure.Controls.Add(this.panel1);
            this.groupWebStructure.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupWebStructure.Enabled = false;
            this.groupWebStructure.Location = new System.Drawing.Point(0, 25);
            this.groupWebStructure.Name = "groupWebStructure";
            this.groupWebStructure.Size = new System.Drawing.Size(924, 336);
            this.groupWebStructure.TabIndex = 5;
            this.groupWebStructure.TabStop = false;
            this.groupWebStructure.Text = "Web Structure";
            this.groupWebStructure.Visible = false;
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.checkSepThreads);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.groupBox3);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.listQueuedUrls);
            this.panel1.Controls.Add(this.listHosts);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.btnCrawl);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 21);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(918, 312);
            this.panel1.TabIndex = 13;
            // 
            // checkSepThreads
            // 
            this.checkSepThreads.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkSepThreads.AutoSize = true;
            this.checkSepThreads.Checked = true;
            this.checkSepThreads.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkSepThreads.Location = new System.Drawing.Point(800, 136);
            this.checkSepThreads.Name = "checkSepThreads";
            this.checkSepThreads.Size = new System.Drawing.Size(103, 21);
            this.checkSepThreads.TabIndex = 16;
            this.checkSepThreads.Text = "Split Threads";
            this.checkSepThreads.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.Location = new System.Drawing.Point(796, 96);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(114, 28);
            this.button3.TabIndex = 15;
            this.button3.Text = "reset all";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.button2);
            this.groupBox3.Controls.Add(this.lblTime);
            this.groupBox3.Controls.Add(this.lblTotalCount);
            this.groupBox3.Controls.Add(this.lblHostCount);
            this.groupBox3.Controls.Add(this.lblQueuedLinks);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Location = new System.Drawing.Point(533, 49);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(257, 250);
            this.groupBox3.TabIndex = 13;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Status";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(168, 216);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(83, 28);
            this.button2.TabIndex = 14;
            this.button2.Text = "Pause";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.lblTime.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.lblTime.Location = new System.Drawing.Point(147, 95);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(39, 17);
            this.lblTime.TabIndex = 7;
            this.lblTime.Text = "00:00";
            // 
            // lblTotalCount
            // 
            this.lblTotalCount.AutoSize = true;
            this.lblTotalCount.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.lblTotalCount.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.lblTotalCount.Location = new System.Drawing.Point(147, 124);
            this.lblTotalCount.Name = "lblTotalCount";
            this.lblTotalCount.Size = new System.Drawing.Size(15, 17);
            this.lblTotalCount.TabIndex = 6;
            this.lblTotalCount.Text = "0";
            this.lblTotalCount.Visible = false;
            // 
            // lblHostCount
            // 
            this.lblHostCount.AutoSize = true;
            this.lblHostCount.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.lblHostCount.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.lblHostCount.Location = new System.Drawing.Point(147, 65);
            this.lblHostCount.Name = "lblHostCount";
            this.lblHostCount.Size = new System.Drawing.Size(15, 17);
            this.lblHostCount.TabIndex = 5;
            this.lblHostCount.Text = "0";
            // 
            // lblQueuedLinks
            // 
            this.lblQueuedLinks.AutoSize = true;
            this.lblQueuedLinks.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.lblQueuedLinks.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.lblQueuedLinks.Location = new System.Drawing.Point(147, 33);
            this.lblQueuedLinks.Name = "lblQueuedLinks";
            this.lblQueuedLinks.Size = new System.Drawing.Size(15, 17);
            this.lblQueuedLinks.TabIndex = 4;
            this.lblQueuedLinks.Text = "0";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(44, 95);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(92, 17);
            this.label13.TabIndex = 3;
            this.label13.Text = "Ellapsed Time:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(16, 124);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(123, 17);
            this.label12.TabIndex = 2;
            this.label12.Text = "Crawled Page Total:";
            this.label12.Visible = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(9, 65);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(127, 17);
            this.label11.TabIndex = 1;
            this.label11.Text = "Crawled Host Count:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(16, 33);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(125, 17);
            this.label10.TabIndex = 0;
            this.label10.Text = "Queued Link Count: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 173);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "HOSTS";
            // 
            // listQueuedUrls
            // 
            this.listQueuedUrls.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listQueuedUrls.FormattingEnabled = true;
            this.listQueuedUrls.ItemHeight = 17;
            this.listQueuedUrls.Location = new System.Drawing.Point(13, 49);
            this.listQueuedUrls.Name = "listQueuedUrls";
            this.listQueuedUrls.Size = new System.Drawing.Size(514, 106);
            this.listQueuedUrls.TabIndex = 11;
            // 
            // listHosts
            // 
            this.listHosts.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listHosts.FormattingEnabled = true;
            this.listHosts.ItemHeight = 17;
            this.listHosts.Location = new System.Drawing.Point(13, 193);
            this.listHosts.Name = "listHosts";
            this.listHosts.Size = new System.Drawing.Size(514, 106);
            this.listHosts.TabIndex = 0;
            this.listHosts.SelectedIndexChanged += new System.EventHandler(this.listHosts_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(13, 29);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(96, 17);
            this.label8.TabIndex = 12;
            this.label8.Text = "QUEUED URL\'S";
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(293, 37);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(114, 38);
            this.button1.TabIndex = 11;
            this.button1.Text = "TEST SEED";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnCrawl
            // 
            this.btnCrawl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCrawl.Enabled = false;
            this.btnCrawl.Location = new System.Drawing.Point(796, 49);
            this.btnCrawl.Name = "btnCrawl";
            this.btnCrawl.Size = new System.Drawing.Size(114, 38);
            this.btnCrawl.TabIndex = 10;
            this.btnCrawl.Text = "CRAWL !";
            this.btnCrawl.UseVisualStyleBackColor = true;
            this.btnCrawl.Click += new System.EventHandler(this.btnCrawl_Click);
            // 
            // cbArch
            // 
            this.cbArch.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cbArch.FormattingEnabled = true;
            this.cbArch.Items.AddRange(new object[] {
            "auto",
            "x86",
            "x64"});
            this.cbArch.Location = new System.Drawing.Point(157, 64);
            this.cbArch.Name = "cbArch";
            this.cbArch.Size = new System.Drawing.Size(88, 25);
            this.cbArch.TabIndex = 6;
            this.cbArch.Text = "auto";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(60, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Architechture :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Max Host Count:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Max SubPages Count:";
            // 
            // numMaxHosts
            // 
            this.numMaxHosts.Location = new System.Drawing.Point(157, 95);
            this.numMaxHosts.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numMaxHosts.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numMaxHosts.Name = "numMaxHosts";
            this.numMaxHosts.Size = new System.Drawing.Size(88, 25);
            this.numMaxHosts.TabIndex = 10;
            this.numMaxHosts.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // numMaxSubPages
            // 
            this.numMaxSubPages.Location = new System.Drawing.Point(157, 126);
            this.numMaxSubPages.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numMaxSubPages.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numMaxSubPages.Name = "numMaxSubPages";
            this.numMaxSubPages.Size = new System.Drawing.Size(88, 25);
            this.numMaxSubPages.TabIndex = 11;
            this.numMaxSubPages.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // groupInit
            // 
            this.groupInit.Controls.Add(this.numMaxQueue);
            this.groupInit.Controls.Add(this.label14);
            this.groupInit.Controls.Add(this.checkIpHosts);
            this.groupInit.Controls.Add(this.checkClearNet);
            this.groupInit.Controls.Add(this.label1);
            this.groupInit.Controls.Add(this.numMaxSubPages);
            this.groupInit.Controls.Add(this.btnInitWebStrucure);
            this.groupInit.Controls.Add(this.txtRootWP);
            this.groupInit.Controls.Add(this.label4);
            this.groupInit.Controls.Add(this.numMaxHosts);
            this.groupInit.Controls.Add(this.label3);
            this.groupInit.Controls.Add(this.label2);
            this.groupInit.Controls.Add(this.cbArch);
            this.groupInit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupInit.Location = new System.Drawing.Point(0, 25);
            this.groupInit.Name = "groupInit";
            this.groupInit.Size = new System.Drawing.Size(924, 336);
            this.groupInit.TabIndex = 12;
            this.groupInit.TabStop = false;
            this.groupInit.Text = "Initialization";
            this.groupInit.VisibleChanged += new System.EventHandler(this.groupInit_VisibleChanged);
            // 
            // numMaxQueue
            // 
            this.numMaxQueue.Location = new System.Drawing.Point(157, 157);
            this.numMaxQueue.Maximum = new decimal(new int[] {
            50000,
            0,
            0,
            0});
            this.numMaxQueue.Minimum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numMaxQueue.Name = "numMaxQueue";
            this.numMaxQueue.Size = new System.Drawing.Size(88, 25);
            this.numMaxQueue.TabIndex = 15;
            this.numMaxQueue.Value = new decimal(new int[] {
            250,
            0,
            0,
            0});
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(12, 159);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(137, 17);
            this.label14.TabIndex = 14;
            this.label14.Text = "Max Url Queue Count:";
            // 
            // checkIpHosts
            // 
            this.checkIpHosts.AutoSize = true;
            this.checkIpHosts.Enabled = false;
            this.checkIpHosts.Location = new System.Drawing.Point(327, 98);
            this.checkIpHosts.Name = "checkIpHosts";
            this.checkIpHosts.Size = new System.Drawing.Size(203, 38);
            this.checkIpHosts.TabIndex = 13;
            this.checkIpHosts.Text = "Include Hosts Without Domain\r\n(Not Ready Yet)";
            this.checkIpHosts.UseVisualStyleBackColor = true;
            // 
            // checkClearNet
            // 
            this.checkClearNet.AutoSize = true;
            this.checkClearNet.Checked = true;
            this.checkClearNet.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkClearNet.Location = new System.Drawing.Point(327, 68);
            this.checkClearNet.Name = "checkClearNet";
            this.checkClearNet.Size = new System.Drawing.Size(158, 21);
            this.checkClearNet.TabIndex = 12;
            this.checkClearNet.Text = "Include ClearNet Url(s)";
            this.checkClearNet.UseVisualStyleBackColor = true;
            // 
            // time
            // 
            this.time.Tick += new System.EventHandler(this.time_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(924, 514);
            this.Controls.Add(this.groupWebStructure);
            this.Controls.Add(this.groupInit);
            this.Controls.Add(this.toolBar);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.toolBar.ResumeLayout(false);
            this.toolBar.PerformLayout();
            this.groupWebStructure.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numMaxHosts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMaxSubPages)).EndInit();
            this.groupInit.ResumeLayout(false);
            this.groupInit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numMaxQueue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RichTextBox rtbOutput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtRootWP;
        private System.Windows.Forms.ToolStrip toolBar;
        private System.Windows.Forms.ToolStripButton btnInstallTorFiles;
        private System.Windows.Forms.ToolStripButton btnUninstall;
        private System.Windows.Forms.ToolStripButton btnCheckForUpdates;
        private System.Windows.Forms.Button btnInitWebStrucure;
        private System.Windows.Forms.GroupBox groupWebStructure;
        private System.Windows.Forms.ComboBox cbArch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numMaxHosts;
        private System.Windows.Forms.NumericUpDown numMaxSubPages;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox listHosts;
        private System.Windows.Forms.Button btnCrawl;
        private System.Windows.Forms.GroupBox groupInit;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblTotalCount;
        private System.Windows.Forms.Label lblHostCount;
        private System.Windows.Forms.Label lblQueuedLinks;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ListBox listQueuedUrls;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox checkIpHosts;
        private System.Windows.Forms.CheckBox checkClearNet;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.NumericUpDown numMaxQueue;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.CheckBox checkSepThreads;
        private System.Windows.Forms.Timer time;
    }
}

