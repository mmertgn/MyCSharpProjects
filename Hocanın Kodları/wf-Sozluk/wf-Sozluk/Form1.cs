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
        string[] Turkceler = { "yazılım", "donanım", "öğrenci", "öğretmen", "nesne", "pencere", "kalem", "sınıf", "duvar", "saat", "bilgisayar", "fare", "masa"};
        string[] Ingilizceler = { "software", "hardware", "student", "teacher", "object", "window", "pencil", "class", "wall", "clock", "computer", "mouse", "table" };
        private void Form1_Load(object sender, EventArgs e)
        {
            //foreach (string kelime in Turkceler)
            //{
            //    lbKelimeler.Items.Add(kelime);
            //}
            lbKelimeler.Items.AddRange(Turkceler);
        }
        private void btnBul_Click(object sender, EventArgs e)
        {
            if (rbTurkToIng.Checked && Turkceler.Contains(txtTurkce.Text.ToLower()))
            {
                for (int i = 0; i < Turkceler.Length; i++)
                {
                    if (txtTurkce.Text.ToLower() == Turkceler[i])
                    {
                        txtIngilizce.Text = Ingilizceler[i];
                        break;
                    }
                }
            }
            else if(rbIngToTurk.Checked && Ingilizceler.Contains(txtIngilizce.Text.ToLower()))
            {
                for (int i = 0; i < Ingilizceler.Length; i++)
                {
                    if (txtIngilizce.Text.ToLower() == Ingilizceler[i])
                    {
                        txtTurkce.Text = Turkceler[i];
                        break;
                    }
                }
            }
            else { MessageBox.Show("Aradığınız kelime sözlüğümüzde bulunmamaktadır!"); }
        }
        private void rbIngToTurk_CheckedChanged(object sender, EventArgs e)
        {
            lbKelimeler.Items.Clear();
            lbKelimeler.Items.AddRange(Ingilizceler);
            txtTurkce.Clear();
            txtIngilizce.Clear();
            txtTurkce.ReadOnly = true;
            txtIngilizce.ReadOnly = false;
            txtIngilizce.Focus();
        }
        private void rbTurkToIng_CheckedChanged(object sender, EventArgs e)
        {
            lbKelimeler.Items.Clear();
            lbKelimeler.Items.AddRange(Turkceler);
            txtTurkce.Clear();
            txtIngilizce.Clear();
            txtTurkce.ReadOnly = false;
            txtIngilizce.ReadOnly = true;
            txtTurkce.Focus();
        }
        private void lbKelimeler_DoubleClick(object sender, EventArgs e)
        {
            if (rbTurkToIng.Checked)
            {
                txtTurkce.Text = lbKelimeler.SelectedItem.ToString();
                txtIngilizce.Clear();
            }
            else
            {
                txtIngilizce.Text = lbKelimeler.SelectedItem.ToString();
                txtTurkce.Clear();
            }
            btnBul_Click(sender, e);
        }
    }
}
