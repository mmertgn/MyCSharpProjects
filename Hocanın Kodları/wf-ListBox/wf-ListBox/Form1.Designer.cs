﻿namespace wf_ListBox
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
            this.lbListe = new System.Windows.Forms.ListBox();
            this.txtGirilen = new System.Windows.Forms.TextBox();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnArayaEkle = new System.Windows.Forms.Button();
            this.btnBul = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbListe
            // 
            this.lbListe.FormattingEnabled = true;
            this.lbListe.ItemHeight = 20;
            this.lbListe.Items.AddRange(new object[] {
            "büşra",
            "mert",
            "sezgin",
            "nazlı"});
            this.lbListe.Location = new System.Drawing.Point(143, 92);
            this.lbListe.Name = "lbListe";
            this.lbListe.Size = new System.Drawing.Size(159, 204);
            this.lbListe.TabIndex = 0;
            this.lbListe.SelectedIndexChanged += new System.EventHandler(this.lbListe_SelectedIndexChanged);
            // 
            // txtGirilen
            // 
            this.txtGirilen.Location = new System.Drawing.Point(143, 303);
            this.txtGirilen.Name = "txtGirilen";
            this.txtGirilen.Size = new System.Drawing.Size(159, 26);
            this.txtGirilen.TabIndex = 1;
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(304, 303);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(62, 26);
            this.btnEkle.TabIndex = 2;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(367, 303);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(62, 26);
            this.btnSil.TabIndex = 3;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnArayaEkle
            // 
            this.btnArayaEkle.Location = new System.Drawing.Point(304, 335);
            this.btnArayaEkle.Name = "btnArayaEkle";
            this.btnArayaEkle.Size = new System.Drawing.Size(125, 26);
            this.btnArayaEkle.TabIndex = 4;
            this.btnArayaEkle.Text = "Araya Ekle";
            this.btnArayaEkle.UseVisualStyleBackColor = true;
            this.btnArayaEkle.Click += new System.EventHandler(this.btnArayaEkle_Click);
            // 
            // btnBul
            // 
            this.btnBul.Location = new System.Drawing.Point(79, 303);
            this.btnBul.Name = "btnBul";
            this.btnBul.Size = new System.Drawing.Size(62, 26);
            this.btnBul.TabIndex = 5;
            this.btnBul.Text = "Bul";
            this.btnBul.UseVisualStyleBackColor = true;
            this.btnBul.Click += new System.EventHandler(this.btnBul_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(461, 419);
            this.Controls.Add(this.btnBul);
            this.Controls.Add(this.btnArayaEkle);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.txtGirilen);
            this.Controls.Add(this.lbListe);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbListe;
        private System.Windows.Forms.TextBox txtGirilen;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnArayaEkle;
        private System.Windows.Forms.Button btnBul;
    }
}

