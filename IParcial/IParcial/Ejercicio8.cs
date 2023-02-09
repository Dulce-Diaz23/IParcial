using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IParcial
{
    public partial class Ejercicio8 : Form
    {
        public Ejercicio8()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RecorrerDeUnoEnUno(1, 100);
        }

        private void RecorrerDeUnoEnUno(int valInicial, int valFinal)
        {
            listBox1.Items.Add(valInicial);
            if (valInicial < valFinal)
            {
                RecorrerDeUnoEnUno(valInicial +1, valFinal);
            }
        }
    }
}
