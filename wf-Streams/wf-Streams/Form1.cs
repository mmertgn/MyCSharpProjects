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

namespace wf_Streams
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //FileStream fs = new FileStream(@"C:\Ornek.txt", FileMode.OpenOrCreate);
            //FileStream fs = new FileStream("C:\\ornek.txt", FileMode.Create);
            //FileStream fs = new FileStream("Ornek.txt", FileMode.OpenOrCreate);
            //StreamWriter sw = new StreamWriter(fs); //Ornek.txt dosyasını yazma amacıyla açtık
            StreamWriter sw = new StreamWriter("Ornek.txt");
            sw.Write("1.satır"); 
            sw.Write("2.satır");
            sw.WriteLine("3.satır");
            sw.WriteLine("4.satır");
            sw.Close(); //İşimiz bitince dosyayı kapattık.

            //StreamWriter sw2 = new StreamWriter("Ornek.txt"); //Ornek.txt yazma amacıyla baştan oluşturuluyor.
            //sw2.WriteLine("5.satır");
            //sw2.Close();

            StreamWriter sw3 = new StreamWriter("Ornek.txt", true); //append modunu açtık, bu mod sayesinde önceki yazılanlar durur yeni yazılanlar sona eklenir.
            sw3.WriteLine("5.satır");
            sw3.Close();

            StreamReader sr = new StreamReader("Ornek.txt");
            //MessageBox.Show(sr.ReadLine() + sr.ReadLine());
            MessageBox.Show(sr.ReadToEnd());
            sr.Close();
        }
    }
}
