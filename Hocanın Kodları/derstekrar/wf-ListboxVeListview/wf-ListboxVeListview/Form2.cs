using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wf_ListboxVeListview
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            lvUrunler.Items.Add("Dijital Saat");
            lvUrunler.Items[0].SubItems.Add("200");
            lvUrunler.Items[0].SubItems.Add("42mm");
            lvUrunler.Items.Add("Analog Saat");
            lvUrunler.Items[1].SubItems.Add("250");
            lvUrunler.Items[1].SubItems.Add("45mm");

            
        }
    }
}
