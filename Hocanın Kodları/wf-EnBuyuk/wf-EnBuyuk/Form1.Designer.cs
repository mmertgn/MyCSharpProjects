namespace wf_EnBuyuk
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
            this.txtEnKucuk = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtEKAlan = new System.Windows.Forms.TextBox();
            this.txtEBAlan = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(90, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "En Büyük";
            // 
            // txtEnBuyuk
            // 
            this.txtEnBuyuk.Location = new System.Drawing.Point(94, 100);
            this.txtEnBuyuk.Name = "txtEnBuyuk";
            this.txtEnBuyuk.Size = new System.Drawing.Size(73, 26);
            this.txtEnBuyuk.TabIndex = 1;
            this.txtEnBuyuk.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtEnKucuk
            // 
            this.txtEnKucuk.Location = new System.Drawing.Point(94, 199);
            this.txtEnKucuk.Name = "txtEnKucuk";
            this.txtEnKucuk.Size = new System.Drawing.Size(73, 26);
            this.txtEnKucuk.TabIndex = 3;
            this.txtEnKucuk.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(90, 176);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "En Küçük";
            // 
            // txtEKAlan
            // 
            this.txtEKAlan.Location = new System.Drawing.Point(253, 199);
            this.txtEKAlan.Name = "txtEKAlan";
            this.txtEKAlan.Size = new System.Drawing.Size(114, 26);
            this.txtEKAlan.TabIndex = 7;
            this.txtEKAlan.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtEBAlan
            // 
            this.txtEBAlan.Location = new System.Drawing.Point(253, 100);
            this.txtEBAlan.Name = "txtEBAlan";
            this.txtEBAlan.Size = new System.Drawing.Size(114, 26);
            this.txtEBAlan.TabIndex = 5;
            this.txtEBAlan.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(260, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Alan Öğrenci";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(260, 176);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Alan Öğrenci";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(437, 365);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtEKAlan);
            this.Controls.Add(this.txtEBAlan);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtEnKucuk);
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
        private System.Windows.Forms.TextBox txtEnKucuk;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtEKAlan;
        private System.Windows.Forms.TextBox txtEBAlan;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
    }
}