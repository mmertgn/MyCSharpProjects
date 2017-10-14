namespace wf_Sozluk
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
            this.txtTurkce = new System.Windows.Forms.TextBox();
            this.txtIngilizce = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnBul = new System.Windows.Forms.Button();
            this.rbTurkToIng = new System.Windows.Forms.RadioButton();
            this.rbIngToTurk = new System.Windows.Forms.RadioButton();
            this.lbKelimeler = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(233, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Türkçe";
            // 
            // txtTurkce
            // 
            this.txtTurkce.Location = new System.Drawing.Point(280, 55);
            this.txtTurkce.Name = "txtTurkce";
            this.txtTurkce.Size = new System.Drawing.Size(100, 20);
            this.txtTurkce.TabIndex = 1;
            // 
            // txtIngilizce
            // 
            this.txtIngilizce.Location = new System.Drawing.Point(280, 81);
            this.txtIngilizce.Name = "txtIngilizce";
            this.txtIngilizce.ReadOnly = true;
            this.txtIngilizce.Size = new System.Drawing.Size(100, 20);
            this.txtIngilizce.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(229, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "İngilizce";
            // 
            // btnBul
            // 
            this.btnBul.Location = new System.Drawing.Point(386, 78);
            this.btnBul.Name = "btnBul";
            this.btnBul.Size = new System.Drawing.Size(75, 23);
            this.btnBul.TabIndex = 4;
            this.btnBul.Text = "Bul";
            this.btnBul.UseVisualStyleBackColor = true;
            this.btnBul.Click += new System.EventHandler(this.btnBul_Click);
            // 
            // rbTurkToIng
            // 
            this.rbTurkToIng.AutoSize = true;
            this.rbTurkToIng.Checked = true;
            this.rbTurkToIng.Location = new System.Drawing.Point(98, 24);
            this.rbTurkToIng.Name = "rbTurkToIng";
            this.rbTurkToIng.Size = new System.Drawing.Size(106, 17);
            this.rbTurkToIng.TabIndex = 5;
            this.rbTurkToIng.Text = "Türkçe - İngilizce";
            this.rbTurkToIng.UseVisualStyleBackColor = true;
            this.rbTurkToIng.CheckedChanged += new System.EventHandler(this.rbTurkToIng_CheckedChanged);
            // 
            // rbIngToTurk
            // 
            this.rbIngToTurk.AutoSize = true;
            this.rbIngToTurk.Location = new System.Drawing.Point(204, 24);
            this.rbIngToTurk.Name = "rbIngToTurk";
            this.rbIngToTurk.Size = new System.Drawing.Size(106, 17);
            this.rbIngToTurk.TabIndex = 6;
            this.rbIngToTurk.Text = "İngilizce - Türkçe";
            this.rbIngToTurk.UseVisualStyleBackColor = true;
            this.rbIngToTurk.CheckedChanged += new System.EventHandler(this.rbIngToTurk_CheckedChanged);
            // 
            // lbKelimeler
            // 
            this.lbKelimeler.FormattingEnabled = true;
            this.lbKelimeler.Location = new System.Drawing.Point(103, 55);
            this.lbKelimeler.Name = "lbKelimeler";
            this.lbKelimeler.Size = new System.Drawing.Size(120, 173);
            this.lbKelimeler.TabIndex = 7;
            this.lbKelimeler.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lbKelimeler_MouseDoubleClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(603, 386);
            this.Controls.Add(this.lbKelimeler);
            this.Controls.Add(this.rbIngToTurk);
            this.Controls.Add(this.rbTurkToIng);
            this.Controls.Add(this.btnBul);
            this.Controls.Add(this.txtIngilizce);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTurkce);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTurkce;
        private System.Windows.Forms.TextBox txtIngilizce;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnBul;
        private System.Windows.Forms.RadioButton rbTurkToIng;
        private System.Windows.Forms.RadioButton rbIngToTurk;
        private System.Windows.Forms.ListBox lbKelimeler;
    }
}

