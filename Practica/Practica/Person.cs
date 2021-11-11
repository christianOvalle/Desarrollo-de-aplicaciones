using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica
{
    class Person
    {

        public int edad;
        public string nombre;
        public string color;
        public decimal tamano;
        public bool discapacidad;
        public string numero_de_cedula;

        public void caminar() {

         Console.WriteLine("caminar");

        }
        public string saludar() {

            return "hOLA";
        
        }
      
    }

}
