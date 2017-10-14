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
        /*int[,] Notlar = new int[5, 2];*/ //5 öğrencinin 2 şer notu = 10 Not
        int[,] Notlar = { { 40, 60 }, { 70, 30 }, { 50, 80 }, { 90, 70 }, { 60, 80 } };
        private void Form1_Load(object sender, EventArgs e)
        {
            //MessageBox.Show(Notlar.Length.ToString());
            //MessageBox.Show("Satır Sayısı : " + Notlar.GetLength(0));
            //MessageBox.Show("Sütun Sayısı : " + Notlar.GetLength(1));
            //MessageBox.Show("Dizinin boyut sayısı : " + Ogrenciler.Rank);
            //MessageBox.Show("Dizinin boyut sayısı : " + Notlar.Rank);
            //MessageBox.Show("İlk eleman : " + Notlar[0, 0]);
            //MessageBox.Show("Son eleman : " + Notlar[4, 1]);
            //MessageBox.Show("Son eleman : " + Notlar[Notlar.GetLength(0) - 1, Notlar.GetLength(1) - 1]);

            for (int i = 0; i < Ogrenciler.Length; i++)
            {
                lbOgrenciler.Items.Add(Ogrenciler[i]);
                lbNot1.Items.Add(Notlar[i, 0]);
                lbNot2.Items.Add(Notlar[i, 1]);
            }
        }

        private void lbOgrenciler_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbNot1.SelectedIndex = lbOgrenciler.SelectedIndex;
            lbNot2.SelectedIndex = lbOgrenciler.SelectedIndex;
        }
        private void lbNot1_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbOgrenciler.SelectedIndex = lbNot1.SelectedIndex;
        }
        private void lbNot2_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbOgrenciler.SelectedIndex = lbNot2.SelectedIndex;
        }
    }
}
