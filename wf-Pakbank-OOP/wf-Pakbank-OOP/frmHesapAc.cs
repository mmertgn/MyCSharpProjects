using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wf_Pakbank_OOP
{
    public partial class frmHesapAc : Form
    {
        public frmHesapAc()
        {
            InitializeComponent();
        }

        private void btnHesapEkle_Click(object sender, EventArgs e)
        {

            if (txtAdi.Text.Trim() != "" && txtSoyadi.Text.Trim() != "" && txtTCKN.Text.Trim() != "")
            {
                cHesap h = new cHesap();
                h.HesapId = Convert.ToInt32(txtHesapID.Text);
                h.HesapNo = txtHesapNo.Text;
                h.HesapAcilisTarihi = txtTarih.Text;
                h.Adi = txtAdi.Text;
                h.Soyadi = txtSoyadi.Text;
                h.TCKN = txtTCKN.Text;
                h.IlkBakiye = Convert.ToDouble(txtBakiye.Text);
                h.HesapTuru = cbHesapTuru.Text;
                bool Sonuc = h.HesapAc(h);
                //bool Sonuc = h.HesapAc(Convert.ToInt32(txtHesapID.Text), txtHesapNo.Text, txtTarih.Text, txtAdi.Text, txtSoyadi.Text, txtTCKN.Text, Convert.ToDouble(txtBakiye.Text), cbHesapTuru.SelectedItem.ToString());
                if (Sonuc)
                {
                    cHesapHareket hareket = new cHesapHareket();
                    hareket.HesapId = Convert.ToInt32(txtHesapID.Text);
                    hareket.HesapNo = txtHesapNo.Text;
                    hareket.IslemTarihi = txtTarih.Text;
                    hareket.Bakiye = txtBakiye.Text;
                    hareket.IslemTuru = "Para Yatırma";
                    Sonuc = hareket.HareketEkle(hareket);
                    if (Sonuc)
                    {
                        MessageBox.Show("Hesap Açma İşlemi Başarıyla Gerçekleştirildi!");
                        Temizle();
                        txtHesapID.Text = h.HesapIDOlustur().ToString();
                        txtHesapNo.Text = h.HesapVarmi();
                    }
                }
                else
                {
                    MessageBox.Show("Hesap Açma İşlemi Gerçekleştirilemedi!");
                }
            }

        }

        private void frmHesapAc_Load(object sender, EventArgs e)
        {
            this.Top = 0;
            this.Left = 0;
            cbHesapTuru.SelectedIndex = 0;
            txtTarih.Text = DateTime.Now.ToShortDateString();
            cHesap h = new cHesap();
            txtHesapID.Text = h.HesapIDOlustur().ToString();
            txtHesapNo.Text = h.HesapVarmi();
        }
        private void Temizle()
        {
            txtAdi.Clear();
            txtSoyadi.Clear();
            txtTCKN.Clear();
            txtBakiye.Text = "0";
            txtAdi.Focus();
        }
    }
}
