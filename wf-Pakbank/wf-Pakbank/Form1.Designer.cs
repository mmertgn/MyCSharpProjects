namespace wf_Pakbank
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.işlemerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yeniHesapOluşturmaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hesapDökümüToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mitmCikis = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnHesapAc = new System.Windows.Forms.Button();
            this.btnHesapDokumu = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.işlemerToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(940, 24);
            this.menuStrip1.TabIndex = 22;
            this.menuStrip1.Text = "menuStrip1";
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 32.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(176, 160);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(598, 51);
            this.label1.TabIndex = 23;
            this.label1.Text = "PAKBANK YÖNETİM PANELİNE";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 32.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(336, 211);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(286, 51);
            this.label2.TabIndex = 24;
            this.label2.Text = "HOŞGELDİNİZ";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnHesapAc
            // 
            this.btnHesapAc.BackColor = System.Drawing.Color.Honeydew;
            this.btnHesapAc.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHesapAc.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnHesapAc.Location = new System.Drawing.Point(726, 381);
            this.btnHesapAc.Name = "btnHesapAc";
            this.btnHesapAc.Size = new System.Drawing.Size(215, 74);
            this.btnHesapAc.TabIndex = 25;
            this.btnHesapAc.Text = "Hesap Aç";
            this.btnHesapAc.UseVisualStyleBackColor = false;
            this.btnHesapAc.Click += new System.EventHandler(this.btnHesapAc_Click);
            // 
            // btnHesapDokumu
            // 
            this.btnHesapDokumu.BackColor = System.Drawing.Color.Honeydew;
            this.btnHesapDokumu.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnHesapDokumu.Location = new System.Drawing.Point(-1, 381);
            this.btnHesapDokumu.Name = "btnHesapDokumu";
            this.btnHesapDokumu.Size = new System.Drawing.Size(215, 74);
            this.btnHesapDokumu.TabIndex = 26;
            this.btnHesapDokumu.Text = "Hesap Dökümü";
            this.btnHesapDokumu.UseVisualStyleBackColor = false;
            this.btnHesapDokumu.Click += new System.EventHandler(this.btnHesapDokumu_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Green;
            this.ClientSize = new System.Drawing.Size(940, 454);
            this.Controls.Add(this.btnHesapDokumu);
            this.Controls.Add(this.btnHesapAc);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Pankbank";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem işlemerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yeniHesapOluşturmaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hesapDökümüToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mitmCikis;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnHesapAc;
        private System.Windows.Forms.Button btnHesapDokumu;
    }
}

