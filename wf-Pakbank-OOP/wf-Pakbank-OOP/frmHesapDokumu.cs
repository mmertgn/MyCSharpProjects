using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wf_Pakbank_OOP
{
    public partial class frmHesapDokumu : Form
    {
        public frmHesapDokumu()
        {
            InitializeComponent();
        }
        public static string hesapID;
        public static string hesapNo;
        public static double bakiye;
        Font fntBaslik = new Font("Times New Roman", 16, FontStyle.Bold);
        Font fntDetay = new Font("Times New Roman", 12, FontStyle.Regular);
        SolidBrush sb = new SolidBrush(Color.Black);
        private void btnHesapAra_Click(object sender, EventArgs e)
        {
            if (txtHesapAra.Text.Trim() != "")
            {
                HesapBilgileriTemizle();
                HesapBilgileriGetir();
                HesapHareketleriGetir();
                ToplamlariGoster();
            }
        }

        private void HesapHareketleriGetir()
        {
            lvHesapHareketleri.Items.Clear();
            cHesapHareket hh = new cHesapHareket();
            hh.HesapHareketleriGoster(txtHesapAra.Text.ToUpper(),lvHesapHareketleri);
        }

        private void HesapBilgileriGetir()
        {
            cHesap h = new cHesap();
            h = h.HesapBilgileriGoster(txtHesapAra.Text.ToUpper());
            txtAd.Text = h.Adi;
            txtSoyad.Text = h.Soyadi;
            txtTCKN.Text = h.TCKN;
            txtHesapTuru.Text = h.HesapTuru;
            txtAcilisTarihi.Text = h.HesapAcilisTarihi;
        }

        private void HesapBilgileriTemizle()
        {
            txtAd.Clear();
            txtSoyad.Clear();
            txtTCKN.Clear();
            txtAcilisTarihi.Clear();
            txtHesapTuru.Clear();
        }

        private void frmHesapDokumu_Load(object sender, EventArgs e)
        {
            this.Top = 0;
            this.Left = 0;
        }

        public void ToplamlariGoster()
        {
            double TYatan = 0;
            double TCekilen = 0;
            for (int i = 0; i < lvHesapHareketleri.Items.Count; i++)
            {
                if (lvHesapHareketleri.Items[i].SubItems[4].Text == "Para Yatırma")
                {
                    TYatan += Convert.ToDouble(lvHesapHareketleri.Items[i].SubItems[3].Text);
                }
                else
                {
                    TCekilen += Convert.ToDouble(lvHesapHareketleri.Items[i].SubItems[3].Text);
                }
            }
            txtToplamYatan.Text = TYatan.ToString();
            txtToplamCekilen.Text = TCekilen.ToString();
            txtBakiye.Text = (TYatan - TCekilen).ToString();
        }

        private void btnParaIslemleri_Click(object sender, EventArgs e)
        {
            if (lvHesapHareketleri.Items.Count > 0)
            {
                frmParaIslemleri frm = new frmParaIslemleri();
                frm.HesapBilgileriAl(lvHesapHareketleri.Items[0].SubItems[0].Text, lvHesapHareketleri.Items[0].SubItems[1].Text);
                frm.ShowDialog();
                HesapHareketleriGetir();
                ToplamlariGoster();
            }
        }

        private void btnYazdir_Click(object sender, EventArgs e)
        {
            k = 0;
            ppdHareketler.ShowDialog();
        }
        int k = 0;
        private void pdocHareketler_PrintPage(object sender, PrintPageEventArgs e)
        {
            StringFormat fmt = new StringFormat();
            fmt.Alignment = StringAlignment.Near;
            e.Graphics.DrawString("Müşteri : " + txtAd.Text + " " + txtSoyad.Text, fntBaslik, sb, 100, 80);
            e.Graphics.DrawString(DateTime.Now.ToShortDateString(), fntBaslik, sb, 620, 80);
            e.Graphics.DrawString("HesapNo : " + txtHesapAra.Text, fntBaslik, sb, 100, 110);
            e.Graphics.DrawString("Hesap Hareketleri", fntBaslik, sb, 300, 150);
            e.Graphics.DrawString("ID \t  HesapNo \t İşlemTarihi \t  Tutar \t  İşlemTürü ", fntBaslik, sb, 100, 200);
            e.Graphics.DrawString("_________________________________________________________", fntBaslik, sb, 100, 205);
            int j = 0;
            for (int i = k; i < lvHesapHareketleri.Items.Count; i++)
            {
                e.Graphics.DrawString(lvHesapHareketleri.Items[i].SubItems[0].Text, fntDetay, sb, 100, 240 + j * 30, fmt);
                e.Graphics.DrawString(lvHesapHareketleri.Items[i].SubItems[1].Text, fntDetay, sb, 200, 240 + j * 30, fmt);
                e.Graphics.DrawString(lvHesapHareketleri.Items[i].SubItems[2].Text, fntDetay, sb, 370, 240 + j * 30, fmt);
                fmt.Alignment = StringAlignment.Far;
                e.Graphics.DrawString(lvHesapHareketleri.Items[i].SubItems[3].Text + " ₺", fntDetay, sb, 600, 240 + j * 30, fmt);
                fmt.Alignment = StringAlignment.Near;
                e.Graphics.DrawString(lvHesapHareketleri.Items[i].SubItems[4].Text, fntDetay, sb, 650, 240 + j * 30, fmt);
                j++;
                k++;
                if (i % 26 == 0 && i != 0)
                {
                    e.HasMorePages = true;  //Yeni sayfaya geçmesini sağlar.
                    return; //Tekrar PrintPage olayına gönderir.
                }
                else { e.HasMorePages = false; }
            }
            e.Graphics.DrawString("_________________________________________________________", fntBaslik, sb, 100, 230 + j * 30);
            j++;
            e.Graphics.DrawString("Toplam Yatan ", fntBaslik, sb, 370, 230 + j * 30);
            fmt.Alignment = StringAlignment.Far;
            e.Graphics.DrawString(string.Format("{0:#,##0}", Convert.ToDouble(txtToplamYatan.Text)), fntBaslik, sb, 600, 230 + j * 30, fmt);
            j++;
            e.Graphics.DrawString("Toplam Çekilen ", fntBaslik, sb, 370, 230 + j * 30);
            fmt.Alignment = StringAlignment.Far;
            e.Graphics.DrawString(string.Format("{0:#,##0}", Convert.ToDouble(txtToplamCekilen.Text)), fntBaslik, sb, 600, 230 + j * 30, fmt);
            j++;
            e.Graphics.DrawString("Bakiye ", fntBaslik, sb, 370, 230 + j * 30);
            fmt.Alignment = StringAlignment.Far;
            e.Graphics.DrawString(string.Format("{0:#,##0}", Convert.ToDouble(txtBakiye.Text))+" ₺", fntBaslik, sb, 600, 230 + j * 30, fmt);
            //e.Graphics.DrawString(string.Format("{0:c}", Convert.ToDouble(txtBakiye.Text)), fntBaslik, sb, 600, 230 + j * 30, fmt);

        }
    }
}
