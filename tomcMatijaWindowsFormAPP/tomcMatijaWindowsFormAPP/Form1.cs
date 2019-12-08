using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tomcMatijaWindowsFormAPP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // ovoj string varijabli dodjeljuje se vrijednost

            // izabrane stavke u combo box-u

            string odabir = comboBox1.SelectedItem.ToString();

            // odabrana stavka iz combo box-a upisuje se u text box

            textBox1.Text = "Odabrali ste: " + odabir;
        }
    }
}
