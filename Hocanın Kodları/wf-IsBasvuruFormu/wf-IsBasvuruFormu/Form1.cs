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

        private void cbEgitim_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*MessageBox.Show(cbEgitim.SelectedIndex.ToString());*/  //Seçilen elemanın sıra numarasını (indeks) verir.
            /*MessageBox.Show(cbEgitim.SelectedItem.ToString());*/ //Seçili elemanın bilgisini verir.
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cbEgitim.SelectedIndex = 0;
        }
        private void btnBasvur_Click(object sender, EventArgs e)
        {
            if (txtAdi.Text.Trim() == "" || txtSoyadi.Text.Trim() == "" || txtTCKNo.Text.Trim() == "" || txtTelefon.Text == "(   )    -  -")
            {
                MessageBox.Show("Öncelikle zorunlu bilgileri girmelisiniz!");
                txtAdi.Focus();
            }
            else
            {
                int Yas = DateTime.Now.Year - dtpDogTarihi.Value.Year;
                if (Yas >= 20 && Yas <= 35 && (cbEgitim.SelectedItem.ToString() == "Ön Lisans" || cbEgitim.SelectedItem.ToString() == "Lisans" || cbEgitim.SelectedItem.ToString() == "Yüksek Lisans") && (cbxIng.Checked && (cbxRus.Checked || cbxArap.Checked)) && (cbxYaz.Checked && cbxOfis.Checked && (cbxVeri.Checked || cbxWeb.Checked)) && (rbKadin.Checked || (rbErkek.Checked && (rbYapildi.Checked || rbTecilli.Checked))))
                {
                    MessageBox.Show("Sn. " + txtAdi.Text + " " + txtSoyadi.Text + ", iş başvurunuz kabul edilmiştir.");
                }else { MessageBox.Show("Başvurunuz kabul edilememiştir!"); }

                //if(Yas < 20 || Yas > 35)
                //{
                //    MessageBox.Show("Yaşınız uygun değil!", "İş Başvurunuz kabul edilmedi!");
                //}
                //else if(cbEgitim.SelectedItem.ToString() == "Lise" || cbEgitim.SelectedItem.ToString() == "Doktora")
                //{
                //    MessageBox.Show("Eğitiminiz uygun değil!", "İş Başvurunuz kabul edilmedi!");
                //}
                //else if(cbxIng.Checked == false)
                //{
                //    MessageBox.Show("İngilizce bilmelisiniz!", "İş Başvurunuz kabul edilmedi!");
                //}
                //else if(cbxRus.Checked == false && cbxArap.Checked == false)
                //{
                //    MessageBox.Show("Rusça yada Arapça bilmelisiniz!", "İş Başvurunuz kabul edilmedi!");
                //}
                //else if(cbxYaz.Checked == false || cbxOfis.Checked == false)
                //{
                //    MessageBox.Show("Bilgisayar bilgisi yeterli değil!", "İş Başvurunuz kabul edilmedi!");
                //}
                //else if (cbxWeb.Checked == false && cbxVeri.Checked == false)
                //{
                //    MessageBox.Show("Bilgisayar bilgisi yeterli değil!", "İş Başvurunuz kabul edilmedi!");
                //}
                //else if(rbErkek.Checked && rbYapilmadi.Checked)
                //{
                //    MessageBox.Show("Askerlik durumunuz uygun değil!", "İş Başvurunuz kabul edilmedi!");
                //}
                //else
                //{
                //    MessageBox.Show("Sn. " + txtAdi.Text + " " + txtSoyadi.Text + ", iş başvurunuz kabul edilmiştir.");
                //}
            }
        }

        private void rbErkek_CheckedChanged(object sender, EventArgs e)
        {
            gbAskerlik.Enabled = true;
        }
        private void rbKadin_CheckedChanged(object sender, EventArgs e)
        {
            gbAskerlik.Enabled = false;
        }
    }
}
