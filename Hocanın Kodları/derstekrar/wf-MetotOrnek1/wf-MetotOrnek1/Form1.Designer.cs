namespace wf_MetotOrnek1
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
            this.rdbtnKare = new System.Windows.Forms.RadioButton();
            this.rdbtnDkdrtgn = new System.Windows.Forms.RadioButton();
            this.rdbtnDaire = new System.Windows.Forms.RadioButton();
            this.lblKenar = new System.Windows.Forms.Label();
            this.lblUzun = new System.Windows.Forms.Label();
            this.txtKenar = new System.Windows.Forms.TextBox();
            this.txtUzunknr = new System.Windows.Forms.TextBox();
            this.btnHesapla = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Papyrus", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(43, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(478, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Alanını ve Çevresini hesaplamak istediğiniz geometrik şekliniz:";
            // 
            // rdbtnKare
            // 
            this.rdbtnKare.AutoSize = true;
            this.rdbtnKare.Checked = true;
            this.rdbtnKare.Font = new System.Drawing.Font("Papyrus", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbtnKare.Location = new System.Drawing.Point(69, 94);
            this.rdbtnKare.Name = "rdbtnKare";
            this.rdbtnKare.Size = new System.Drawing.Size(76, 34);
            this.rdbtnKare.TabIndex = 1;
            this.rdbtnKare.TabStop = true;
            this.rdbtnKare.Text = "Kare";
            this.rdbtnKare.UseVisualStyleBackColor = true;
            this.rdbtnKare.CheckedChanged += new System.EventHandler(this.rdbtnKare_CheckedChanged);
            // 
            // rdbtnDkdrtgn
            // 
            this.rdbtnDkdrtgn.AutoSize = true;
            this.rdbtnDkdrtgn.Font = new System.Drawing.Font("Papyrus", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbtnDkdrtgn.Location = new System.Drawing.Point(211, 94);
            this.rdbtnDkdrtgn.Name = "rdbtnDkdrtgn";
            this.rdbtnDkdrtgn.Size = new System.Drawing.Size(136, 34);
            this.rdbtnDkdrtgn.TabIndex = 2;
            this.rdbtnDkdrtgn.Text = "Dikdörtgen";
            this.rdbtnDkdrtgn.UseVisualStyleBackColor = true;
            this.rdbtnDkdrtgn.CheckedChanged += new System.EventHandler(this.rdbtnDkdrtgn_CheckedChanged);
            // 
            // rdbtnDaire
            // 
            this.rdbtnDaire.AutoSize = true;
            this.rdbtnDaire.Font = new System.Drawing.Font("Papyrus", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbtnDaire.Location = new System.Drawing.Point(399, 94);
            this.rdbtnDaire.Name = "rdbtnDaire";
            this.rdbtnDaire.Size = new System.Drawing.Size(83, 34);
            this.rdbtnDaire.TabIndex = 3;
            this.rdbtnDaire.Text = "Daire";
            this.rdbtnDaire.UseVisualStyleBackColor = true;
            this.rdbtnDaire.CheckedChanged += new System.EventHandler(this.rdbtnDaire_CheckedChanged);
            // 
            // lblKenar
            // 
            this.lblKenar.AutoSize = true;
            this.lblKenar.BackColor = System.Drawing.Color.BurlyWood;
            this.lblKenar.Font = new System.Drawing.Font("Papyrus", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKenar.ForeColor = System.Drawing.Color.Teal;
            this.lblKenar.Location = new System.Drawing.Point(33, 183);
            this.lblKenar.Name = "lblKenar";
            this.lblKenar.Size = new System.Drawing.Size(140, 25);
            this.lblKenar.TabIndex = 4;
            this.lblKenar.Text = "Kenar Uzunluğu";
            // 
            // lblUzun
            // 
            this.lblUzun.AutoSize = true;
            this.lblUzun.BackColor = System.Drawing.Color.BurlyWood;
            this.lblUzun.Font = new System.Drawing.Font("Papyrus", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUzun.ForeColor = System.Drawing.Color.Teal;
            this.lblUzun.Location = new System.Drawing.Point(38, 243);
            this.lblUzun.Name = "lblUzun";
            this.lblUzun.Size = new System.Drawing.Size(107, 25);
            this.lblUzun.TabIndex = 5;
            this.lblUzun.Text = "Uzun Kenar";
            this.lblUzun.Visible = false;
            // 
            // txtKenar
            // 
            this.txtKenar.Font = new System.Drawing.Font("Papyrus", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKenar.Location = new System.Drawing.Point(231, 175);
            this.txtKenar.Name = "txtKenar";
            this.txtKenar.Size = new System.Drawing.Size(151, 33);
            this.txtKenar.TabIndex = 1;
            // 
            // txtUzunknr
            // 
            this.txtUzunknr.Font = new System.Drawing.Font("Papyrus", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUzunknr.Location = new System.Drawing.Point(231, 235);
            this.txtUzunknr.Name = "txtUzunknr";
            this.txtUzunknr.Size = new System.Drawing.Size(151, 33);
            this.txtUzunknr.TabIndex = 2;
            this.txtUzunknr.Visible = false;
            // 
            // btnHesapla
            // 
            this.btnHesapla.Font = new System.Drawing.Font("Papyrus", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHesapla.Location = new System.Drawing.Point(325, 313);
            this.btnHesapla.Name = "btnHesapla";
            this.btnHesapla.Size = new System.Drawing.Size(157, 47);
            this.btnHesapla.TabIndex = 8;
            this.btnHesapla.Text = "HESAPLA";
            this.btnHesapla.UseVisualStyleBackColor = true;
            this.btnHesapla.Click += new System.EventHandler(this.btnHesapla_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.btnHesapla;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BurlyWood;
            this.ClientSize = new System.Drawing.Size(621, 507);
            this.Controls.Add(this.btnHesapla);
            this.Controls.Add(this.txtUzunknr);
            this.Controls.Add(this.txtKenar);
            this.Controls.Add(this.lblUzun);
            this.Controls.Add(this.lblKenar);
            this.Controls.Add(this.rdbtnDaire);
            this.Controls.Add(this.rdbtnDkdrtgn);
            this.Controls.Add(this.rdbtnKare);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Alan Ve Cevre Hesabı";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rdbtnKare;
        private System.Windows.Forms.RadioButton rdbtnDkdrtgn;
        private System.Windows.Forms.RadioButton rdbtnDaire;
        private System.Windows.Forms.Label lblKenar;
        private System.Windows.Forms.Label lblUzun;
        private System.Windows.Forms.TextBox txtKenar;
        private System.Windows.Forms.TextBox txtUzunknr;
        private System.Windows.Forms.Button btnHesapla;
    }
}

