using POO;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace IParcial
{
    public partial class Ejercicio9 : Form
    {
        public Ejercicio9()
        {
            InitializeComponent();
        }


        Coche miCoche = null;
        //tipo
        List<Coche> cocheList = new List<Coche>();    // declarar Lista de objeto
        private void button1_Click(object sender, EventArgs e)
        {
            //Coche miCoche = new Coche();
            //Coche miCoche2 = new Coche("Toyota", "22R");


            if (MarcaTextBox.Text == "")
            {
                errorProvider.SetError(MarcaTextBox, "Ingrese un valor");
                return;
            }

            if (ModeloTextBox.Text == "")
            {
                errorProvider.SetError(ModeloTextBox, "Ingrese un valor");
                return;
            }

            if (PrecioTextBox.Text == "")
            {
                errorProvider.SetError(PrecioTextBox, "Ingrese un valor");
                return;
            }

            errorProvider.Clear();

            string marca = MarcaTextBox.Text;
            string modelo = ModeloTextBox.Text;
            decimal precio = Convert.ToDecimal(PrecioTextBox.Text);

            //sustituir el if para validar
            int km = KilometrosTextBox.Text == String.Empty ? 0 : Convert.ToInt32(KilometrosTextBox.Text);

            miCoche = new Coche(marca, modelo, precio, km);

            cocheList.Add(miCoche);

            CochesDataGridView.DataSource = null;  //limpiar lista para agregar otro objeto
            CochesDataGridView.DataSource = cocheList;
            LimpiarControles();
            MarcaTextBox.Focus();
            //MessageBox.Show("Objeto Coche -> Marca:"+marca+ "Modelo"+modelo);


        }

        //limpiar controles
        private void LimpiarControles()
        {
            MarcaTextBox.Clear();
            ModeloTextBox.Text = "";
            PrecioTextBox.Text = string.Empty;
            KilometrosTextBox.Clear();
        }
    }
}
