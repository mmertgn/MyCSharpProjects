namespace wf_Pakbank_OOP
{
    partial class frmAnaSayfa
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
            this.işlemerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yeniHesapOluşturmaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hesapDökümüToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mitmCikis = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // işlemerToolStripMenuItem
            // 
            this.işlemerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.yeniHesapOluşturmaToolStripMenuItem,
            this.hesapDökümüToolStripMenuItem,
            this.mitmCikis});
            this.işlemerToolStripMenuItem.Name = "işlemerToolStripMenuItem";
            this.işlemerToolStripMenuItem.Size = new System.Drawing.Size(99, 20);
            this.işlemerToolStripMenuItem.Text = "Hesap İşlemleri";
            // 
            // yeniHesapOluşturmaToolStripMenuItem
            // 
            this.yeniHesapOluşturmaToolStripMenuItem.MergeAction = System.Windows.Forms.MergeAction.MatchOnly;
            this.yeniHesapOluşturmaToolStripMenuItem.Name = "yeniHesapOluşturmaToolStripMenuItem";
            this.yeniHesapOluşturmaToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.yeniHesapOluşturmaToolStripMenuItem.Text = "Yeni Hesap Aç";
            this.yeniHesapOluşturmaToolStripMenuItem.Click += new System.EventHandler(this.mitmyeniHesapOlusturma_Click);
            // 
            // hesapDökümüToolStripMenuItem
            // 
            this.hesapDökümüToolStripMenuItem.Name = "hesapDökümüToolStripMenuItem";
            this.hesapDökümüToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.hesapDökümüToolStripMenuItem.Text = "Hesap Dökümü İncele";
            this.hesapDökümüToolStripMenuItem.Click += new System.EventHandler(this.mitmHesapDokumu_Click);
            // 
            // mitmCikis
            // 
            this.mitmCikis.Name = "mitmCikis";
            this.mitmCikis.Size = new System.Drawing.Size(190, 22);
            this.mitmCikis.Text = "Çıkış";
            this.mitmCikis.Click += new System.EventHandler(this.mitmCikis_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.işlemerToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(809, 24);
            this.menuStrip1.TabIndex = 27;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // frmAnaSayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Green;
            this.ClientSize = new System.Drawing.Size(809, 436);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.Name = "frmAnaSayfa";
            this.ShowIcon = false;
            this.Text = "Pakbank Anasayfa İşlemleri";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStripMenuItem işlemerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yeniHesapOluşturmaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hesapDökümüToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mitmCikis;
        private System.Windows.Forms.MenuStrip menuStrip1;
    }
}