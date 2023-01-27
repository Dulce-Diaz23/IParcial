using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrimerP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Variables
            decimal Numero1 = Convert.ToDecimal(Numero1TextBox.Text);
            decimal Numero2 = Convert.ToDecimal(Numero2TextBox.Text);

            decimal resultado = Numero1 + Numero2;

            MessageBox.Show("La suma es:" + resultado);
        }
    }
}
