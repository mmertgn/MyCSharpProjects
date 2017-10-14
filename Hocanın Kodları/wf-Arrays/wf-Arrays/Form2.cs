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
        //string[] Ogrenciler = new string[6];
        string[] Ogrenciler = { "Oya", "Vedat", "Hasan", "Neşe", "Hüseyin", "Merve" };
        private void Form2_Load(object sender, EventArgs e)
        {
            MessageBox.Show("İlk eleman : " + Ogrenciler[0]);
            MessageBox.Show("Son eleman : " + Ogrenciler[Ogrenciler.Length - 1]);
        }
        private void btnYukle_Click(object sender, EventArgs e)
        {
            lbOgrenciler.Items.Clear();
            //for (int i = 0; i < Ogrenciler.Length; i++)
            //{
            //    lbOgrenciler.Items.Add(Ogrenciler[i]);
            //}
            foreach (string o in Ogrenciler)
            {
                lbOgrenciler.Items.Add(o);
            }
        }
    }
}
