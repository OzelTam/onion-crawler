namespace OnionCrawler.Win
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pbpLabel = new System.Windows.Forms.Label();
            this.blabel1 = new System.Windows.Forms.Label();
            this.blabel2 = new System.Windows.Forms.Label();
            this.blabel3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // progressBar1
            // 
            this.progressBar1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.progressBar1.Location = new System.Drawing.Point(0, 192);
            this.progressBar1.Maximum = 120;
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(476, 25);
            this.progressBar1.Step = 1;
            this.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar1.TabIndex = 0;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(238, 192);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // pbpLabel
            // 
            this.pbpLabel.AutoSize = true;
            this.pbpLabel.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.pbpLabel.Location = new System.Drawing.Point(277, 48);
            this.pbpLabel.Name = "pbpLabel";
            this.pbpLabel.Size = new System.Drawing.Size(153, 26);
            this.pbpLabel.TabIndex = 2;
            this.pbpLabel.Text = "Please be Patient";
            // 
            // blabel1
            // 
            this.blabel1.AutoSize = true;
            this.blabel1.Font = new System.Drawing.Font("Sitka Text", 10.18868F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.blabel1.Location = new System.Drawing.Point(267, 89);
            this.blabel1.Name = "blabel1";
            this.blabel1.Size = new System.Drawing.Size(172, 21);
            this.blabel1.TabIndex = 3;
            this.blabel1.Text = "Aquiring TOR Libraries";
            this.blabel1.Visible = false;
            // 
            // blabel2
            // 
            this.blabel2.AutoSize = true;
            this.blabel2.Font = new System.Drawing.Font("Sitka Text", 10.18868F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.blabel2.Location = new System.Drawing.Point(258, 123);
            this.blabel2.Name = "blabel2";
            this.blabel2.Size = new System.Drawing.Size(197, 21);
            this.blabel2.TabIndex = 4;
            this.blabel2.Text = "Configuring Onion Routing";
            this.blabel2.Visible = false;
            // 
            // blabel3
            // 
            this.blabel3.AutoSize = true;
            this.blabel3.Font = new System.Drawing.Font("Sitka Text", 10.18868F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.blabel3.Location = new System.Drawing.Point(268, 159);
            this.blabel3.Name = "blabel3";
            this.blabel3.Size = new System.Drawing.Size(173, 21);
            this.blabel3.TabIndex = 5;
            this.blabel3.Text = "Bootstrapping Network";
            this.blabel3.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sitka Display", 16.30189F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Firebrick;
            this.label1.Location = new System.Drawing.Point(267, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 36);
            this.label1.TabIndex = 6;
            this.label1.Text = "RADICAL ECHO";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(476, 217);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.blabel3);
            this.Controls.Add(this.blabel2);
            this.Controls.Add(this.blabel1);
            this.Controls.Add(this.pbpLabel);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.progressBar1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Splash_Screen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label pbpLabel;
        private System.Windows.Forms.Label blabel1;
        private System.Windows.Forms.Label blabel2;
        private System.Windows.Forms.Label blabel3;
        private System.Windows.Forms.Label label1;
    }
}