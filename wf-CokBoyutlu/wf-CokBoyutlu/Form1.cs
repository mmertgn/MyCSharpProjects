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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string[] Ogrenciler = { "Necati", "Sevgi", "Hüseyin", "Sedat", "Oya" };
        //int[,] Notlar = new int[5, 2]; //5 öğrencinin 2 şer notu = 10Not
        int[,] Notlar = { { 40, 60 }, { 70, 30 }, { 50, 80 }, { 90, 70 }, { 60, 80 } };

        private void Form1_Load(object sender, EventArgs e)
        {
            //MessageBox.Show(Notlar.Length.ToString());
            //MessageBox.Show("Satır Sayısı : " + Notlar.GetLength(0));
            //MessageBox.Show("Sütun Sayısı : " + Notlar.GetLength(1));
            //MessageBox.Show("Dizinin boyut Sayısı : " + Ogrenciler.Rank);
            //MessageBox.Show("Dizinin boyut Sayısı : " + Notlar.Rank);
            //MessageBox.Show("İlk Eleman : " + Notlar[0, 0]);
            //MessageBox.Show("Son Eleman : " + Notlar[4, 1]);
            //MessageBox.Show("Son Eleman : " + Notlar[Notlar.GetLength(0) - 1, Notlar.GetLength(1) - 1]);



            for (int i = 0; i < Notlar.GetLength(0); i++)
            {
                lbOgrenciler.Items.Add(Ogrenciler[i]);
                //lbNotlar1.Items.Add(Notlar[i, 0]);
                //lbNotlar2.Items.Add(Notlar[i, 1]);

                for (int j = 0; j < Notlar.GetLength(1) - 1; j++)
                {
                    lbNotlar1.Items.Add(Notlar[i, j]);
                    lbNotlar2.Items.Add(Notlar[i, j + 1]);
                }
            }
        }

        private void lbOgrenciler_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbNotlar1.SelectedIndex = lbOgrenciler.SelectedIndex;
            lbNotlar2.SelectedIndex = lbOgrenciler.SelectedIndex;
        }

        private void lbNotlar1_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbOgrenciler.SelectedIndex = lbNotlar1.SelectedIndex;
        }

        private void lbNotlar2_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbOgrenciler.SelectedIndex = lbNotlar2.SelectedIndex;
        }
    }
}
