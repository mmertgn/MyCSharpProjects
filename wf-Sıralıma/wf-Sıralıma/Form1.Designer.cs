﻿namespace wf_Sıralıma
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
            this.lbSiraliHali = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lbIlkHali
            // 
            this.lbIlkHali.FormattingEnabled = true;
            this.lbIlkHali.ItemHeight = 20;
            this.lbIlkHali.Location = new System.Drawing.Point(51, 70);
            this.lbIlkHali.Name = "lbIlkHali";
            this.lbIlkHali.Size = new System.Drawing.Size(120, 204);
            this.lbIlkHali.TabIndex = 0;
            // 
            // lbSiraliHali
            // 
            this.lbSiraliHali.FormattingEnabled = true;
            this.lbSiraliHali.ItemHeight = 20;
            this.lbSiraliHali.Location = new System.Drawing.Point(203, 70);
            this.lbSiraliHali.Name = "lbSiraliHali";
            this.lbSiraliHali.Size = new System.Drawing.Size(120, 204);
            this.lbSiraliHali.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 402);
            this.Controls.Add(this.lbSiraliHali);
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
        private System.Windows.Forms.ListBox lbSiraliHali;
    }
}

