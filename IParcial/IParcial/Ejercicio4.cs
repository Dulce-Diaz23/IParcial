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

            //Calcular la fecha de la cita
            if (DiasTextBox.Text == "")
            {
                errorProvider.SetError(DiasTextBox, "Ingrese un valor");
                return;
            }
           
            int numeroDias = Convert.ToInt32(DiasTextBox.Text); //Catura el numero que se ingresara de la fecha cita
            DateTime fechaActual = DateTime.Now;

            CitaTextBox.Text = fechaActual.AddDays(numeroDias).ToShortDateString();

            if (RestarTextBox.Text == "")
            {
                errorProvider.SetError(RestarTextBox, "Ingrese un valor");
                return;
            }
            errorProvider.Clear();

            int restarDias = Convert.ToInt32(RestarTextBox.Text);
            FechaNuevaTextBox.Text = fecha.AddDays(-restarDias).ToLongDateString();

            MessageBox.Show("La edad es:" + DevolverEdad(fecha));
            DevolverEdad(fecha);
        }

        private int DevolverEdad(DateTime FechaNacimiento)
        {
            DateTime fechaActual = DateTime.Now;
            int edad = 0;

            if (FechaNacimiento > fechaActual)
            {
                return 0;
            }
            else
            {
                edad = fechaActual.Year - FechaNacimiento.Year;
                return edad;
            }
        }

    }
}
