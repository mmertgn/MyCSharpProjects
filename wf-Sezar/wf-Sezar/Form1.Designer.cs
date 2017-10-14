namespace wf_Sezar
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
            this.txtMetin = new System.Windows.Forms.TextBox();
            this.btnSifrele = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSifreli = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSifresiz = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtMetin
            // 
            this.txtMetin.Location = new System.Drawing.Point(83, 12);
            this.txtMetin.Name = "txtMetin";
            this.txtMetin.Size = new System.Drawing.Size(160, 20);
            this.txtMetin.TabIndex = 0;
            // 
            // btnSifrele
            // 
            this.btnSifrele.Location = new System.Drawing.Point(160, 38);
            this.btnSifrele.Name = "btnSifrele";
            this.btnSifrele.Size = new System.Drawing.Size(75, 23);
            this.btnSifrele.TabIndex = 1;
            this.btnSifrele.Text = "Şifrele";
            this.btnSifrele.UseVisualStyleBackColor = true;
            this.btnSifrele.Click += new System.EventHandler(this.btnSifrele_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Metin";
            // 
            // txtSifreli
            // 
            this.txtSifreli.Location = new System.Drawing.Point(83, 67);
            this.txtSifreli.Name = "txtSifreli";
            this.txtSifreli.ReadOnly = true;
            this.txtSifreli.Size = new System.Drawing.Size(160, 20);
            this.txtSifreli.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Şifreli Metin";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Şifresiz Metin";
            // 
            // txtSifresiz
            // 
            this.txtSifresiz.Location = new System.Drawing.Point(83, 93);
            this.txtSifresiz.Name = "txtSifresiz";
            this.txtSifresiz.ReadOnly = true;
            this.txtSifresiz.Size = new System.Drawing.Size(160, 20);
            this.txtSifresiz.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(265, 134);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtSifresiz);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSifreli);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSifrele);
            this.Controls.Add(this.txtMetin);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Sezar Şifreleme";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMetin;
        private System.Windows.Forms.Button btnSifrele;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSifreli;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSifresiz;
    }
}

