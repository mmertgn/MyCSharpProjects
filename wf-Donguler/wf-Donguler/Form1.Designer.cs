namespace wf_Donguler
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
            this.lbSayilar = new System.Windows.Forms.ListBox();
            this.lbTekSayilar = new System.Windows.Forms.ListBox();
            this.lbCiftSayilar = new System.Windows.Forms.ListBox();
            this.btnSayilar = new System.Windows.Forms.Button();
            this.btnTekSayilar = new System.Windows.Forms.Button();
            this.btnCiftSayilar = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.txtToplam = new System.Windows.Forms.TextBox();
            this.txtTekToplam = new System.Windows.Forms.TextBox();
            this.txtCiftToplam = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbSayilar
            // 
            this.lbSayilar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbSayilar.FormattingEnabled = true;
            this.lbSayilar.ItemHeight = 20;
            this.lbSayilar.Location = new System.Drawing.Point(86, 64);
            this.lbSayilar.Name = "lbSayilar";
            this.lbSayilar.Size = new System.Drawing.Size(179, 164);
            this.lbSayilar.TabIndex = 0;
            // 
            // lbTekSayilar
            // 
            this.lbTekSayilar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbTekSayilar.FormattingEnabled = true;
            this.lbTekSayilar.ItemHeight = 20;
            this.lbTekSayilar.Location = new System.Drawing.Point(286, 64);
            this.lbTekSayilar.Name = "lbTekSayilar";
            this.lbTekSayilar.Size = new System.Drawing.Size(179, 164);
            this.lbTekSayilar.TabIndex = 1;
            // 
            // lbCiftSayilar
            // 
            this.lbCiftSayilar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbCiftSayilar.FormattingEnabled = true;
            this.lbCiftSayilar.ItemHeight = 20;
            this.lbCiftSayilar.Location = new System.Drawing.Point(486, 64);
            this.lbCiftSayilar.Name = "lbCiftSayilar";
            this.lbCiftSayilar.Size = new System.Drawing.Size(179, 164);
            this.lbCiftSayilar.TabIndex = 2;
            // 
            // btnSayilar
            // 
            this.btnSayilar.Location = new System.Drawing.Point(136, 35);
            this.btnSayilar.Name = "btnSayilar";
            this.btnSayilar.Size = new System.Drawing.Size(75, 23);
            this.btnSayilar.TabIndex = 3;
            this.btnSayilar.Text = "Sayılar";
            this.btnSayilar.UseVisualStyleBackColor = true;
            this.btnSayilar.Click += new System.EventHandler(this.btnSayilar_Click);
            // 
            // btnTekSayilar
            // 
            this.btnTekSayilar.Location = new System.Drawing.Point(337, 35);
            this.btnTekSayilar.Name = "btnTekSayilar";
            this.btnTekSayilar.Size = new System.Drawing.Size(75, 23);
            this.btnTekSayilar.TabIndex = 4;
            this.btnTekSayilar.Text = "Tek Sayılar";
            this.btnTekSayilar.UseVisualStyleBackColor = true;
            this.btnTekSayilar.Click += new System.EventHandler(this.btnTekSayilar_Click);
            // 
            // btnCiftSayilar
            // 
            this.btnCiftSayilar.Location = new System.Drawing.Point(538, 35);
            this.btnCiftSayilar.Name = "btnCiftSayilar";
            this.btnCiftSayilar.Size = new System.Drawing.Size(75, 23);
            this.btnCiftSayilar.TabIndex = 5;
            this.btnCiftSayilar.Text = "Çift Sayılar";
            this.btnCiftSayilar.UseVisualStyleBackColor = true;
            this.btnCiftSayilar.Click += new System.EventHandler(this.btnCiftSayilar_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(38, 240);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 13);
            this.label8.TabIndex = 6;
            this.label8.Text = "Toplam";
            // 
            // txtToplam
            // 
            this.txtToplam.Enabled = false;
            this.txtToplam.Location = new System.Drawing.Point(86, 237);
            this.txtToplam.Name = "txtToplam";
            this.txtToplam.Size = new System.Drawing.Size(179, 20);
            this.txtToplam.TabIndex = 7;
            // 
            // txtTekToplam
            // 
            this.txtTekToplam.Enabled = false;
            this.txtTekToplam.Location = new System.Drawing.Point(286, 237);
            this.txtTekToplam.Name = "txtTekToplam";
            this.txtTekToplam.Size = new System.Drawing.Size(179, 20);
            this.txtTekToplam.TabIndex = 8;
            // 
            // txtCiftToplam
            // 
            this.txtCiftToplam.Enabled = false;
            this.txtCiftToplam.Location = new System.Drawing.Point(486, 237);
            this.txtCiftToplam.Name = "txtCiftToplam";
            this.txtCiftToplam.Size = new System.Drawing.Size(179, 20);
            this.txtCiftToplam.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(817, 417);
            this.Controls.Add(this.txtCiftToplam);
            this.Controls.Add(this.txtTekToplam);
            this.Controls.Add(this.txtToplam);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnCiftSayilar);
            this.Controls.Add(this.btnTekSayilar);
            this.Controls.Add(this.btnSayilar);
            this.Controls.Add(this.lbCiftSayilar);
            this.Controls.Add(this.lbTekSayilar);
            this.Controls.Add(this.lbSayilar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbSayilar;
        private System.Windows.Forms.ListBox lbTekSayilar;
        private System.Windows.Forms.ListBox lbCiftSayilar;
        private System.Windows.Forms.Button btnSayilar;
        private System.Windows.Forms.Button btnTekSayilar;
        private System.Windows.Forms.Button btnCiftSayilar;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtToplam;
        private System.Windows.Forms.TextBox txtTekToplam;
        private System.Windows.Forms.TextBox txtCiftToplam;
    }
}

