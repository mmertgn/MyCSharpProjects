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

        int TutulanSayi, Sayac = 0;
        int GirilenSayi;
        Random rnd = new Random();
        int KacHak = 10;

        private void Form1_Load(object sender, EventArgs e)
        {
            TutulanSayi = rnd.Next(1, 51); //1 ile 50 arasında rasgele sayı tutar.
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();  //Aktif formu kapatır.
        }

        private void btnGameOver_Click(object sender, EventArgs e)
        {
            Sayac = 0; //Yeni oyuna geçerken sayacı sıfırlamalıyız.
            TutulanSayi = rnd.Next(1, 51); //Yeni oyun için yeni bir sayı tanımlansın
            txtTahmin.Clear();
            txtTahmin.Focus();
        }

        private void rbOrta_CheckedChanged(object sender, EventArgs e)
        {
            KacHak = 7;
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

        private void btnDene_Click(object sender, EventArgs e)
        {
            if (txtTahmin.Text.Trim() != "")
            {
                Sayac++;
                GirilenSayi = Convert.ToInt32(txtTahmin.Text);
                if (GirilenSayi == TutulanSayi)
                {
                    MessageBox.Show("Tebrikler " + Sayac + " Denemede, Bildiniz!!!", "Tebrikler, Kazandın!!!");
                    Sayac = 0; //Yeni oyuna geçerken sayacı sıfırlamalıyız.
                    TutulanSayi = rnd.Next(1, 51); //Bildiğimizde tutulan sayı yenilensin.
                }
                else if (GirilenSayi > TutulanSayi)
                {
                    MessageBox.Show("Büyük bir sayı girdiniz!!!");
                }
                else if (GirilenSayi < TutulanSayi)
                {
                    MessageBox.Show("Küçük bir sayı girdiniz!!!");
                }
                txtTahmin.Clear();
                txtTahmin.Focus();
            }
            else
            {
                MessageBox.Show("Öncelikle tahmin girmelisiniz!");
            }



        }

    }
}
