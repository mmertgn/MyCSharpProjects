namespace wf_BizimYaris4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pb1 = new System.Windows.Forms.PictureBox();
            this.pb2 = new System.Windows.Forms.PictureBox();
            this.pb3 = new System.Windows.Forms.PictureBox();
            this.pb4 = new System.Windows.Forms.PictureBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnSifirla = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pb1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb4)).BeginInit();
            this.SuspendLayout();
            // 
            // pb1
            // 
            this.pb1.Image = ((System.Drawing.Image)(resources.GetObject("pb1.Image")));
            this.pb1.Location = new System.Drawing.Point(31, 12);
            this.pb1.Name = "pb1";
            this.pb1.Size = new System.Drawing.Size(166, 109);
            this.pb1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb1.TabIndex = 0;
            this.pb1.TabStop = false;
            // 
            // pb2
            // 
            this.pb2.Image = ((System.Drawing.Image)(resources.GetObject("pb2.Image")));
            this.pb2.Location = new System.Drawing.Point(31, 127);
            this.pb2.Name = "pb2";
            this.pb2.Size = new System.Drawing.Size(166, 109);
            this.pb2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb2.TabIndex = 1;
            this.pb2.TabStop = false;
            // 
            // pb3
            // 
            this.pb3.Image = ((System.Drawing.Image)(resources.GetObject("pb3.Image")));
            this.pb3.Location = new System.Drawing.Point(31, 242);
            this.pb3.Name = "pb3";
            this.pb3.Size = new System.Drawing.Size(166, 109);
            this.pb3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb3.TabIndex = 2;
            this.pb3.TabStop = false;
            // 
            // pb4
            // 
            this.pb4.Image = ((System.Drawing.Image)(resources.GetObject("pb4.Image")));
            this.pb4.Location = new System.Drawing.Point(31, 357);
            this.pb4.Name = "pb4";
            this.pb4.Size = new System.Drawing.Size(166, 109);
            this.pb4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb4.TabIndex = 3;
            this.pb4.TabStop = false;
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnStart.Location = new System.Drawing.Point(31, 472);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(166, 37);
            this.btnStart.TabIndex = 4;
            this.btnStart.Text = "START";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 50;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnSifirla
            // 
            this.btnSifirla.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSifirla.Location = new System.Drawing.Point(203, 472);
            this.btnSifirla.Name = "btnSifirla";
            this.btnSifirla.Size = new System.Drawing.Size(166, 37);
            this.btnSifirla.TabIndex = 5;
            this.btnSifirla.Text = "SIFIRLA";
            this.btnSifirla.UseVisualStyleBackColor = true;
            this.btnSifirla.Click += new System.EventHandler(this.btnSifirla_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LimeGreen;
            this.ClientSize = new System.Drawing.Size(943, 515);
            this.Controls.Add(this.btnSifirla);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.pb4);
            this.Controls.Add(this.pb3);
            this.Controls.Add(this.pb2);
            this.Controls.Add(this.pb1);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "MS-YAZ6 HİPODROM";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pb1;
        private System.Windows.Forms.PictureBox pb2;
        private System.Windows.Forms.PictureBox pb3;
        private System.Windows.Forms.PictureBox pb4;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnSifirla;
    }
}

