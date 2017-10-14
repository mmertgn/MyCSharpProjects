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
            int a = 5;
            DegerAl(out a); //out ile a'nın adresi gönderilmiş olur, out'un sağladığı ek özellik başlagıç değeri olmadan da kullanılmasını sağlar. !!!!!(***ÖNEMLİ)
            MessageBox.Show(a.ToString());
            //int a = 5;
            //DegerAl(ref a); //ref ile a'nın adresi gönderilmiş olur!!!!(****ÖNEMLİ)
            //MessageBox.Show(a.ToString());
            //int a = 5;
            //DegerAl(a);
            //MessageBox.Show(a.ToString());
            //string Sehir = "Istanbul";
            //DegerAl(Sehir);
            //MessageBox.Show(Sehir);
            //string[] Sehirler = { "Istanbul", "Ankara", "İzmir", "Adana" };
            //MessageBox.Show(Sehirler[0]);
            //ReferansAl(Sehirler); //Dizi yolladığımızda değer değil Adres gönderilir. Adres gönderildiğinden ReferansAl fonksiyonundaki değişiklikler dizimizi etkiler.
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
        private void DegerAl(int a)
        {
            a = 10;
        }
        private void DegerAl(string Sehir)
        {
            Sehir = "Ankara";
        }
    }
}
