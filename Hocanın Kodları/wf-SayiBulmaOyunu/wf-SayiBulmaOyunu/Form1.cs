using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wf_SayiBulmaOyunu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int TutulanSayi;
        int Tahmin;
        int Say = 0;
        Random rnd = new Random();
        int KacHak = 10;
        private void Form1_Load(object sender, EventArgs e)
        {
            TutulanSayi = rnd.Next(1, 51); //1 ile 50 arasında rastgele sayı tutar.
        }
        private void btnDene_Click(object sender, EventArgs e)
        {
            if(txtTahmin.Text.Trim() != "")
            {
                Say++;
                Tahmin = Convert.ToInt32(txtTahmin.Text);
                if (Tahmin > TutulanSayi)
                    MessageBox.Show("Tahmininiz Büyük", "Denemeye Devam");
                else if (Tahmin < TutulanSayi)
                    MessageBox.Show("Tahmininiz Küçük", "Denemeye Devam");
                else
                {
                    MessageBox.Show("Tebrikler! " + Say + " Defada Bildiniz!", "Tebrikler! Kazandın!!!");
                    Say = 0; //Yeni oyuna geçerken sayacı sıfırlamalıyız.
                    TutulanSayi = rnd.Next(1, 51); //Tutulan sayı da yenilensin.
                }
                txtTahmin.Clear();
            }
            else
            {
                MessageBox.Show("Öncelikle tahmin girmelisiniz!");
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close(); //Aktif formu kapatır.
        }
        private void btnGameOver_Click(object sender, EventArgs e)
        {
            TutulanSayi = rnd.Next(1, 51);
            Say = 0;
            txtTahmin.Clear();
            txtTahmin.Focus();
        }
        private void rbOrta_CheckedChanged(object sender, EventArgs e)
        {
            KacHak = 7;
            //btnGameOver_Click(sender, e);
            TutulanSayi = rnd.Next(1, 51);
        }
        private void rbIleri_CheckedChanged(object sender, EventArgs e)
        {
            KacHak = 4;
            TutulanSayi = rnd.Next(1, 51);
        }
        private void rbBaslangic_CheckedChanged(object sender, EventArgs e)
        {
            KacHak = 10;
            TutulanSayi = rnd.Next(1, 51);
        }
    }
}
