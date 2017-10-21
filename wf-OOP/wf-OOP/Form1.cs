using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wf_OOP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Telefon tel1 = new Telefon();
            tel1.Marka = "Apple";
            tel1.Fiyat = 4000;
            MessageBox.Show("Marka : " + tel1.Marka + ", Fiyat : " + tel1.Fiyat);
        }
    }

    class Telefon
    {
        public string Marka;
        public string Model;
        public string Islemci;
        public string Hafiza;
        public string Ekran;
        public string Kamera;
        public double Fiyat;

    }
}
