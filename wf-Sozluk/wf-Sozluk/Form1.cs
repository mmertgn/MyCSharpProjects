using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wf_Sozluk
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string[] Turkceler = { "yazılım", "donanım", "öğrenci", "öğretmen", "nesne", "pencere", "kalem", "sınıf", "duvar", "saat", "bilgisayar", "fare", "masa" };
        string[] Ingilizceler = { "software", "hardware", "student", "teacher", "object", "window", "pencil", "class", "wall", "clock", "computer", "mouse", "table" };

        private void Form1_Load(object sender, EventArgs e)
        {
            if (rbTurkToIng.Checked == true)
            {
                for (int i = 0; i < Turkceler.Length; i++)
                {
                    lbKelimeler.Items.Add(Turkceler[i]);
                }

                //lbKelimeler.Items.AddRange(Turkceler); //Addrange ile tek seferde koleksiyon yüklenebilir.
            }
        }

        private void btnBul_Click(object sender, EventArgs e)
        {
            bool bulundu = false;
            if (rbTurkToIng.Checked == true)
            {
                for (int i = 0; i < Turkceler.Length; i++)
                {
                    if (Turkceler[i] == txtTurkce.Text.ToLower())
                    {
                        txtIngilizce.Text = Ingilizceler[i];
                        bulundu = true;
                        break;
                    }
                }

                if (bulundu == false)
                {
                    MessageBox.Show("Aradığınız Kelime Bulunamamıştır.");
                }
            }
            else if (rbIngToTurk.Checked == true)
            {
                for (int i = 0; i < Ingilizceler.Length; i++)
                {
                    if (Ingilizceler[i] == txtIngilizce.Text.ToLower())
                    {
                        txtTurkce.Text = Turkceler[i];
                        bulundu = true;
                        break;
                    }
                }

                if (bulundu == false)
                {
                    MessageBox.Show("Aradığınız Kelime Bulunamamıştır.");
                }
            }

        }

        private void rbIngToTurk_CheckedChanged(object sender, EventArgs e)
        {
            txtTurkce.ReadOnly = true;
            txtIngilizce.ReadOnly = false;
            txtIngilizce.Focus();
            txtIngilizce.Clear();
            txtTurkce.Clear();
            lbKelimeler.Items.Clear();
            for (int i = 0; i < Ingilizceler.Length; i++)
            {
                lbKelimeler.Items.Add(Ingilizceler[i]);
            }
        }

        private void rbTurkToIng_CheckedChanged(object sender, EventArgs e)
        {
            txtIngilizce.ReadOnly = true;
            txtTurkce.ReadOnly = false;
            txtTurkce.Focus();
            txtIngilizce.Clear();
            txtTurkce.Clear();
            lbKelimeler.Items.Clear();

            for (int i = 0; i < Turkceler.Length; i++)
            {
                lbKelimeler.Items.Add(Turkceler[i]);
            }
        }

        private void lbKelimeler_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (rbTurkToIng.Checked)
            {
                txtTurkce.Text = lbKelimeler.SelectedItem.ToString();
                txtIngilizce.Clear();
                btnBul_Click(sender, e); //Butona ait fonksiyon çağrıldı
            }
            else if (rbIngToTurk.Checked)
            {
                txtIngilizce.Text = lbKelimeler.SelectedItem.ToString();
                txtTurkce.Clear();
                btnBul_Click(sender, e);
            }
        }
    }
}
//nergiz.hocazade@wissenakademi.com
//erkan.hoyman@wissenakademi.com