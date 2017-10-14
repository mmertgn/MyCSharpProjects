namespace wf_Siralama
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
            this.lbIlkHali = new System.Windows.Forms.ListBox();
            this.lbSirali = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lbIlkHali
            // 
            this.lbIlkHali.FormattingEnabled = true;
            this.lbIlkHali.ItemHeight = 20;
            this.lbIlkHali.Location = new System.Drawing.Point(95, 114);
            this.lbIlkHali.Name = "lbIlkHali";
            this.lbIlkHali.Size = new System.Drawing.Size(147, 204);
            this.lbIlkHali.TabIndex = 0;
            // 
            // lbSirali
            // 
            this.lbSirali.FormattingEnabled = true;
            this.lbSirali.ItemHeight = 20;
            this.lbSirali.Location = new System.Drawing.Point(328, 114);
            this.lbSirali.Name = "lbSirali";
            this.lbSirali.Size = new System.Drawing.Size(147, 204);
            this.lbSirali.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 476);
            this.Controls.Add(this.lbSirali);
            this.Controls.Add(this.lbIlkHali);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbIlkHali;
        private System.Windows.Forms.ListBox lbSirali;
    }
}

