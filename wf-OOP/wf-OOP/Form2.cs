using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wf_OOP
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            //cTelefon tel1 = new cTelefon();
            //tel1.Marka = "aPPlE";
            //MessageBox.Show("Marka : " + tel1.Marka);

            cTelefon tel2 = new cTelefon("Samsung", "S8");
            //MessageBox.Show(tel2.Marka + ", " + tel2.Model);
            //MessageBox.Show(tel2.AramaYap("05375136356"));
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            cTelefon tel3 = new cTelefon();
            MessageBox.Show(tel3.AramaYap(txtTelefon.Text));
            
        }

        private void btnGonder_Click(object sender, EventArgs e)
        {
            cTelefon tel3 = new cTelefon();
            MessageBox.Show(tel3.MesajGonder(txtTelefon.Text, txtMesaj.Text));
        }
    }
}
