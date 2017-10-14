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
            //İsimleri aynı olmasına rağmen imzaları farklı olan birden çok metodun kullanılabilmesine metotların aşırı yüklenmesi(Overloading) denir.
            DiziGoster(Ogrenciler);
            DiziGoster(Ogrenciler,lbListe2);
            DiziGoster(Notlar);
            DiziGoster(Notlar,lbListe2);
        }

        private void DiziGoster(int[] Dizi, ListBox liste)
        {
            liste.Items.Clear();
            for (int i = 0; i < Dizi.Length; i++)
            {
                liste.Items.Add(Dizi[i]);
            }
        }

        private void DiziGoster(int[] Dizi)
        {

            lbListe1.Items.Clear();
            for (int i = 0; i < Dizi.Length; i++)
            {
                lbListe1.Items.Add(Dizi[i]);
            }
        }

        private void DiziGoster(string[] Dizi)
        {
            lbListe1.Items.Clear();
            //foreach (string item in Dizi)
            //{
            //    lbListe1.Items.Add(item);
            //}
            for (int i = 0; i < Dizi.Length; i++)
            {
                lbListe1.Items.Add(Dizi[i]);
            }
        }
        private void DiziGoster(string[] Dizi, ListBox liste)
        {
            liste.Items.Clear();
            for (int i = 0; i < Dizi.Length; i++)
            {
                liste.Items.Add(Dizi[i]);
            }
        }
    }
}
