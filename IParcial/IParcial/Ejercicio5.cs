using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IParcial
{
    public partial class Ejercicio5 : Form
    {
        public Ejercicio5()
        {
            InitializeComponent();
        }

        private void HornearButton_Click(object sender, EventArgs e)
        {
            HornearPizza();

            MessageBox.Show("Proceso Normal");
        }

        //Procedimoento para hornear
        private void HornearPizza()
        {
            Thread.Sleep(10000);
        }

        private Task HornearPizzaAsync()
        {
            return Task.Delay(10000);
        }

        private void HornearAsycButton_Click(object sender, EventArgs e)
        {
            HornearPizzaAsync();
            MessageBox.Show("Proceso Asincrono");
        }

        private async void CalcularButton_Click(object sender, EventArgs e)
        {
            decimal n1 = Convert.ToDecimal(Numero1TextBox.Text);
            decimal n2 = Convert.ToDecimal(Numero2TextBox.Text);

            decimal Total = await SumarAsync(n1, n2);

            MessageBox.Show($"La suma es: { Total}");
        }

       

        private async Task<decimal> SumarAsync(decimal n1, decimal n2)
        {
            decimal sumar = await Task.Run(() =>
            {
                return n1 + n2;
            });

            return sumar;
        }

    }
}
