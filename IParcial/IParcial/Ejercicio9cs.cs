using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using POO;

namespace IParcial
{
    public partial class Ejercicio9cs : Form
    {
        public Ejercicio9cs()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Coche miCoche = new Coche();
            Coche miCoche2 = new Coche("Toyota", "22R");
        }
    }
}
