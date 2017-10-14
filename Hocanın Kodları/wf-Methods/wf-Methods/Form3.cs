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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        string[] Ogrenciler = { "Büşra", "Mert", "Sezgin", "Nazlı", "Ayşegül", "Muhammed" };
        int[] Notlar = { 50, 70, 30, 80, 40 };
        private void Form3_Load(object sender, EventArgs e)
        {
            //Metotların İmzası = Metot İsmi + Parametre Sayısı + Parametre Veri Türü
            //İsimleri aynı olmasına rağmen, imzaları farklı olan birden çok metodun kullanılabilmesine Metotların Aşırı Yüklenmesi (Overloading) denir.
            DiziGoster(Ogrenciler);
            DiziGoster(Ogrenciler, lbListe2);
            DiziGoster(Notlar);
            DiziGoster(Notlar, lbListe2);
        }
        private void DiziGoster(int[] Dizi)
        {
            lbListe1.Items.Clear();
            foreach (int eleman in Dizi)
            {
                lbListe1.Items.Add(eleman);
            }
        }
        private void DiziGoster(string[] Dizi)
        {
            lbListe1.Items.Clear();
            foreach (string eleman in Dizi)
            {
                lbListe1.Items.Add(eleman);
            }
        }
        private void DiziGoster(string[] Dizi, ListBox liste)
        {
            liste.Items.Clear();
            foreach (string eleman in Dizi)
            {
                liste.Items.Add(eleman);
            }
        }
        private void DiziGoster(int[] Dizi, ListBox liste)
        {
            liste.Items.Clear();
            foreach (int eleman in Dizi)
            {
                liste.Items.Add(eleman);
            }
        }
    }
}
