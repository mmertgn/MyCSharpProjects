using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wf_MetotOrnek1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
          
        }

        private void rdbtnKare_CheckedChanged(object sender, EventArgs e)
        {
            
            Textboxtemizle();
            lblKenar.Text = "Kenar uzunluğu";
            lblUzun.Visible = false;
            txtUzunknr.Visible = false;

            
        }

        private void rdbtnDkdrtgn_CheckedChanged(object sender, EventArgs e)
        {
            Textboxtemizle();
            lblKenar.Text = "Kısa Kenar";
            lblUzun.Visible = true;
            txtUzunknr.Visible = true;

            
        }

        private void rdbtnDaire_CheckedChanged(object sender, EventArgs e)
        {
            Textboxtemizle();
            lblKenar.Text = "Yarıçap";
            lblUzun.Visible = false;
            txtUzunknr.Visible = false;

        }

        private double AlanHesabi(double yaricap)
        {
            double pi = 3.14;
            double alan = pi * yaricap*yaricap;
            return alan;
        }
        private int AlanHesabi(int kenar)
        {
            
            int alan = kenar * kenar;
            return alan;
        }
        private int AlanHesabi(int kisa, int uzun)
        {
            int alan = kisa * uzun;
            return alan;
        }
        private void Textboxtemizle()
        {
            txtKenar.Clear();
            txtUzunknr.Clear();
        }
        private void SonucuGoster(string sonuc)
        {
            MessageBox.Show(sonuc);
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
           if(rdbtnDaire.Checked)
            {
                double r = double.Parse(txtKenar.Text);
                string sonuc = Convert.ToString(AlanHesabi(r));
                SonucuGoster(sonuc);
            }
            else if(rdbtnDkdrtgn.Checked)
            {
                int kisa = int.Parse(txtKenar.Text);
                int uzun = int.Parse(txtUzunknr.Text);
                string sonuc = Convert.ToString (AlanHesabi(kisa,uzun));
                SonucuGoster(sonuc);
            }
            else if (rdbtnKare.Checked)
            {
                int kenar = int.Parse(txtKenar.Text);
                string sonuc = Convert.ToString(AlanHesabi(kenar));
                SonucuGoster(sonuc);
            }
            Textboxtemizle();
        }
    }
}
