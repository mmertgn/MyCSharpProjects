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
            //cCanli c = new cCanli(); //cCanli bizim için kavram yapısı olduğundan ona atama yapmak istemeyiz. O yüzden onu abstract class yaptık. Abstract classlar new ile nesneye dönüştürülemez. Miras alınabilir.
            //c.Beslenme = "yakıt";

            cHayvan h = new cHayvan();
            h.Beslenme = "ot";
            MessageBox.Show("Hoşgeldin " + h.YeniDogan());

            cBitki b = new cBitki();
            b.Beslenme = "su";

            cInsan insan = new cInsan();
            insan.Beslenme = "doner";
            MessageBox.Show("Hoşgeldin " + insan.YeniDogan());


            //cKisi k = new cKisi();
            //k.Ad = "Ali";

        }
    }


    //class cKisi : cInsan //sealead classtan miras alınamaz. New ile çoğaltılabilirler
    //{
    //    public string Ad;
    //    public string Soyad;
    //}
}
