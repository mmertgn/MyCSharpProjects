﻿namespace wf_TextYazmaOkuma
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtSatir = new System.Windows.Forms.TextBox();
            this.txtMetin = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnYaz = new System.Windows.Forms.Button();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnHepsiniOku = new System.Windows.Forms.Button();
            this.btnOku = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Yeni Satır";
            // 
            // txtSatir
            // 
            this.txtSatir.Location = new System.Drawing.Point(113, 68);
            this.txtSatir.Name = "txtSatir";
            this.txtSatir.Size = new System.Drawing.Size(368, 20);
            this.txtSatir.TabIndex = 1;
            // 
            // txtMetin
            // 
            this.txtMetin.Location = new System.Drawing.Point(113, 123);
            this.txtMetin.Name = "txtMetin";
            this.txtMetin.Size = new System.Drawing.Size(368, 108);
            this.txtMetin.TabIndex = 2;
            this.txtMetin.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Metin";
            // 
            // btnYaz
            // 
            this.btnYaz.Location = new System.Drawing.Point(142, 94);
            this.btnYaz.Name = "btnYaz";
            this.btnYaz.Size = new System.Drawing.Size(75, 23);
            this.btnYaz.TabIndex = 4;
            this.btnYaz.Text = "Yaz";
            this.btnYaz.UseVisualStyleBackColor = true;
            this.btnYaz.Click += new System.EventHandler(this.btnYaz_Click);
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(223, 94);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(75, 23);
            this.btnEkle.TabIndex = 5;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnHepsiniOku
            // 
            this.btnHepsiniOku.Location = new System.Drawing.Point(385, 94);
            this.btnHepsiniOku.Name = "btnHepsiniOku";
            this.btnHepsiniOku.Size = new System.Drawing.Size(75, 23);
            this.btnHepsiniOku.TabIndex = 7;
            this.btnHepsiniOku.Text = "Hepsini Oku";
            this.btnHepsiniOku.UseVisualStyleBackColor = true;
            this.btnHepsiniOku.Click += new System.EventHandler(this.btnHepsiniOku_Click);
            // 
            // btnOku
            // 
            this.btnOku.Location = new System.Drawing.Point(304, 94);
            this.btnOku.Name = "btnOku";
            this.btnOku.Size = new System.Drawing.Size(75, 23);
            this.btnOku.TabIndex = 6;
            this.btnOku.Text = "Oku";
            this.btnOku.UseVisualStyleBackColor = true;
            this.btnOku.Click += new System.EventHandler(this.btnOku_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(553, 332);
            this.Controls.Add(this.btnHepsiniOku);
            this.Controls.Add(this.btnOku);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.btnYaz);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtMetin);
            this.Controls.Add(this.txtSatir);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSatir;
        private System.Windows.Forms.RichTextBox txtMetin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnYaz;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnHepsiniOku;
        private System.Windows.Forms.Button btnOku;
    }
}

