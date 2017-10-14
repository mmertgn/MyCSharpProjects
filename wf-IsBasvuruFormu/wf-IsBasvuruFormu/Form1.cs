using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wf_IsBasvuruFormu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string ad, soyad, tc, telefon, adres, egitim, notlar;

        private void rbErkek_CheckedChanged(object sender, EventArgs e)
        {
            gbAskerlik.Enabled = true;
        }

        private void rbKadin_CheckedChanged(object sender, EventArgs e)
        {
            gbAskerlik.Enabled = false;
        }

        int Yas;

        private void Form1_Load(object sender, EventArgs e)
        {
            cbEgitim.SelectedIndex = 0;
        }

        private void btnBasvur_Click(object sender, EventArgs e)
        {


            if (txtAdi.Text.Trim() == "" || txtSoyadi.Text == "" || txtTCKN.Text == "" || txtTelefon.Text == "(   )   -  -")
            {
                MessageBox.Show("Öncelikle zorunlu bilgileri girmelisiniz!");
            }
            else
            {
                Yas = DateTime.Now.Year - dtDTarih.Value.Year;
                egitim = cbEgitim.SelectedItem.ToString().ToLower();
                if (Yas >= 20 && Yas <= 35 && (egitim == "önlisans" || egitim == "lisans" || egitim == "yükseklisans") && (cbxIngilizce.Checked == true && (cbxRusca.Checked == true || cbxArapca.Checked == true)) && (cbxYazilim.Checked == true && cbxOffice.Checked == true && (cbxWebTasarim.Checked == true || cbxVeritabani.Checked == true)) && (rbKadin.Checked == true || ((rbErkek.Checked == true) && (rbYapildi.Checked == true || rbTecilli.Checked == true))))
                {
                    MessageBox.Show("Sayın " + txtAdi.Text + " " + txtSoyadi.Text + " Başvurunuz Başarıyla Alınmıştır. Sizinle En kısa Sürede İletişime Geçilecektir.");
                }
                else
                {
                    MessageBox.Show("Başvurunuz Red Edildi");
                }


                //    if (Yas >= 20 && Yas <= 35)
                //    {
                //        egitim = cbEgitim.SelectedItem.ToString().ToLower();
                //        if (egitim == "önlisans" || egitim == "lisans" || egitim == "yükseklisans")
                //        {
                //            if (cbxIngilizce.Checked == true && (cbxRusca.Checked == true || cbxArapca.Checked == true))
                //            {
                //                if (cbxYazilim.Checked == true && cbxOffice.Checked == true && (cbxWebTasarim.Checked == true || cbxVeritabani.Checked == true))
                //                {
                //                    if (rbKadin.Checked == true)
                //                    {
                //                        MessageBox.Show("Sayın " + txtAdi.Text + " " + txtSoyadi.Text + "Başvurunuz Başarıyla Alınmıştır. Sizinle En kısa Sürede İletişime Geçilecektir.");
                //                    }
                //                    else if (rbErkek.Checked == true)
                //                    {
                //                        if (rbYapilmadi.Checked == true)
                //                        {
                //                            MessageBox.Show("Askerlik Durumunuz Sebebiyle Başvurunuz Red Edildi.");
                //                        }
                //                        else
                //                        {
                //                            MessageBox.Show("Sayın " + txtAdi.Text + " " + txtSoyadi.Text + "Başvurunuz Başarıyla Alınmıştır. Sizinle En kısa Sürede İletişime Geçilecektir.");
                //                        }
                //                    }
                //                }
                //                else
                //                {
                //                    MessageBox.Show("Bilgisayar Bilgilerinizin Eksikliği Sebebi İle Başvurunuz Red Edildi");
                //                }
                //            }
                //            else
                //            {
                //                MessageBox.Show("Yabancı Dil Bilgilerinizin Eksikliği Sebebi İle Başvurunuz Red Edildi");
                //            }
                //        }
                //        else
                //        {
                //            MessageBox.Show("Eğitim Durumunuz Sebebi İle Başvurunuz Red Edildi");
                //        }
                //    }
                //    else
                //    {
                //        MessageBox.Show("Yaşınız Sebebi İle Başvurunuz Red Edildi");
                //    }
                }

            }
        }
    }
