using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wf_Enbuyuk
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int[] notlar = { 30, 50, 80, 60, 70, 20, 90, 40 };
        string[] ogrenciler = { "Ali", "Neşe", "Oya", "Sinan", "Murat", "Ayşe", "Hasan", "Niyazi" };
        int EnBuyuk,Enkucuk;
        string EKAlan, EBAlan;
        private void Form1_Load(object sender, EventArgs e)
        {
            EnBuyuk = notlar[0];
            Enkucuk = notlar[0];
            EBAlan = ogrenciler[0];
            EKAlan = ogrenciler[0];
            for (int i = 0; i < notlar.Length; i++)
            {
                if (notlar[i] > EnBuyuk)
                {
                    EnBuyuk = notlar[i];
                    EBAlan = ogrenciler[i];
                }
                if (notlar[i] < Enkucuk)
                {
                    Enkucuk = notlar[i];
                    EKAlan = ogrenciler[i];
                }
            }

            txtEnBuyuk.Text = EnBuyuk.ToString();
            txtEnkucuk.Text = Enkucuk.ToString();
            txtEBAlan.Text = EBAlan.ToString();
            txtEKAlan.Text = EKAlan.ToString();

        }
    }
}
