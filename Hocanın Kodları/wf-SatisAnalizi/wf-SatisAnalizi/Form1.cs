using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wf_SatisAnalizi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //string[] Firmalar = string[3];
        string[] Firmalar = { "A Gıda", "B İnşaat", "C Otomotiv" };
        //double[,] Satislar = new double[3, 4];
        double[,] Satislar = { { 5600000, 4800000, 7200000, 6400000 }, { 34500000, 32250000, 44750000, 28500000 }, { 28500000, 45750000, 39250000, 35500000 } };
        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < Firmalar.Length; i++)
            {
                lvSatislar.Items.Add(Firmalar[i]);
                for (int j = 0; j < Satislar.GetLength(1); j++)
                {
                    lvSatislar.Items[i].SubItems.Add(Satislar[i, j].ToString());
                }
            }
        }
        private void lvSatislar_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvSatislar.SelectedItems.Count > 0)
            {
                double Toplam = 0;
                for (int i = 1; i <= lvSatislar.Columns.Count - 1; i++)
                {
                    Toplam += Convert.ToDouble(lvSatislar.SelectedItems[0].SubItems[i].Text);
                }
                double Ortalama = Toplam / (lvSatislar.Columns.Count - 1);
                //double Ortalama = Toplam / Satislar.GetLength(1);
                //lblMesaj.Text = "Seçilen Firma : " + lvSatislar.SelectedItems[0].Text;
                lblMesaj.Text = "Seçilen Firma : " + lvSatislar.SelectedItems[0].SubItems[0].Text + ", Satış Ortalaması : " + string.Format("{0:c}", Ortalama);
            }
        }
    }
}
