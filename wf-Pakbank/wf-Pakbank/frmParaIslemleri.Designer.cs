namespace wf_Pakbank
{
    partial class frmParaIslemleri
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
            this.txtTarih = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtHesapNo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtHesapID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnTamam = new System.Windows.Forms.Button();
            this.cbIslemTuru = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtIslemTutari = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtTarih
            // 
            this.txtTarih.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtTarih.Location = new System.Drawing.Point(80, 82);
            this.txtTarih.Name = "txtTarih";
            this.txtTarih.ReadOnly = true;
            this.txtTarih.Size = new System.Drawing.Size(170, 20);
            this.txtTarih.TabIndex = 31;
            this.txtTarih.TabStop = false;
            this.txtTarih.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.Color.Transparent;
            this.label12.Location = new System.Drawing.Point(18, 84);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(31, 13);
            this.label12.TabIndex = 30;
            this.label12.Text = "Tarih";
            // 
            // txtHesapNo
            // 
            this.txtHesapNo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtHesapNo.Location = new System.Drawing.Point(80, 56);
            this.txtHesapNo.Name = "txtHesapNo";
            this.txtHesapNo.ReadOnly = true;
            this.txtHesapNo.Size = new System.Drawing.Size(170, 20);
            this.txtHesapNo.TabIndex = 29;
            this.txtHesapNo.TabStop = false;
            this.txtHesapNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(18, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 26;
            this.label1.Text = "Hesap ID";
            // 
            // txtHesapID
            // 
            this.txtHesapID.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtHesapID.Location = new System.Drawing.Point(80, 27);
            this.txtHesapID.Name = "txtHesapID";
            this.txtHesapID.ReadOnly = true;
            this.txtHesapID.Size = new System.Drawing.Size(170, 20);
            this.txtHesapID.TabIndex = 27;
            this.txtHesapID.TabStop = false;
            this.txtHesapID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(18, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 28;
            this.label2.Text = "Hesap No";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnTamam);
            this.groupBox1.Controls.Add(this.cbIslemTuru);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtIslemTutari);
            this.groupBox1.Controls.Add(this.txtHesapNo);
            this.groupBox1.Controls.Add(this.txtTarih);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.txtHesapID);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(298, 217);
            this.groupBox1.TabIndex = 32;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Para İşlemleri";
            // 
            // btnTamam
            // 
            this.btnTamam.BackColor = System.Drawing.Color.Transparent;
            this.btnTamam.ForeColor = System.Drawing.Color.Black;
            this.btnTamam.Location = new System.Drawing.Point(175, 161);
            this.btnTamam.Name = "btnTamam";
            this.btnTamam.Size = new System.Drawing.Size(75, 23);
            this.btnTamam.TabIndex = 34;
            this.btnTamam.Text = "Tamam";
            this.btnTamam.UseVisualStyleBackColor = false;
            this.btnTamam.Click += new System.EventHandler(this.btnTamam_Click);
            // 
            // cbIslemTuru
            // 
            this.cbIslemTuru.ForeColor = System.Drawing.Color.Black;
            this.cbIslemTuru.FormattingEnabled = true;
            this.cbIslemTuru.Items.AddRange(new object[] {
            "Para Yatırma",
            "Para Çekme"});
            this.cbIslemTuru.Location = new System.Drawing.Point(80, 134);
            this.cbIslemTuru.Name = "cbIslemTuru";
            this.cbIslemTuru.Size = new System.Drawing.Size(170, 21);
            this.cbIslemTuru.TabIndex = 33;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.Transparent;
            this.label9.Location = new System.Drawing.Point(18, 142);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 13);
            this.label9.TabIndex = 36;
            this.label9.Text = "İşlem Türü";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(18, 111);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 35;
            this.label5.Text = "İşlem Tutarı";
            // 
            // txtIslemTutari
            // 
            this.txtIslemTutari.ForeColor = System.Drawing.Color.Black;
            this.txtIslemTutari.Location = new System.Drawing.Point(80, 108);
            this.txtIslemTutari.Name = "txtIslemTutari";
            this.txtIslemTutari.Size = new System.Drawing.Size(170, 20);
            this.txtIslemTutari.TabIndex = 32;
            // 
            // frmParaIslemleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Green;
            this.ClientSize = new System.Drawing.Size(323, 243);
            this.Controls.Add(this.groupBox1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "frmParaIslemleri";
            this.ShowIcon = false;
            this.Text = "Pakbank Para İşlemleri";
            this.Load += new System.EventHandler(this.frmParaIslemleri_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtTarih;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnTamam;
        private System.Windows.Forms.ComboBox cbIslemTuru;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtIslemTutari;
        public System.Windows.Forms.TextBox txtHesapID;
        public System.Windows.Forms.TextBox txtHesapNo;
    }
}