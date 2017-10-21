using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
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
        public static string hesapID;
        public static string hesapNo;
        Font fntBaslik = new Font("Times New Roman", 16, FontStyle.Bold);
        Font fntIcerik = new Font("Times New Roman", 12, FontStyle.Regular);
        SolidBrush sb = new SolidBrush(Color.Black);

        public void btnHesapAra_Click(object sender, EventArgs e)
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

        private void btnParaIslemleri_Click(object sender, EventArgs e)
        {
            if (txtHesapAra.Text.Trim() != "")
            {

                frmParaIslemleri frm = new frmParaIslemleri();
                //frm.txtHesapID.Text = lvHesapHareketleri.Items[0].SubItems[0].Text;
                //frm.txtHesapNo.Text = lvHesapHareketleri.Items[0].SubItems[1].Text;
                hesapID = lvHesapHareketleri.Items[0].SubItems[0].Text;
                hesapNo = lvHesapHareketleri.Items[0].SubItems[1].Text;
                frm.veriCek(hesapID, hesapNo, txtBakiye.Text);
                frm.ShowDialog(); // Paraişlemleri formu kapandığında kod buraya geri döner bu sayede tekrar ekranı tekrar yenileme işlemini bir alt satırda yapabilirim
                btnHesapAra_Click(sender, e);
            }
        }
        int k = 0;
        private void pdocHareketler_PrintPage(object sender, PrintPageEventArgs e)
        {
            StringFormat fmt = new StringFormat();
            e.Graphics.DrawString("Müşteri : " + txtAd.Text + " " + txtSoyad.Text, fntBaslik, sb, 50, 80);
            e.Graphics.DrawString("Hesap No : " + txtHesapAra.Text.ToUpper(), fntBaslik, sb, 50, 100);
            e.Graphics.DrawString("Tarih : " + DateTime.Now.ToShortDateString(), fntBaslik, sb, 580, 80);
            e.Graphics.DrawString("Hesap Hareketleri", fntBaslik, sb, 300, 140);

            e.Graphics.DrawString("ID\t Hesap No\t İşlem Tarihi\t İşlem Tutarı\t İşlem Türü\t", fntIcerik, sb, 100, 200);
            e.Graphics.DrawString("-------------------------------------------------------------------------------", fntBaslik, sb, 100, 230);
            int EksenY = 260;
            for (int i = k; i < lvHesapHareketleri.Items.Count; i++)
            {
                e.Graphics.DrawString(lvHesapHareketleri.Items[i].SubItems[0].Text + "\t " + lvHesapHareketleri.Items[i].SubItems[1].Text + "\t\t " + lvHesapHareketleri.Items[i].SubItems[2].Text + "\t " + lvHesapHareketleri.Items[i].SubItems[3].Text + " ₺" + "\t\t " + lvHesapHareketleri.Items[i].SubItems[4].Text + "\t", fntIcerik, sb, 100, EksenY);
                EksenY += 30;
                k++;
                if (i % 26 == 0 && i != 0)
                {
                    e.HasMorePages = true;
                    return;
                }
                else
                {
                    e.HasMorePages = false;
                }
            }

            e.Graphics.DrawString("-------------------------------------------------------------------------------", fntBaslik, sb, 100, EksenY);
            e.Graphics.DrawString("Toplam Yatırılan : " + txtToplamYatan.Text + " ₺", fntBaslik, sb, 550, EksenY + 30);
            e.Graphics.DrawString("Toplam Çekilen : " + txtToplamCekilen.Text + " ₺", fntBaslik, sb, 550, EksenY + 60);
            e.Graphics.DrawString("Toplam Bakiye : " + txtBakiye.Text + " ₺", fntBaslik, sb, 550, EksenY + 90);
        }

        private void btnYazdir_Click(object sender, EventArgs e)
        {
            k = 0;
            ppdHareketler.ShowDialog();
        }
    }
}
