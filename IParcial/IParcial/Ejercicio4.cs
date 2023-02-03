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
    public partial class Ejercicio4 : Form
    {
        public Ejercicio4()
        {
            InitializeComponent();
        }

        private void EjecutarButton_Click(object sender, EventArgs e)
        {
            DateTime fecha = FechaDateTimePicker1.Value;

            DiaTextBox.Text = fecha.Day.ToString();
            MesTextBox.Text = fecha.Month.ToString("MMMM");
            AnioTextBox.Text = fecha.Year.ToString();
            SemanaTextBox.Text = fecha.DayOfWeek.ToString();
        }

       
    }
}
