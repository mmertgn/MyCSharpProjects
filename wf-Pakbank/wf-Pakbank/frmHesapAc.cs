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
    public partial class frmHesapAc : Form
    {
        public frmHesapAc()
        {
            InitializeComponent();
        }

        private void frmHesapAc_Load(object sender, EventArgs e)
        {
            this.Top = 55;
            this.Left = 15;
            cbHesapTuru.SelectedIndex = 0;
            txtTarih.Text = DateTime.Now.ToShortDateString();
            HesapIDOlustur();
            HesapNoOlustur();
        }

        private void HesapIDOlustur()
        {
            StreamWriter DosyaAc = new StreamWriter("HesapKartlari.txt", true);
            DosyaAc.Close();
            StreamReader DosyaOku = new StreamReader("HesapKartlari.txt");
            string satir = DosyaOku.ReadLine();
            if (satir == null)
            {
                txtHesapID.Text = "1";
            }
            else
            {
                string[] parcalar = new string[satir.Split(';').Length];
                while (satir != null)
                {
                    parcalar = satir.Split(';');
                    satir = DosyaOku.ReadLine();
                }
                txtHesapID.Text = Convert.ToString(Convert.ToDouble(parcalar[0]) + 1);
            }
            DosyaOku.Close();
        }
        Random rnd = new Random();
        private void HesapNoOlustur()
        {
            StreamReader DosyaOku = new StreamReader("HesapKartlari.txt");
            string satir = DosyaOku.ReadLine();
            string[] parcalar = new string[satir.Split(';').Length];
            bool Esitmi = true;

            if (satir == null)
            {
                txtHesapNo.Text = "ACC" + rnd.Next(1000, 10000);
            }
            else
            {
                string HesapNo = "ACC" + rnd.Next(1000, 10000);
                while (Esitmi)
                {
                    while (satir != null)
                    {
                        parcalar = satir.Split(';');
                        if (parcalar[1] == HesapNo)
                        {
                            Esitmi = true;
                            HesapNo = "ACC" + rnd.Next(1000, 10000);
                            DosyaOku.Close();
                            DosyaOku = new StreamReader("HesapKartlari.txt");
                            break;
                        }
                        else
                        {
                            Esitmi = false;
                        }
                        satir = DosyaOku.ReadLine();
                    }
                }
                
                txtHesapNo.Text = HesapNo;
            }
            DosyaOku.Close();
        }

        private void btnHesapEkle_Click(object sender, EventArgs e)
        {
            StreamWriter HesapKartlari = new StreamWriter("HesapKartlari.txt", true);
            if (txtAdi.Text.Trim() != "" && txtSoyadi.Text.Trim() != "" && txtTCKN.Text.Trim() != "")
            {
                HesapKartlari.WriteLine(txtHesapID.Text + ";"+ txtHesapNo.Text + ";"+ txtTarih.Text + ";"+ txtAdi.Text + ";"+ txtSoyadi.Text + ";"+ txtTCKN.Text + ";"+ txtBakiye.Text + ";"+ cbHesapTuru.Text);
                MessageBox.Show("Hesap Oluşturma İşlemi Başarıyla Gerçekleştirildi!");
                if (txtBakiye.Text.Trim() != "")
                {
                    StreamWriter HesapHareketleri = new StreamWriter("HesapHareketleri.txt", true);
                    HesapHareketleri.WriteLine(txtHesapID.Text + ";" + txtHesapNo.Text + ";" + txtTarih.Text + ";" + txtBakiye.Text + ";" + "Para Yatırma");
                    HesapHareketleri.Close();
                }
                
            }
            else
            {
                MessageBox.Show("Zorunlu alanları boş bırakmayınız!","Dikkat Eksik Bilgi!");
            }
            HesapKartlari.Close();
            Temizle();
        }

        private void Temizle()
        {
            HesapIDOlustur();
            HesapNoOlustur();
            txtAdi.Clear();
            txtSoyadi.Clear();
            txtBakiye.Clear();
            txtTCKN.Clear();

        }
    }
}
