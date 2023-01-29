using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IParcial
{
    public partial class Ejercicio2 : Form
    {
        public Ejercicio2()
        {
            InitializeComponent();
        }

        private void EjecutarButton_Click(object sender, EventArgs e)
        {
            if (Numero1TextBox.Text == "")
            {
                errorProvider.SetError(Numero1TextBox, " Ingrese un valor");
                return;
            }
            if (Numero2TextBox.Text == "")
            {
                errorProvider.SetError(Numero2TextBox, " Ingrese un valor");
                return;
            }


            if (OperacionesComboBox.Text == "")
            {
                errorProvider.SetError(OperacionesComboBox, " Seleccione una opcion"); // Validar que se elija operacion

                return; // Cancelar ejecucion
            }
            errorProvider.Clear();    
           
            decimal resultado = Ejecutar(Convert.ToDecimal(Numero1TextBox.Text), Convert.ToDecimal(Numero2TextBox.Text));

            ResultadoLabel.Text = Convert.ToString(resultado);
        }

        
        private decimal Ejecutar (decimal n1,decimal n2)
        {
            string operacion = OperacionesComboBox.Text;
            decimal resultado = 0;

            if ( operacion == "Sumar")
            {
                resultado = n1+ n2;
            }
             else if (operacion == "Restar")
            {
                resultado = n1 - n2;
            }
            else if (operacion == "Multiplicar")
            {
                resultado = n1 * n2;
            }
            if (operacion == "Dividir")
            {
                resultado = n1 / n2;
            }
            return resultado;
        }



    }
}
