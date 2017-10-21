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

namespace wf_Pakbank
{
    public partial class frmParaIslemleri : Form
    {
        public frmParaIslemleri()
        {
            InitializeComponent();
        }

        private void frmParaIslemleri_Load(object sender, EventArgs e)
        {
            cbIslemTurleri.SelectedIndex = 1;
            lblTarih.Text = DateTime.Now.ToShortDateString();
            //frmHesapDokumu frm = new frmHesapDokumu();
            //public static tanımlanan değişkenlere, New ile class'ın örneği oluşturulmadan erişilebilir (class.degisken) 
            //lblHesapID.Text = frmHesapDokumu.hesapID;
            //lblHesapNo.Text = frmHesapDokumu.hesapNo;
        }
        public void HesapBilgileriAl(string HesapID, string HesapNo)
        {
            lblHesapID.Text = HesapID;
            lblHesapNo.Text = HesapNo;
        }
        private void btnTamam_Click(object sender, EventArgs e)
        {
            if(txtTutar.Text.Trim() == "" || txtTutar.Text == "0")
            {
                MessageBox.Show("Öncelikle bir tutar bilgisi girilmelidir!");
                txtTutar.Focus();
            }
            else if(cbIslemTurleri.SelectedItem.ToString() == "cekilen" && Convert.ToDouble(txtTutar.Text) > frmHesapDokumu.bakiye)
            {
                MessageBox.Show("Hesabınızda " + frmHesapDokumu.bakiye + " TL. bulunmaktadır.", "Yetersiz Bakiye!");
                txtTutar.Focus();
            }else
            {
                StreamWriter HareketEkle = new StreamWriter("HesapHareketleri.txt", true);
                HareketEkle.WriteLine(lblHesapID.Text + ";" + lblHesapNo.Text + ";" + lblTarih.Text + ";" + txtTutar.Text + ";" + cbIslemTurleri.SelectedItem.ToString());
                HareketEkle.Close();

                MessageBox.Show("Para İşlemleri tamamlandı.", "Kayıt yapıldı.");
                this.Close(); //Aktif form (frmParaIslemleri) kapatılıyor, programın çalışması tekrar frmHesapDokumu'nde frm.ShowDialog() satırına dönüyor.
            }
        }
    }
}
