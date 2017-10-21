namespace wf_Pakbank
{
    partial class frmHesapDokumu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHesapDokumu));
            this.lvHesapHareketleri = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.txtHesapAra = new System.Windows.Forms.TextBox();
            this.btnHesapAra = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtAcilisTarihi = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtHesapTuru = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTCKN = new System.Windows.Forms.TextBox();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnYazdir = new System.Windows.Forms.Button();
            this.btnParaIslemleri = new System.Windows.Forms.Button();
            this.txtBakiye = new System.Windows.Forms.TextBox();
            this.txtToplamCekilen = new System.Windows.Forms.TextBox();
            this.txtToplamYatan = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.pdocHareketler = new System.Drawing.Printing.PrintDocument();
            this.ppdHareketler = new System.Windows.Forms.PrintPreviewDialog();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // lvHesapHareketleri
            // 
            this.lvHesapHareketleri.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.lvHesapHareketleri.FullRowSelect = true;
            this.lvHesapHareketleri.Location = new System.Drawing.Point(22, 19);
            this.lvHesapHareketleri.Name = "lvHesapHareketleri";
            this.lvHesapHareketleri.Size = new System.Drawing.Size(539, 197);
            this.lvHesapHareketleri.TabIndex = 0;
            this.lvHesapHareketleri.UseCompatibleStateImageBehavior = false;
            this.lvHesapHareketleri.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID";
            this.columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Hesap No";
            this.columnHeader2.Width = 100;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "İşlem Tarihi";
            this.columnHeader3.Width = 100;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "İşlem Tutarı";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeader4.Width = 100;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "İşlem Türü";
            this.columnHeader5.Width = 100;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Hesap No";
            // 
            // txtHesapAra
            // 
            this.txtHesapAra.Location = new System.Drawing.Point(97, 19);
            this.txtHesapAra.Name = "txtHesapAra";
            this.txtHesapAra.Size = new System.Drawing.Size(100, 21);
            this.txtHesapAra.TabIndex = 1;
            // 
            // btnHesapAra
            // 
            this.btnHesapAra.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnHesapAra.ForeColor = System.Drawing.Color.Black;
            this.btnHesapAra.Location = new System.Drawing.Point(214, 17);
            this.btnHesapAra.Name = "btnHesapAra";
            this.btnHesapAra.Size = new System.Drawing.Size(75, 23);
            this.btnHesapAra.TabIndex = 3;
            this.btnHesapAra.Text = "Hesap Ara";
            this.btnHesapAra.UseVisualStyleBackColor = true;
            this.btnHesapAra.Click += new System.EventHandler(this.btnHesapAra_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtAcilisTarihi);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtHesapTuru);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtTCKN);
            this.groupBox1.Controls.Add(this.txtSoyad);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtAd);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(12, 72);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(297, 180);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Hesap Bilgileri";
            // 
            // txtAcilisTarihi
            // 
            this.txtAcilisTarihi.Location = new System.Drawing.Point(97, 135);
            this.txtAcilisTarihi.Name = "txtAcilisTarihi";
            this.txtAcilisTarihi.ReadOnly = true;
            this.txtAcilisTarihi.Size = new System.Drawing.Size(170, 21);
            this.txtAcilisTarihi.TabIndex = 16;
            this.txtAcilisTarihi.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 138);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 15);
            this.label6.TabIndex = 15;
            this.label6.Text = "Açılış Tarihi";
            // 
            // txtHesapTuru
            // 
            this.txtHesapTuru.Location = new System.Drawing.Point(97, 108);
            this.txtHesapTuru.Name = "txtHesapTuru";
            this.txtHesapTuru.ReadOnly = true;
            this.txtHesapTuru.Size = new System.Drawing.Size(170, 21);
            this.txtHesapTuru.TabIndex = 14;
            this.txtHesapTuru.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 111);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 15);
            this.label5.TabIndex = 13;
            this.label5.Text = "Hesap Türü";
            // 
            // txtTCKN
            // 
            this.txtTCKN.Location = new System.Drawing.Point(97, 82);
            this.txtTCKN.Name = "txtTCKN";
            this.txtTCKN.ReadOnly = true;
            this.txtTCKN.Size = new System.Drawing.Size(170, 21);
            this.txtTCKN.TabIndex = 12;
            this.txtTCKN.TabStop = false;
            // 
            // txtSoyad
            // 
            this.txtSoyad.Location = new System.Drawing.Point(97, 56);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.ReadOnly = true;
            this.txtSoyad.Size = new System.Drawing.Size(170, 21);
            this.txtSoyad.TabIndex = 11;
            this.txtSoyad.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "TCKN";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "Soyad";
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(97, 30);
            this.txtAd.Name = "txtAd";
            this.txtAd.ReadOnly = true;
            this.txtAd.Size = new System.Drawing.Size(170, 21);
            this.txtAd.TabIndex = 6;
            this.txtAd.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Ad";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txtHesapAra);
            this.groupBox2.Controls.Add(this.btnHesapAra);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(297, 54);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Hesap Bul";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnYazdir);
            this.groupBox3.Controls.Add(this.btnParaIslemleri);
            this.groupBox3.Controls.Add(this.txtBakiye);
            this.groupBox3.Controls.Add(this.lvHesapHareketleri);
            this.groupBox3.Controls.Add(this.txtToplamCekilen);
            this.groupBox3.Controls.Add(this.txtToplamYatan);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox3.ForeColor = System.Drawing.Color.White;
            this.groupBox3.Location = new System.Drawing.Point(330, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(577, 313);
            this.groupBox3.TabIndex = 16;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Hesap Dökümü";
            // 
            // btnYazdir
            // 
            this.btnYazdir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnYazdir.ForeColor = System.Drawing.Color.Black;
            this.btnYazdir.Location = new System.Drawing.Point(440, 273);
            this.btnYazdir.Name = "btnYazdir";
            this.btnYazdir.Size = new System.Drawing.Size(121, 23);
            this.btnYazdir.TabIndex = 23;
            this.btnYazdir.Text = "Yazdır";
            this.btnYazdir.UseVisualStyleBackColor = true;
            this.btnYazdir.Click += new System.EventHandler(this.btnYazdir_Click);
            // 
            // btnParaIslemleri
            // 
            this.btnParaIslemleri.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnParaIslemleri.ForeColor = System.Drawing.Color.Black;
            this.btnParaIslemleri.Location = new System.Drawing.Point(440, 246);
            this.btnParaIslemleri.Name = "btnParaIslemleri";
            this.btnParaIslemleri.Size = new System.Drawing.Size(121, 23);
            this.btnParaIslemleri.TabIndex = 4;
            this.btnParaIslemleri.Text = "Para İşlemleri";
            this.btnParaIslemleri.UseVisualStyleBackColor = true;
            this.btnParaIslemleri.Click += new System.EventHandler(this.btnParaIslemleri_Click);
            // 
            // txtBakiye
            // 
            this.txtBakiye.Location = new System.Drawing.Point(152, 275);
            this.txtBakiye.Name = "txtBakiye";
            this.txtBakiye.ReadOnly = true;
            this.txtBakiye.Size = new System.Drawing.Size(170, 21);
            this.txtBakiye.TabIndex = 22;
            this.txtBakiye.TabStop = false;
            this.txtBakiye.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtToplamCekilen
            // 
            this.txtToplamCekilen.Location = new System.Drawing.Point(152, 248);
            this.txtToplamCekilen.Name = "txtToplamCekilen";
            this.txtToplamCekilen.ReadOnly = true;
            this.txtToplamCekilen.Size = new System.Drawing.Size(170, 21);
            this.txtToplamCekilen.TabIndex = 21;
            this.txtToplamCekilen.TabStop = false;
            this.txtToplamCekilen.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtToplamYatan
            // 
            this.txtToplamYatan.Location = new System.Drawing.Point(152, 222);
            this.txtToplamYatan.Name = "txtToplamYatan";
            this.txtToplamYatan.ReadOnly = true;
            this.txtToplamYatan.Size = new System.Drawing.Size(170, 21);
            this.txtToplamYatan.TabIndex = 18;
            this.txtToplamYatan.TabStop = false;
            this.txtToplamYatan.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(24, 277);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 15);
            this.label7.TabIndex = 20;
            this.label7.Text = "Bakiye";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(24, 225);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(112, 15);
            this.label9.TabIndex = 17;
            this.label9.Text = "Toplam Yatan Para";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(24, 251);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(122, 15);
            this.label8.TabIndex = 19;
            this.label8.Text = "Toplam Çekilen Para";
            // 
            // pdocHareketler
            // 
            this.pdocHareketler.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.pdocHareketler_PrintPage);
            // 
            // ppdHareketler
            // 
            this.ppdHareketler.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.ppdHareketler.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.ppdHareketler.ClientSize = new System.Drawing.Size(400, 300);
            this.ppdHareketler.Document = this.pdocHareketler;
            this.ppdHareketler.Enabled = true;
            this.ppdHareketler.Icon = ((System.Drawing.Icon)(resources.GetObject("ppdHareketler.Icon")));
            this.ppdHareketler.Name = "ppdHareketler";
            this.ppdHareketler.Visible = false;
            // 
            // frmHesapDokumu
            // 
            this.AcceptButton = this.btnHesapAra;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Green;
            this.ClientSize = new System.Drawing.Size(918, 351);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmHesapDokumu";
            this.ShowIcon = false;
            this.Text = "Pakbank Hesap Dökümü";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvHesapHareketleri;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtHesapAra;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTCKN;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.TextBox txtHesapTuru;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtAcilisTarihi;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtBakiye;
        private System.Windows.Forms.TextBox txtToplamCekilen;
        private System.Windows.Forms.TextBox txtToplamYatan;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnYazdir;
        private System.Windows.Forms.Button btnParaIslemleri;
        public System.Windows.Forms.Button btnHesapAra;
        private System.Drawing.Printing.PrintDocument pdocHareketler;
        private System.Windows.Forms.PrintPreviewDialog ppdHareketler;
    }
}