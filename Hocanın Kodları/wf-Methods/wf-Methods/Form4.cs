using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wf_Methods
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            int a;
            DegerAl(out a);
            MessageBox.Show(a.ToString());
            //int a = 5;
            //DegerAl(ref a);
            //MessageBox.Show(a.ToString());
            //int a = 5;
            //DegerAl(a);
            //MessageBox.Show(a.ToString());
            //string Sehir = "İstanbul";
            //DegerAl(Sehir);
            //MessageBox.Show(Sehir);
            //string[] Sehirler = { "İstanbul", "Ankara", "İzmir", "Adana" };
            //MessageBox.Show(Sehirler[0]);
            //ReferansAl(Sehirler);
            //MessageBox.Show(Sehirler[0]);
        }
        private void ReferansAl(string[] Iller)
        {
            Iller[0] = "Bursa";
        }
        private void DegerAl(out int a)
        {
            a = 10;
        }
        //private void DegerAl(ref int a)
        //{
        //    a = 10;
        //}
        //private void DegerAl(int a)
        //{
        //    a = 10;
        //}
        private void DegerAl(string Sehir)
        {
            Sehir = "Ankara";
        }
    }
}
