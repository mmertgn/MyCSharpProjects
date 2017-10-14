namespace wf_ListBox
{
    partial class Form2
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
            this.lbKullanicilar = new System.Windows.Forms.ListBox();
            this.lbSecilenler = new System.Windows.Forms.ListBox();
            this.btnSagaTek = new System.Windows.Forms.Button();
            this.btnSagaCok = new System.Windows.Forms.Button();
            this.btnSolaCok = new System.Windows.Forms.Button();
            this.btnSolaTek = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbKullanicilar
            // 
            this.lbKullanicilar.FormattingEnabled = true;
            this.lbKullanicilar.ItemHeight = 20;
            this.lbKullanicilar.Items.AddRange(new object[] {
            "Taner",
            "Özkan",
            "Çağatay",
            "Umut",
            "Mert",
            "Kübra",
            "Emin",
            "Hilal",
            "Akif"});
            this.lbKullanicilar.Location = new System.Drawing.Point(65, 84);
            this.lbKullanicilar.Name = "lbKullanicilar";
            this.lbKullanicilar.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lbKullanicilar.Size = new System.Drawing.Size(177, 244);
            this.lbKullanicilar.TabIndex = 0;
            // 
            // lbSecilenler
            // 
            this.lbSecilenler.FormattingEnabled = true;
            this.lbSecilenler.ItemHeight = 20;
            this.lbSecilenler.Location = new System.Drawing.Point(359, 84);
            this.lbSecilenler.Name = "lbSecilenler";
            this.lbSecilenler.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lbSecilenler.Size = new System.Drawing.Size(177, 244);
            this.lbSecilenler.TabIndex = 1;
            // 
            // btnSagaTek
            // 
            this.btnSagaTek.Location = new System.Drawing.Point(273, 120);
            this.btnSagaTek.Name = "btnSagaTek";
            this.btnSagaTek.Size = new System.Drawing.Size(56, 32);
            this.btnSagaTek.TabIndex = 2;
            this.btnSagaTek.Text = ">";
            this.btnSagaTek.UseVisualStyleBackColor = true;
            this.btnSagaTek.Click += new System.EventHandler(this.btnSagaTek_Click);
            // 
            // btnSagaCok
            // 
            this.btnSagaCok.Location = new System.Drawing.Point(273, 158);
            this.btnSagaCok.Name = "btnSagaCok";
            this.btnSagaCok.Size = new System.Drawing.Size(56, 32);
            this.btnSagaCok.TabIndex = 3;
            this.btnSagaCok.Text = ">>";
            this.btnSagaCok.UseVisualStyleBackColor = true;
            this.btnSagaCok.Click += new System.EventHandler(this.btnSagaCok_Click);
            // 
            // btnSolaCok
            // 
            this.btnSolaCok.Location = new System.Drawing.Point(273, 264);
            this.btnSolaCok.Name = "btnSolaCok";
            this.btnSolaCok.Size = new System.Drawing.Size(56, 32);
            this.btnSolaCok.TabIndex = 5;
            this.btnSolaCok.Text = "<<";
            this.btnSolaCok.UseVisualStyleBackColor = true;
            this.btnSolaCok.Click += new System.EventHandler(this.btnSolaCok_Click);
            // 
            // btnSolaTek
            // 
            this.btnSolaTek.Location = new System.Drawing.Point(273, 226);
            this.btnSolaTek.Name = "btnSolaTek";
            this.btnSolaTek.Size = new System.Drawing.Size(56, 32);
            this.btnSolaTek.TabIndex = 4;
            this.btnSolaTek.Text = "<";
            this.btnSolaTek.UseVisualStyleBackColor = true;
            this.btnSolaTek.Click += new System.EventHandler(this.btnSolaTek_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(599, 444);
            this.Controls.Add(this.btnSolaCok);
            this.Controls.Add(this.btnSolaTek);
            this.Controls.Add(this.btnSagaCok);
            this.Controls.Add(this.btnSagaTek);
            this.Controls.Add(this.lbSecilenler);
            this.Controls.Add(this.lbKullanicilar);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbKullanicilar;
        private System.Windows.Forms.ListBox lbSecilenler;
        private System.Windows.Forms.Button btnSagaTek;
        private System.Windows.Forms.Button btnSagaCok;
        private System.Windows.Forms.Button btnSolaCok;
        private System.Windows.Forms.Button btnSolaTek;
    }
}