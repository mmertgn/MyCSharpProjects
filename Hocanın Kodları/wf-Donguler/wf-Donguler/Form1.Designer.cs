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
            this.label1 = new System.Windows.Forms.Label();
            this.txtToplam = new System.Windows.Forms.TextBox();
            this.txtTekToplam = new System.Windows.Forms.TextBox();
            this.txtCiftToplam = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbSayilar
            // 
            this.lbSayilar.FormattingEnabled = true;
            this.lbSayilar.ItemHeight = 20;
            this.lbSayilar.Location = new System.Drawing.Point(80, 86);
            this.lbSayilar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lbSayilar.Name = "lbSayilar";
            this.lbSayilar.Size = new System.Drawing.Size(125, 204);
            this.lbSayilar.TabIndex = 0;
            // 
            // lbTekSayilar
            // 
            this.lbTekSayilar.FormattingEnabled = true;
            this.lbTekSayilar.ItemHeight = 20;
            this.lbTekSayilar.Location = new System.Drawing.Point(247, 86);
            this.lbTekSayilar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lbTekSayilar.Name = "lbTekSayilar";
            this.lbTekSayilar.Size = new System.Drawing.Size(125, 204);
            this.lbTekSayilar.TabIndex = 1;
            // 
            // lbCiftSayilar
            // 
            this.lbCiftSayilar.FormattingEnabled = true;
            this.lbCiftSayilar.ItemHeight = 20;
            this.lbCiftSayilar.Location = new System.Drawing.Point(416, 86);
            this.lbCiftSayilar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lbCiftSayilar.Name = "lbCiftSayilar";
            this.lbCiftSayilar.Size = new System.Drawing.Size(125, 204);
            this.lbCiftSayilar.TabIndex = 2;
            // 
            // btnSayilar
            // 
            this.btnSayilar.Location = new System.Drawing.Point(94, 52);
            this.btnSayilar.Name = "btnSayilar";
            this.btnSayilar.Size = new System.Drawing.Size(96, 26);
            this.btnSayilar.TabIndex = 3;
            this.btnSayilar.Text = "Sayılar";
            this.btnSayilar.UseVisualStyleBackColor = true;
            this.btnSayilar.Click += new System.EventHandler(this.btnSayilar_Click);
            // 
            // btnTekSayilar
            // 
            this.btnTekSayilar.Location = new System.Drawing.Point(259, 52);
            this.btnTekSayilar.Name = "btnTekSayilar";
            this.btnTekSayilar.Size = new System.Drawing.Size(96, 26);
            this.btnTekSayilar.TabIndex = 4;
            this.btnTekSayilar.Text = "Tek Sayılar";
            this.btnTekSayilar.UseVisualStyleBackColor = true;
            this.btnTekSayilar.Click += new System.EventHandler(this.btnTekSayilar_Click);
            // 
            // btnCiftSayilar
            // 
            this.btnCiftSayilar.Location = new System.Drawing.Point(427, 52);
            this.btnCiftSayilar.Name = "btnCiftSayilar";
            this.btnCiftSayilar.Size = new System.Drawing.Size(96, 26);
            this.btnCiftSayilar.TabIndex = 5;
            this.btnCiftSayilar.Text = "Çift Sayılar";
            this.btnCiftSayilar.UseVisualStyleBackColor = true;
            this.btnCiftSayilar.Click += new System.EventHandler(this.btnCiftSayilar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 329);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Toplam";
            // 
            // txtToplam
            // 
            this.txtToplam.Location = new System.Drawing.Point(81, 329);
            this.txtToplam.Name = "txtToplam";
            this.txtToplam.ReadOnly = true;
            this.txtToplam.Size = new System.Drawing.Size(124, 26);
            this.txtToplam.TabIndex = 7;
            // 
            // txtTekToplam
            // 
            this.txtTekToplam.Location = new System.Drawing.Point(248, 329);
            this.txtTekToplam.Name = "txtTekToplam";
            this.txtTekToplam.ReadOnly = true;
            this.txtTekToplam.Size = new System.Drawing.Size(124, 26);
            this.txtTekToplam.TabIndex = 8;
            // 
            // txtCiftToplam
            // 
            this.txtCiftToplam.Location = new System.Drawing.Point(417, 326);
            this.txtCiftToplam.Name = "txtCiftToplam";
            this.txtCiftToplam.ReadOnly = true;
            this.txtCiftToplam.Size = new System.Drawing.Size(124, 26);
            this.txtCiftToplam.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(649, 459);
            this.Controls.Add(this.txtCiftToplam);
            this.Controls.Add(this.txtTekToplam);
            this.Controls.Add(this.txtToplam);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCiftSayilar);
            this.Controls.Add(this.btnTekSayilar);
            this.Controls.Add(this.btnSayilar);
            this.Controls.Add(this.lbCiftSayilar);
            this.Controls.Add(this.lbTekSayilar);
            this.Controls.Add(this.lbSayilar);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtToplam;
        private System.Windows.Forms.TextBox txtTekToplam;
        private System.Windows.Forms.TextBox txtCiftToplam;
    }
}

