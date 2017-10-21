using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wfUcBoyutlu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string[] Ogrenciler = new string[3] { "Ali", "Oya", "Neşe" };
        string[] Dersler = new string[4] { "Matematik", "Fizik", "Kimya", "Tarih" };
        int[,,] Notlar = new int[3, 4, 1] { { { 50 }, { 50 }, { 50 }, { 50 } }, { { 40 }, { 40 }, { 40 }, { 25 } }, { { 25 }, { 35 }, { 78 }, { 98 } } };
        private void Form1_Load(object sender, EventArgs e)
        {
            int ortalama = 0, toplam = 0;
            lvNotlar.Columns.Add("Öğrenciler");
            for (int i = 0; i < Dersler.Length; i++)
            {
                lvNotlar.Columns.Add(Dersler[i]);
            }
            lvNotlar.Columns.Add("Ortalama : ");
            lvNotlar.View = View.Details;

            for (int i = 0; i < Notlar.GetLength(0); i++)
            {
                lvNotlar.Items.Add(Ogrenciler[i]);
                for (int j = 0; j < Notlar.GetLength(1); j++)
                {
                    for (int k = 0; k < Notlar.GetLength(2); k++)
                    {
                        lvNotlar.Items[i].SubItems.Add(Convert.ToString(Notlar[i,j,k]));
                        toplam = toplam + Notlar[i, j, k];
                    }
                }
                ortalama = toplam / Notlar.GetLength(1);
                lvNotlar.Items[i].SubItems.Add(ortalama.ToString());
                toplam = 0;
            }
        }
    }
}
