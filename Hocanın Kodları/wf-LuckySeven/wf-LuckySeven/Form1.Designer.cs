namespace wf_LuckySeven
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
            this.components = new System.ComponentModel.Container();
            this.lbl1 = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.lbl3 = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lbl1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl1.Font = new System.Drawing.Font("Comic Sans MS", 64F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl1.Location = new System.Drawing.Point(118, 105);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(106, 123);
            this.lbl1.TabIndex = 0;
            this.lbl1.Text = "7";
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lbl2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl2.Font = new System.Drawing.Font("Comic Sans MS", 64F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl2.Location = new System.Drawing.Point(254, 105);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(106, 123);
            this.lbl2.TabIndex = 1;
            this.lbl2.Text = "7";
            // 
            // lbl3
            // 
            this.lbl3.AutoSize = true;
            this.lbl3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lbl3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl3.Font = new System.Drawing.Font("Comic Sans MS", 64F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl3.Location = new System.Drawing.Point(389, 105);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(106, 123);
            this.lbl3.TabIndex = 2;
            this.lbl3.Text = "7";
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(254, 277);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(106, 37);
            this.btnStart.TabIndex = 3;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 40;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(629, 446);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.lbl3);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.lbl1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "LUCKY SEVEN";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Timer timer1;
    }
}

