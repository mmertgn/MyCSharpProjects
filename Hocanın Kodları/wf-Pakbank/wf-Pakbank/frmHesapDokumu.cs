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
        private void frmHesapDokumu_Load(object sender, EventArgs e)
        {
            this.Top = 55;
            this.Left = 15;
        }
        private void btnBul_Click(object sender, EventArgs e)
        {
            if(txtHesapNo.Text.Trim() != "")
            {
                HesapBilgileriGoster();
                HesapHareketleriGoster();
                ToplamlariGoster();
            }
        }
        private void HesapBilgileriGoster()
        {
            HesapBilgileriTemizle();
            StreamReader DosyaOku = new StreamReader("HesapKartlari.txt");
            string okunan = DosyaOku.ReadLine(); 
            while (okunan != null)
            {
                string[] Degerler = okunan.Split(';');
                if (Degerler[1] == txtHesapNo.Text)
                {
                    txtAdi.Text = Degerler[3];
                    txtSoyadi.Text = Degerler[4];
                    txtTCKNo.Text = Degerler[5];
                    txtAcilisTarihi.Text = Degerler[2];
                    txtHesapTuru.Text = Degerler[7];
                    break; //hesabı bulduktan sonra aramaya devam etmesin.
                }
                okunan = DosyaOku.ReadLine();
            }
            DosyaOku.Close();
        }
        private void HesapHareketleriGoster()
        {
            lvHareketler.Items.Clear();
            StreamReader DosyaOku = new StreamReader("HesapHareketleri.txt");
            string okunan = DosyaOku.ReadLine();
            int i = 0;
            while (okunan != null)
            {
                string[] Degerler = okunan.Split(';');
                if (Degerler[1] == txtHesapNo.Text)
                {
                    lvHareketler.Items.Add(Degerler[0]);
                    lvHareketler.Items[i].SubItems.Add(Degerler[1]);
                    lvHareketler.Items[i].SubItems.Add(Degerler[2]);
                    lvHareketler.Items[i].SubItems.Add(Degerler[3]);
                    lvHareketler.Items[i].SubItems.Add(Degerler[4]);
                    i++;
                }
                okunan = DosyaOku.ReadLine();
            }
            DosyaOku.Close();
        }
        private void ToplamlariGoster()
        {
            double TYatan = 0;
            double TCekilen = 0;
            for (int i = 0; i < lvHareketler.Items.Count; i++)
            {
                if(lvHareketler.Items[i].SubItems[4].Text == "yatan")
                {
                    TYatan += Convert.ToDouble(lvHareketler.Items[i].SubItems[3].Text);
                }
                else
                {
                    TCekilen += Convert.ToDouble(lvHareketler.Items[i].SubItems[3].Text);
                }
            }
            txtToplamYatan.Text = TYatan.ToString();
            txtToplamCekilen.Text = TCekilen.ToString();
            txtBakiye.Text = (TYatan - TCekilen).ToString();
        }
        private void HesapBilgileriTemizle()
        {
            txtAdi.Clear();
            txtSoyadi.Clear();
            txtTCKNo.Clear();
            txtAcilisTarihi.Clear();
            txtHesapTuru.Clear();
        }
    }
}
