namespace massdl
{
    partial class MainForm
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
            this.chkListen = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDownloadFolder = new System.Windows.Forms.TextBox();
            this.lstLog = new System.Windows.Forms.ListBox();
            this.btnDownloadFolder = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // chkListen
            // 
            this.chkListen.AutoSize = true;
            this.chkListen.Location = new System.Drawing.Point(12, 57);
            this.chkListen.Name = "chkListen";
            this.chkListen.Size = new System.Drawing.Size(68, 21);
            this.chkListen.TabIndex = 0;
            this.chkListen.Text = "Listen";
            this.chkListen.UseVisualStyleBackColor = true;
            this.chkListen.CheckedChanged += new System.EventHandler(this.chkListen_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Download Folder:";
            // 
            // txtDownloadFolder
            // 
            this.txtDownloadFolder.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDownloadFolder.Location = new System.Drawing.Point(12, 29);
            this.txtDownloadFolder.Name = "txtDownloadFolder";
            this.txtDownloadFolder.Size = new System.Drawing.Size(916, 22);
            this.txtDownloadFolder.TabIndex = 2;
            // 
            // lstLog
            // 
            this.lstLog.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstLog.FormattingEnabled = true;
            this.lstLog.IntegralHeight = false;
            this.lstLog.ItemHeight = 16;
            this.lstLog.Location = new System.Drawing.Point(12, 84);
            this.lstLog.Name = "lstLog";
            this.lstLog.Size = new System.Drawing.Size(954, 390);
            this.lstLog.TabIndex = 3;
            // 
            // btnDownloadFolder
            // 
            this.btnDownloadFolder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDownloadFolder.Location = new System.Drawing.Point(934, 29);
            this.btnDownloadFolder.Name = "btnDownloadFolder";
            this.btnDownloadFolder.Size = new System.Drawing.Size(32, 22);
            this.btnDownloadFolder.TabIndex = 4;
            this.btnDownloadFolder.Text = "...";
            this.btnDownloadFolder.UseVisualStyleBackColor = true;
            this.btnDownloadFolder.Click += new System.EventHandler(this.btnDownloadFolder_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(978, 486);
            this.Controls.Add(this.btnDownloadFolder);
            this.Controls.Add(this.lstLog);
            this.Controls.Add(this.txtDownloadFolder);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chkListen);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mass Downloader";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chkListen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDownloadFolder;
        private System.Windows.Forms.ListBox lstLog;
        private System.Windows.Forms.Button btnDownloadFolder;
    }
}

