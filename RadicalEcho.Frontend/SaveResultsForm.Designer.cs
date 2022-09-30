
namespace OnionCrawler.Win
{
    partial class SaveResultsForm
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
            this.txtBrowsedPath = new System.Windows.Forms.TextBox();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.checkCrawled = new System.Windows.Forms.CheckBox();
            this.checkQueued = new System.Windows.Forms.CheckBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtBrowsedPath
            // 
            this.txtBrowsedPath.Location = new System.Drawing.Point(12, 12);
            this.txtBrowsedPath.Name = "txtBrowsedPath";
            this.txtBrowsedPath.PlaceholderText = "Save File Path";
            this.txtBrowsedPath.Size = new System.Drawing.Size(399, 25);
            this.txtBrowsedPath.TabIndex = 0;
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(417, 14);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(37, 23);
            this.btnBrowse.TabIndex = 1;
            this.btnBrowse.Text = "...";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // checkCrawled
            // 
            this.checkCrawled.AutoSize = true;
            this.checkCrawled.Checked = true;
            this.checkCrawled.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkCrawled.Location = new System.Drawing.Point(25, 52);
            this.checkCrawled.Name = "checkCrawled";
            this.checkCrawled.Size = new System.Drawing.Size(134, 21);
            this.checkCrawled.TabIndex = 2;
            this.checkCrawled.Text = "Crawled Websites";
            this.checkCrawled.UseVisualStyleBackColor = true;
            // 
            // checkQueued
            // 
            this.checkQueued.AutoSize = true;
            this.checkQueued.Checked = true;
            this.checkQueued.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkQueued.Location = new System.Drawing.Point(25, 79);
            this.checkQueued.Name = "checkQueued";
            this.checkQueued.Size = new System.Drawing.Size(134, 21);
            this.checkQueued.TabIndex = 3;
            this.checkQueued.Text = "Queued Websites";
            this.checkQueued.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(361, 98);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(93, 37);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // SaveResultsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 147);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.checkQueued);
            this.Controls.Add(this.checkCrawled);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.txtBrowsedPath);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Name = "SaveResultsForm";
            this.Text = "SaveResultsForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBrowsedPath;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.CheckBox checkCrawled;
        private System.Windows.Forms.CheckBox checkQueued;
        private System.Windows.Forms.Button btnSave;
    }
}