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
        //int[,] Notlar = new int[5, 2]; //5 öğrencinin 2 şer notu = 10Not
        //int[,] Notlar = { { 40, 60 }, { 70, 30 }, { 50, 80 }, { 90, 70 }, { 60, 80 } };
        int[,] Notlar = { { 40, 60, 80 }, { 70, 30, 20 }, { 50, 80, 80 }, { 90, 70, 50 }, { 60, 80, 100 } };
        int toplam = 0;

        private void Form2_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < Notlar.GetLength(0); i++)
            {
                lbOgrenciler.Items.Add(Ogrenciler[i]);

                for (int j = 0; j < Notlar.GetLength(1); j++)
                {
                    toplam = toplam + Notlar[i, j];
                }
                lbOrtalamalar.Items.Add(toplam / Notlar.GetLength(1));
                toplam = 0;
            }
        }
    }
}
