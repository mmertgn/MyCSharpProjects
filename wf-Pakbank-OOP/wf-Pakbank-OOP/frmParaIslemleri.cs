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
    public partial class frmParaIslemleri : Form
    {
        public frmParaIslemleri()
        {
            InitializeComponent();
        }

        private void frmParaIslemleri_Load(object sender, EventArgs e)
        {
            cbIslemTuru.SelectedIndex = 1;
            txtTarih.Text = DateTime.Now.ToShortDateString();
        }

        public void HesapBilgileriAl(string HesapID, string HesapNo)
        {
            txtHesapID.Text = HesapID;
            txtHesapNo.Text = HesapNo;
        }

        private void btnTamam_Click(object sender, EventArgs e)
        {
            if (txtIslemTutari.Text.Trim() == "" || txtIslemTutari.Text == "0")
            {
                MessageBox.Show("Öncelikle bir tutar bilgisi girilmelidir!");
                txtIslemTutari.Focus();
            }
            else if (cbIslemTuru.SelectedItem.ToString() == "Para Çekme" && Convert.ToDouble(txtIslemTutari.Text) > frmHesapDokumu.bakiye)
            {
                MessageBox.Show("Hesabınızda " + frmHesapDokumu.bakiye + " TL. bulunmaktadır.", "Yetersiz Bakiye!");
                txtIslemTutari.Focus();
            }
            else
            {
                cHesapHareket hh = new cHesapHareket();
                hh.HesapId = Convert.ToInt32(txtHesapID.Text);
                hh.HesapNo = txtHesapNo.Text;
                hh.IslemTarihi = txtTarih.Text;
                hh.Bakiye = txtIslemTutari.Text;
                hh.IslemTuru = cbIslemTuru.SelectedItem.ToString();
                bool Sonuc = hh.HareketEkle(hh);
                if (Sonuc)
                {
                    MessageBox.Show(hh.IslemTuru + " İşlemleri başarıyla tamamlandı.", "Kayıt yapıldı.");
                }
            }
        }
    }
}
