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
        private double Bakiye;
        private void frmParaIslemleri_Load(object sender, EventArgs e)
        {
            txtTarih.Text = DateTime.Now.ToShortDateString();
            //frmHesapDokumu frm = new frmHesapDokumu();
            cbIslemTuru.SelectedIndex = 1;
            //txtHesapNo.Text = frmHesapDokumu.hesapNo; //Hesapno ve hesapid static tanımlandığından bu şekilde erişilebilir
            //txtHesapID.Text = frmHesapDokumu.hesapID;
        }
        public void veriCek(string hesapId, string hesapNo,string gelenbakiye)
        {
            txtHesapID.Text = hesapId;
            txtHesapNo.Text = hesapNo;
            Bakiye = Convert.ToDouble(gelenbakiye);
        }

        private void btnTamam_Click(object sender, EventArgs e)
        {
            if (txtIslemTutari.Text.Trim() != "" || txtIslemTutari.Text.Trim() != "0")
            {
                StreamWriter DosyaYaz = new StreamWriter("HesapHareketleri.txt", true);
                if (cbIslemTuru.Text == "Para Yatırma")
                {
                    DosyaYaz.WriteLine(txtHesapID.Text + ";" + txtHesapNo.Text + ";" + txtTarih.Text + ";" + txtIslemTutari.Text + ";" + cbIslemTuru.Text);
                    MessageBox.Show("Para Yatırma işlemi başarıyla gerçekleştirildi.");
                }
                else
                {
                    if (Bakiye >= Convert.ToDouble(txtIslemTutari.Text))
                    {
                        DosyaYaz.WriteLine(txtHesapID.Text + ";" + txtHesapNo.Text + ";" + txtTarih.Text + ";" + txtIslemTutari.Text + ";" + cbIslemTuru.Text);
                        MessageBox.Show("Para Çekme işlemi başarıyla gerçekleştirildi.");
                    }
                    else
                    {
                        MessageBox.Show("İşlem Gerçekleştirilemedi Yetersiz Bakiye! Hesabınızdan Çekebileceğiniz Maksimum Miktar " + Bakiye + "TL'dir.");
                        txtIslemTutari.Focus();
                    }
                }
                DosyaYaz.Close();
                this.Close(); //Aktif form kapatılıyor, programın çalışması tekrar frmhesapdokumu'nde frm.showdialog satırına dönüp devam ediyor.
            }
            else
            {
                MessageBox.Show("Öncelikle bir tutar girmelisiniz!");
            }
        }
    }
}
