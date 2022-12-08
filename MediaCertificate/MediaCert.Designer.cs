namespace MediaCertificateUtility
{
    partial class MediaCert
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MediaCert));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.certificateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.generateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadCertificateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.certificateLoader1 = new MediaCertificateUtility.CertificateLoader();
            this.certificateGenerator1 = new MediaCertificateUtility.CertificateGenerator();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.certificateToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1071, 31);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // certificateToolStripMenuItem
            // 
            this.certificateToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.generateToolStripMenuItem,
            this.loadCertificateToolStripMenuItem});
            this.certificateToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.certificateToolStripMenuItem.Name = "certificateToolStripMenuItem";
            this.certificateToolStripMenuItem.Size = new System.Drawing.Size(101, 27);
            this.certificateToolStripMenuItem.Text = "Certificate";
            // 
            // generateToolStripMenuItem
            // 
            this.generateToolStripMenuItem.Name = "generateToolStripMenuItem";
            this.generateToolStripMenuItem.Size = new System.Drawing.Size(213, 28);
            this.generateToolStripMenuItem.Text = "Generate";
            this.generateToolStripMenuItem.Click += new System.EventHandler(this.generateToolStripMenuItem_Click);
            // 
            // loadCertificateToolStripMenuItem
            // 
            this.loadCertificateToolStripMenuItem.Name = "loadCertificateToolStripMenuItem";
            this.loadCertificateToolStripMenuItem.Size = new System.Drawing.Size(213, 28);
            this.loadCertificateToolStripMenuItem.Text = "Load Certificate";
            this.loadCertificateToolStripMenuItem.Click += new System.EventHandler(this.loadCertificateToolStripMenuItem_Click);
            // 
            // certificateLoader1
            // 
            this.certificateLoader1.Location = new System.Drawing.Point(12, 34);
            this.certificateLoader1.Name = "certificateLoader1";
            this.certificateLoader1.Size = new System.Drawing.Size(917, 379);
            this.certificateLoader1.TabIndex = 4;
            this.certificateLoader1.Visible = false;
            this.certificateLoader1.Load += new System.EventHandler(this.certificateLoader1_Load);
            // 
            // certificateGenerator1
            // 
            this.certificateGenerator1.Location = new System.Drawing.Point(12, 34);
            this.certificateGenerator1.Name = "certificateGenerator1";
            this.certificateGenerator1.Size = new System.Drawing.Size(1023, 370);
            this.certificateGenerator1.TabIndex = 5;
            // 
            // MediaCert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1071, 433);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.certificateLoader1);
            this.Controls.Add(this.certificateGenerator1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MediaCert";
            this.Text = "Media Certificate Utility";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem certificateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem generateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadCertificateToolStripMenuItem;
        private CertificateLoader certificateLoader1;
        private CertificateGenerator certificateGenerator1;
    }
}

