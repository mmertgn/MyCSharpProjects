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
    public partial class frmHesapDokumu : Form
    {
        public frmHesapDokumu()
        {
            InitializeComponent();
        }

        private void btnHesapAra_Click(object sender, EventArgs e)
        {
            lvHesapHareketleri.Items.Clear();
            HesapBul();
        }

        private void HesapBul()
        {
            string[] HesapParcalari = HesapBilgileriGoster();
            HesapDokumuGoster(HesapParcalari);
            ToplamlariGoster();
        }
        private string[] HesapBilgileriGoster()
        {
            HesapBilgilerTemizle();
            StreamReader HesapKartlariOku = new StreamReader("HesapKartlari.txt");
            string satir = HesapKartlariOku.ReadLine();
            string[] HesapParcalari = new string[satir.Split(';').Length];
            while (satir != null)
            {
                HesapParcalari = satir.Split(';');
                if (HesapParcalari[1] == txtHesapAra.Text.ToUpper())
                {
                    break;
                }
                satir = HesapKartlariOku.ReadLine();
            }
            HesapKartlariOku.Close();
            txtAd.Text = HesapParcalari[3];
            txtSoyad.Text = HesapParcalari[4];
            txtTCKN.Text = HesapParcalari[5];
            txtAcilisTarihi.Text = HesapParcalari[2];
            txtHesapTuru.Text = HesapParcalari[7];
            return HesapParcalari;
        }

        private void HesapBilgilerTemizle()
        {
            txtAd.Clear();
            txtSoyad.Clear();
            txtTCKN.Clear();
            txtAcilisTarihi.Clear();
            txtHesapTuru.Clear();
        }

        private void HesapDokumuGoster(string[] HesapParcalari)
        {
            StreamReader HesapHareketleriOku = new StreamReader("HesapHareketleri.txt");
            string satir = HesapHareketleriOku.ReadLine();
            string[] HareketParcalari = new string[satir.Split(';').Length];
            int sayac = 0;
            while (satir != null)
            {
                HareketParcalari = satir.Split(';');

                if (HareketParcalari[1] == HesapParcalari[1])
                {
                    lvHesapHareketleri.Items.Add(HareketParcalari[0]);
                    for (int i = 1; i < HareketParcalari.Length; i++)
                    {
                        lvHesapHareketleri.Items[sayac].SubItems.Add(HareketParcalari[i]);
                    }
                    sayac++;
                }
                satir = HesapHareketleriOku.ReadLine();
            }
            HesapHareketleriOku.Close();
            
        }
        
        private void ToplamlariGoster()
        {
            double YatirilanPara = 0, CekilenPara = 0, Bakiye = 0;
            for (int i = 0; i < lvHesapHareketleri.Items.Count; i++)
            {
                if (lvHesapHareketleri.Items[i].SubItems[4].Text == "Para Yatırma")
                {
                    YatirilanPara += Convert.ToDouble(lvHesapHareketleri.Items[i].SubItems[3].Text);
                }
                else if (lvHesapHareketleri.Items[i].SubItems[4].Text == "Para Çekme")
                {
                    CekilenPara += Convert.ToDouble(lvHesapHareketleri.Items[i].SubItems[3].Text);
                }
            }
            Bakiye = YatirilanPara - CekilenPara;
            txtToplamCekilen.Text = CekilenPara.ToString();
            txtToplamYatan.Text = YatirilanPara.ToString();
            txtBakiye.Text = Bakiye.ToString();
        }
    }
}
