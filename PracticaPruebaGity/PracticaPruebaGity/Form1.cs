//Mi nombre es Estrella de Pluton
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PracticaPruebaGity
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void ConvertButton_Click(object sender, EventArgs e)
        {
           
            letraBOx.Text = ""+comprobarDNI(Convert.ToInt32(dnibox.Text));
        }
        public char comprobarDNI(int dni)
        {
            return "TRWAGMYFPDXBNJZSQVHLCKE"[dni%23];

            

        }
    }
}
