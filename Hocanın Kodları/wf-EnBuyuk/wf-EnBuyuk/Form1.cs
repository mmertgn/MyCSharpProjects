using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wf_EnBuyuk
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int[] Notlar = { 30, 50, 80, 60, 70, 20, 90, 40 };
        string[] Ogrenciler = { "Ali", "Neşe", "Oya", "Sinan", "Murat", "Ayşe", "Hasan", "Niyazi" };
        int EB = 0;
        int EK = 0;
        string EBAlan, EKAlan;
        private void Form1_Load(object sender, EventArgs e)
        {
            //MessageBox.Show("En Büyük : " + Notlar.Max());
            //MessageBox.Show("En Küçük : " + Notlar.Min());
            EB = Notlar[0];
            EK = Notlar[0];
            EBAlan = Ogrenciler[0];
            EKAlan = Ogrenciler[0];
            for (int i = 1; i < Notlar.Length; i++)
            {
                if(Notlar[i] > EB)
                {
                    EB = Notlar[i];
                    EBAlan = Ogrenciler[i];
                }
                if (Notlar[i] < EK)
                {
                    EK = Notlar[i];
                    EKAlan = Ogrenciler[i];
                }
            }
            txtEnBuyuk.Text = EB.ToString();
            txtEnKucuk.Text = EK.ToString();
            txtEBAlan.Text = EBAlan;
            txtEKAlan.Text = EKAlan;
        }
    }
}
