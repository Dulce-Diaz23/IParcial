using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    public class Coche
    {
        // atributos siempre deben ser privados
        private string marca;
        private string modelo;
        //private decimal precio;

        //Propiedades
                                                                               //ayudan a establecer valores a los atributos
        public string Marca                                                   // manera 1
        {
            get { return marca; }                                            //obtener el valor del atributo
            set { marca = value; }                                          //envia/establece informacion
        }

        public string Modelo { get => modelo; set => modelo = value; }      // manera 2
        // manera 3
        public decimal precio { get; set; }                                 // no es necesario declarar atributo
        public int kilometro { get; set; }

        
        //Constuctores, llevan el mismo nomb. de clase
        public  Coche() { }

        public Coche(string _marca, string _modelo) 
        {
            Marca = _marca;
            Modelo = _modelo;

        }

        public Coche(string marca, string modelo, decimal precio, int kilometro) : this(marca, modelo)
        {
            this.precio = precio;
            this.kilometro = kilometro;
        }


        // Metodos
        public string DevolverDatosBasic()
        {
            return "Marca: " + Marca + "Modelo: " + Modelo + "Precio: " + precio;
        }

    }

}
