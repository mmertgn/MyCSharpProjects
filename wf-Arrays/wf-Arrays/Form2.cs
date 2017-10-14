using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wf_Arrays
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        //string[] ogrenciler = new string[6];
        string[] ogrenciler = { "Oya", "Vedat", "Hasan", "Neşe", "Hüseyin", "Merve" };

        private void Form2_Load(object sender, EventArgs e)
        {
            MessageBox.Show("İlk Eleman : " + ogrenciler[0]);
            MessageBox.Show("Son Eleman : " + ogrenciler[ogrenciler.Length - 1]);
        }

        private void btnYukle_Click(object sender, EventArgs e)
        {
            lbOgrenciler.Items.Clear();
            for (int i = 0; i < ogrenciler.Length; i++)
            {
                lbOgrenciler.Items.Add(ogrenciler[i]);
            }


        }

        private void btnYukleForeach_Click(object sender, EventArgs e)
        {
            lbOgrenciler.Items.Clear();
            foreach (string ogrenci in ogrenciler)
            {
                lbOgrenciler.Items.Add(ogrenci);
            }
        }
    }
}
