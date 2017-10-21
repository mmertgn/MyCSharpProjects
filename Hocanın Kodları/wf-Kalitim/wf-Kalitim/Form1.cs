using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wf_Kalitim
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //cCanli c = new cCanli();    //Abstract class'lar new ile nesneye dönüştürülemez. Miras alınabilir.
            //c.Beslenme = "yakıt";

            cHayvan h = new cHayvan();
            h.Beslenme = "ot";
            MessageBox.Show("Hoşgeldin " + h.YeniDogan());

            cBitki b = new cBitki();
            b.Beslenme = "gübre";

            cInsan i = new cInsan();
            i.Dusunur = "ara sıra";
            MessageBox.Show("Hoşgeldin " + i.YeniDogan());
            //cKisi k = new wf_Kalitim.cKisi(); 
            //k.Ad = "Ali";
        }
    }
    //class cKisi : cInsan      //Sealed class'lardan miras alınamaz. New ile çoğaltılabilirler.
    //{
    //    public string Ad;
    //    public string Soyad;
    //}
}
