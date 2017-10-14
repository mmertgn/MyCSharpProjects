using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wf_Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        bool ilkgiris = true;
        string sonislem = "";
        double arasonuc = 0, hafiza = 0;

        bool NegatifMi = false;


        private void btn1_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            if (ilkgiris)
            {
                txtGiris.Text = btn.Text;
                ilkgiris = false;
            }
            else
            {
                txtGiris.Text += btn.Text;
            }
        }

        private void btn_Islem(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (ilkgiris)
            {
                sonislem = btn.Text;
                txtIslem.Text = txtIslem.Text.Substring(0, txtIslem.Text.Length - 1) + btn.Text;
            }
            else
            {
                ilkgiris = true;
                txtIslem.Text = txtIslem.Text + txtGiris.Text + btn.Text;
                if (sonislem == "")
                {
                    arasonuc = Convert.ToDouble(txtGiris.Text);
                }
                else
                {
                    arasonuc = Hesapla(arasonuc, Convert.ToDouble(txtGiris.Text), sonislem);
                }
                txtGiris.Text = arasonuc.ToString();
                sonislem = btn.Text;
            }

        }

        private void btnEsittir_Click(object sender, EventArgs e)
        {
            if (sonislem == "")
            {
                arasonuc = Convert.ToDouble(txtGiris.Text);
            }
            else
            {
                arasonuc = Hesapla(arasonuc, Convert.ToDouble(txtGiris.Text), sonislem);
                txtGiris.Text = arasonuc.ToString();
                txtIslem.Clear();
                arasonuc = 0;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            txtGiris.Text = txtGiris.Text.Substring(0, txtGiris.Text.Length - 1);
            if (txtGiris.Text == "")
            {
                txtGiris.Text = "0";
            }
        }

        private double Hesapla(double ilksayi, double sonsayi, string islem)
        {
            double sonuc = 0;
            if (islem == "+")
            {
                sonuc = ilksayi + sonsayi;
            }
            else if (islem == "-")
            {
                sonuc = ilksayi - sonsayi;
            }
            else if (islem == "*")
            {
                sonuc = ilksayi * sonsayi;
            }
            else if (islem == "/")
            {
                sonuc = ilksayi / sonsayi;
            }
            return sonuc;
        }

        private void btnCE_Click(object sender, EventArgs e)
        {
            txtGiris.Text = "0";
            ilkgiris = true;
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            txtGiris.Text = "0";
            ilkgiris = true;
            txtIslem.Clear();
            sonislem = "";
            arasonuc = 0;
        }

        private void btnArtiEksi_Click(object sender, EventArgs e)
        {
            if (NegatifMi)
            {
                txtGiris.Text = (Convert.ToDouble(txtGiris.Text) * -1).ToString();
                NegatifMi = false;
            }
            else
            {
                txtGiris.Text = "-" + txtGiris.Text;
                NegatifMi = true;
            }


        }

        private void btnKareKok_Click(object sender, EventArgs e)
        {
            txtGiris.Text = Convert.ToString(Math.Sqrt(Convert.ToDouble(txtGiris.Text)));
        }

        private void btnBirBoluX_Click(object sender, EventArgs e)
        {
            txtGiris.Text = Convert.ToString(1 / Convert.ToDouble(txtGiris.Text));
        }

        private void btnMc_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (txtGiris.Text.Length == 0)
                txtGiris.Text = "0";
            switch (btn.Text)
            {
                case "MC":
                    label1.Visible = false;
                    hafiza = 0;
                    break;
                case "MR":
                    txtGiris.Text = hafiza.ToString();
                    break;
                case "MS":
                    label1.Visible = true;
                    hafiza = Convert.ToDouble(txtGiris.Text);
                    break;
                case "M+":
                    hafiza = hafiza + double.Parse(txtGiris.Text);
                    break;
                case "M-":
                    hafiza = hafiza - double.Parse(txtGiris.Text);
                    break;
            }
        }
    }
}
