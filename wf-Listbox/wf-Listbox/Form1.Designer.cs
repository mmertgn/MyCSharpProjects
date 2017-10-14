namespace wf_Listbox
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
            this.lbListe.Items.AddRange(new object[] {
            "büşra",
            "mert",
            "sezgin",
            "nazlı"});
            this.lbListe.Location = new System.Drawing.Point(133, 47);
            this.lbListe.Name = "lbListe";
            this.lbListe.Size = new System.Drawing.Size(120, 147);
            this.lbListe.TabIndex = 0;
            // 
            // txtGirilen
            // 
            this.txtGirilen.Location = new System.Drawing.Point(133, 199);
            this.txtGirilen.Name = "txtGirilen";
            this.txtGirilen.Size = new System.Drawing.Size(120, 20);
            this.txtGirilen.TabIndex = 1;
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(259, 199);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(75, 23);
            this.btnEkle.TabIndex = 2;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(340, 199);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(75, 23);
            this.btnSil.TabIndex = 3;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnArayaEkle
            // 
            this.btnArayaEkle.Location = new System.Drawing.Point(259, 228);
            this.btnArayaEkle.Name = "btnArayaEkle";
            this.btnArayaEkle.Size = new System.Drawing.Size(156, 23);
            this.btnArayaEkle.TabIndex = 4;
            this.btnArayaEkle.Text = "Araya Ekle";
            this.btnArayaEkle.UseVisualStyleBackColor = true;
            this.btnArayaEkle.Click += new System.EventHandler(this.btnArayaEkle_Click);
            // 
            // btnBul
            // 
            this.btnBul.Location = new System.Drawing.Point(52, 196);
            this.btnBul.Name = "btnBul";
            this.btnBul.Size = new System.Drawing.Size(75, 23);
            this.btnBul.TabIndex = 5;
            this.btnBul.Text = "Bul";
            this.btnBul.UseVisualStyleBackColor = true;
            this.btnBul.Click += new System.EventHandler(this.btnBul_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(487, 269);
            this.Controls.Add(this.btnBul);
            this.Controls.Add(this.btnArayaEkle);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.txtGirilen);
            this.Controls.Add(this.lbListe);
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

