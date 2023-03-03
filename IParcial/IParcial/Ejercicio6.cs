using System;
using System.Windows.Forms;

namespace IParcial
{
    public partial class Ejercicio6 : Form
    {
        public Ejercicio6()
        {
            InitializeComponent();
        }

        private void ArregloButton_Click(object sender, EventArgs e)
        {
            // Vectores
            int[] vector = new int[5];

            vector[0] = 10;   //Manera 1 declarar
            vector[1] = 20;
            vector[2] = 30;
            vector[3] = 40;
            vector[4] = 50;

            int[] vector2 = new int[5] { 10, 20, 30, 40, 50 };         //Manera 2  declarar
            int[] vector3 = new int[] { 10, 20, 30, 40, 50, 60 };    // Manera 3 decarar
            int[] vector4 = { 10, 20, 30, 40, 50, 60 };             // Manera 4

            string[] vector5 = { "Dulce", "Maria", "Heber", "Manuel" };

            for (int i = 0; i <= vector5.Length; i++)
            {
                ArreglosListBox.Items.Add(vector5[i]);          //add agrega valor a lixtbox
            }

            foreach (string item in vector5)
            {
                ArreglosComboBox.Items.Add(item);
            }
        }
    }
}
