using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wf_Methods
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            //Girilen bilgiler kayıt edilir.
            EkranaGoruntule("Bilgiler kayıt edildi.");
            Temizle();
        }

        private void btnDegistir_Click(object sender, EventArgs e)
        {
            //Mevcut bilgiler değiştirildi.
            EkranaGoruntule("Bilgiler değiştirildi.");
            Temizle();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            //Mevcut bilgiler silindi.
            EkranaGoruntule("Bilgiler silindi.");
            Temizle();
        }
        private void Temizle()
        {
            txtAdi.Clear();
            txtSoyadi.Clear();
            txtTelefon.Clear();
            txtAdres.Clear();
            txtAdi.Focus();
        }
        private void EkranaGoruntule(string Mesaj)
        {
            MessageBox.Show(Mesaj);
        }
    }
}
