using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tareas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void EjecutarButton_Click(object sender, EventArgs e)
        {
            ParImpar(Convert.ToInt32(NumeroTextBox.Text));
            PositivoNegativo(Convert.ToInt32(NumeroTextBox.Text));

        }

        private int ParImpar (int numero)
        {
            int n = numero % 2;

            if (n == 0)
            {
                MessageBox.Show("El numero ingresado es Par");
            }
            else
            {
                MessageBox.Show("El numero ingresado es Impar");
            }
            return n;
        }

        private int PositivoNegativo(int numero)
        {
    
            if (numero >0)
            {
              Resultado2TextBox.Text = Convert.ToString("El valor ingresado es Positivo");
            }
            else
            {
                Resultado2TextBox.Text = Convert.ToString("El valor ingresado es Negativo");
            }

           return numero;
        }
    }
}
