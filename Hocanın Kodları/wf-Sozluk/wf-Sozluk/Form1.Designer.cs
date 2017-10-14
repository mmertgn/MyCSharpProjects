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
            this.label1.Location = new System.Drawing.Point(213, 136);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Türkçe";
            // 
            // txtTurkce
            // 
            this.txtTurkce.Location = new System.Drawing.Point(285, 136);
            this.txtTurkce.Name = "txtTurkce";
            this.txtTurkce.Size = new System.Drawing.Size(130, 26);
            this.txtTurkce.TabIndex = 1;
            // 
            // txtIngilizce
            // 
            this.txtIngilizce.Location = new System.Drawing.Point(285, 187);
            this.txtIngilizce.Name = "txtIngilizce";
            this.txtIngilizce.ReadOnly = true;
            this.txtIngilizce.Size = new System.Drawing.Size(130, 26);
            this.txtIngilizce.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(213, 187);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "İngilizce";
            // 
            // btnBul
            // 
            this.btnBul.Location = new System.Drawing.Point(421, 161);
            this.btnBul.Name = "btnBul";
            this.btnBul.Size = new System.Drawing.Size(51, 31);
            this.btnBul.TabIndex = 4;
            this.btnBul.Text = "BUL";
            this.btnBul.UseVisualStyleBackColor = true;
            this.btnBul.Click += new System.EventHandler(this.btnBul_Click);
            // 
            // rbTurkToIng
            // 
            this.rbTurkToIng.AutoSize = true;
            this.rbTurkToIng.Checked = true;
            this.rbTurkToIng.Location = new System.Drawing.Point(59, 33);
            this.rbTurkToIng.Name = "rbTurkToIng";
            this.rbTurkToIng.Size = new System.Drawing.Size(137, 24);
            this.rbTurkToIng.TabIndex = 5;
            this.rbTurkToIng.Text = "Türkçe-İngilizce";
            this.rbTurkToIng.UseVisualStyleBackColor = true;
            this.rbTurkToIng.CheckedChanged += new System.EventHandler(this.rbTurkToIng_CheckedChanged);
            // 
            // rbIngToTurk
            // 
            this.rbIngToTurk.AutoSize = true;
            this.rbIngToTurk.Location = new System.Drawing.Point(334, 33);
            this.rbIngToTurk.Name = "rbIngToTurk";
            this.rbIngToTurk.Size = new System.Drawing.Size(137, 24);
            this.rbIngToTurk.TabIndex = 6;
            this.rbIngToTurk.Text = "İngilizce-Türkçe";
            this.rbIngToTurk.UseVisualStyleBackColor = true;
            this.rbIngToTurk.CheckedChanged += new System.EventHandler(this.rbIngToTurk_CheckedChanged);
            // 
            // lbKelimeler
            // 
            this.lbKelimeler.FormattingEnabled = true;
            this.lbKelimeler.ItemHeight = 20;
            this.lbKelimeler.Location = new System.Drawing.Point(30, 96);
            this.lbKelimeler.Name = "lbKelimeler";
            this.lbKelimeler.Size = new System.Drawing.Size(146, 224);
            this.lbKelimeler.TabIndex = 7;
            this.lbKelimeler.DoubleClick += new System.EventHandler(this.lbKelimeler_DoubleClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(519, 400);
            this.Controls.Add(this.lbKelimeler);
            this.Controls.Add(this.rbIngToTurk);
            this.Controls.Add(this.rbTurkToIng);
            this.Controls.Add(this.btnBul);
            this.Controls.Add(this.txtIngilizce);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTurkce);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Sözlük";
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

