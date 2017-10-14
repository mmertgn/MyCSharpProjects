using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wf_CokBoyutlu
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        string[] Ogrenciler = { "Necati", "Sevgi", "Hüseyin", "Sedat", "Oya" };
        int[,] Notlar = { { 40, 60 }, { 70, 30 }, { 50, 80 }, { 90, 70 }, { 60, 80 } };
        /*        int[,] Notlar = { { 40, 60, 80 }, { 70, 30, 20 }, { 50, 80, 80 }, { 90, 70, 50 }, { 60, 80, 100 } };*/ //Kaç not olursa olsun ortalamaları hesaplayıp göstermeli.
        private void Form2_Load(object sender, EventArgs e)
        {
            int Toplam = 0;
            for (int i = 0; i < Ogrenciler.Length; i++)
            {
                lbOgrenciler.Items.Add(Ogrenciler[i]);
                //lbOrtalamalar.Items.Add((Notlar[i, 0] + Notlar[i, 1]) / 2);
                Toplam = 0;
                for (int j = 0; j < Notlar.GetLength(1); j++)
                {
                    Toplam += Notlar[i, j];
                }
                lbOrtalamalar.Items.Add(Toplam / Notlar.GetLength(1));
            }
        }
    }
}
