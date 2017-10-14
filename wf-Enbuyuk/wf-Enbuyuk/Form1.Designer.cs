namespace wf_Enbuyuk
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
            this.txtEnBuyuk = new System.Windows.Forms.TextBox();
            this.txtEnkucuk = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtEKAlan = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtEBAlan = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(83, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "EnBüyük";
            // 
            // txtEnBuyuk
            // 
            this.txtEnBuyuk.Location = new System.Drawing.Point(69, 76);
            this.txtEnBuyuk.Name = "txtEnBuyuk";
            this.txtEnBuyuk.ReadOnly = true;
            this.txtEnBuyuk.Size = new System.Drawing.Size(100, 26);
            this.txtEnBuyuk.TabIndex = 1;
            this.txtEnBuyuk.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtEnkucuk
            // 
            this.txtEnkucuk.Location = new System.Drawing.Point(175, 76);
            this.txtEnkucuk.Name = "txtEnkucuk";
            this.txtEnkucuk.ReadOnly = true;
            this.txtEnkucuk.Size = new System.Drawing.Size(100, 26);
            this.txtEnkucuk.TabIndex = 3;
            this.txtEnkucuk.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(189, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "EnKüçük";
            // 
            // txtEKAlan
            // 
            this.txtEKAlan.Location = new System.Drawing.Point(175, 139);
            this.txtEKAlan.Name = "txtEKAlan";
            this.txtEKAlan.ReadOnly = true;
            this.txtEKAlan.Size = new System.Drawing.Size(100, 26);
            this.txtEKAlan.TabIndex = 7;
            this.txtEKAlan.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(189, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Adı";
            // 
            // txtEBAlan
            // 
            this.txtEBAlan.Location = new System.Drawing.Point(69, 139);
            this.txtEBAlan.Name = "txtEBAlan";
            this.txtEBAlan.ReadOnly = true;
            this.txtEBAlan.Size = new System.Drawing.Size(100, 26);
            this.txtEBAlan.TabIndex = 5;
            this.txtEBAlan.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(83, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Adı";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 391);
            this.Controls.Add(this.txtEKAlan);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtEBAlan);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtEnkucuk);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtEnBuyuk);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtEnBuyuk;
        private System.Windows.Forms.TextBox txtEnkucuk;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtEKAlan;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtEBAlan;
        private System.Windows.Forms.Label label4;
    }
}

