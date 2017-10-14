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
    public partial class frmHesapAcilisi : Form
    {
        public frmHesapAcilisi()
        {
            InitializeComponent();
        }
        Random rnd = new Random();
        private void frmHesapAcilisi_Load(object sender, EventArgs e)
        {
            this.Top = 55;
            this.Left = 15;
            cbHesapTurleri.SelectedIndex = 0;
            lblTarih.Text = DateTime.Now.ToShortDateString();
            SonIDBul();
            HesapVarmi();           
        }
        private void SonIDBul()
        {
            StreamWriter DosyaOlustur = new StreamWriter("HesapKartlari.txt", true);
            DosyaOlustur.Close();

            StreamReader DosyaOku = new StreamReader("HesapKartlari.txt");
            string okunan = DosyaOku.ReadLine(); //ilk satırı okur.
            if (okunan == null)
                lblHesapID.Text = "1";
            else
            {
                //string[] Degerler = new string[okunan.Split(';').Length];
                while (okunan != null)
                {
                    string[] Degerler = okunan.Split(';');
                    //Degerler = okunan.Split(';'); //Split metodu; string bilgileri belirtilen karaktere göre parçalar ayırır, sonucu string bir dizi olarak verir.
                    lblHesapID.Text = (Convert.ToInt32(Degerler[0]) + 1).ToString();
                    okunan = DosyaOku.ReadLine();
                }
                //lblHesapID.Text = (Convert.ToInt32(Degerler[0]) + 1).ToString(); //Sadece son kaydın ID'sini 1 artırır.
                DosyaOku.Close();
            }
        }
        private bool HesapNoOlustur()
        {
            lblHesapNo.Text = "ACC" + rnd.Next(1000, 10000);
            StreamReader DosyaOku = new StreamReader("HesapKartlari.txt");
            string okunan = DosyaOku.ReadLine(); //ilk satırı okur.
            while (okunan != null)
            {
                string[] Degerler = okunan.Split(';');
                if(Degerler[1] == lblHesapNo.Text)
                {
                    //Bu hesapno önceden kullanılmış
                    DosyaOku.Close();
                    return true;
                   /* HesapNoOlustur();*/ //Kendi kendini çağıran metotlar (recursive methods)
                }
                okunan = DosyaOku.ReadLine();
            }
            DosyaOku.Close();
            return false;
        }
        private void HesapVarmi()
        {
            bool Varmi = false;
            do
            {
                Varmi = HesapNoOlustur();  //Bu metot; kullanılmamış yeni bir hesapno bulununcaya kadar true döndürüyor, bu nedenle do while çalışmaya devam ediyor. Ancak false geldiğinde işlem tamamlanıyor ve döngüden çıkılıyor.
            } while (Varmi);
        }
        private void btnHesapAc_Click(object sender, EventArgs e)
        {
            if(txtAdi.Text.Trim() != "" && txtSoyadi.Text.Trim() != "" && txtTCKNo.Text.Trim() != "")
            {
                StreamWriter DosyaEkle = new StreamWriter("HesapKartlari.txt", true);
                DosyaEkle.WriteLine(lblHesapID.Text + ";" + lblHesapNo.Text + ";" + lblTarih.Text + ";" + txtAdi.Text + ";" + txtSoyadi.Text + ";" + txtTCKNo.Text + ";" + txtBakiye.Text + ";" + cbHesapTurleri.SelectedItem.ToString());
                DosyaEkle.Close();

                StreamWriter HareketEkle = new StreamWriter("HesapHareketleri.txt", true);
                HareketEkle.WriteLine(lblHesapID.Text + ";" + lblHesapNo.Text + ";" + lblTarih.Text + ";" + txtBakiye.Text + ";" + "yatan");
                HareketEkle.Close();

                MessageBox.Show("Hesap açılışı tamamlandı.", "Hesap Açıldı");
                Temizle();
                SonIDBul();
                HesapVarmi();
            }
            else
            {
                MessageBox.Show("Zorunlu alanları boş bırakmayınız!", "Dikkat Eksik Bilgi!");
                txtAdi.Focus();
            }
        }
        private void Temizle()
        {
            txtAdi.Clear();
            txtSoyadi.Clear();
            txtTCKNo.Clear();
            txtBakiye.Text = "0";
            txtAdi.Focus();
        }
    }
}
