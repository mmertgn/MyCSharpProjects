using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wf_TextYazmaOkuma
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnYaz_Click(object sender, EventArgs e)
        {
            //Streamwriter ile üzerine yazıcak, her kullanıldığında baştan yazar
            if (txtSatir.Text.Trim() != "")
            {
                StreamWriter DosyaYaz = new StreamWriter("Metin.txt");
                DosyaYaz.WriteLine(txtSatir.Text);
                DosyaYaz.Close();
                txtSatir.Clear();
            }
            else
            {
                MessageBox.Show("Öncelikle bir metin girmelisiniz!");
            }
            txtSatir.Focus();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            //Streamwriter ile üzerine yazıcak, her kullanıldığında sonuna yazar
            if (txtSatir.Text.Trim() != "")
            {
                StreamWriter DosyaEkle = new StreamWriter("Metin.txt", true);
                DosyaEkle.WriteLine(txtSatir.Text);
                DosyaEkle.Close();
                txtSatir.Clear();
            }
            else
            {
                MessageBox.Show("Öncelikle bir metin girmelisiniz!");
            }

            txtSatir.Focus();
        }

        private void btnOku_Click(object sender, EventArgs e)
        {
            //Tek satır oku,txtbox da göster
            StreamReader DosyaOku = new StreamReader("Metin.txt");
            txtMetin.Text = DosyaOku.ReadLine();
            txtMetin.Text += "\n" + DosyaOku.ReadLine();
            DosyaOku.Close();
        }

        private void btnHepsiniOku_Click(object sender, EventArgs e)
        {
            //Butona basıldığında readtoend kullanmadan hepsini okusun
            //txtMetin.Clear();
            ////Tüm satırları oku,txtbox da göster
            //StreamReader DosyaOku = new StreamReader("Metin.txt");
            //txtMetin.Text = DosyaOku.ReadToEnd();
            //DosyaOku.Close();

            StreamReader DosyaOku = new StreamReader("Metin.txt");
            string okunan = DosyaOku.ReadLine();
            while (okunan != null)
            {
                txtMetin.Text += okunan + "\n";
                okunan = DosyaOku.ReadLine();
            }
            DosyaOku.Close();
        }
    }
}
