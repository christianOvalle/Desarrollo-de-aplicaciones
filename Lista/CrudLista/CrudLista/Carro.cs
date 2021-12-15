using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrudLista
{
    class Carro
    {

        public string nombre { set; get; }
        public string apellido { set; get; }
        public int edad { set; get; }


        public Carro(string Nombre, string Apellido, int Edad)
        {


            nombre = Nombre;
            apellido = Apellido;
            edad = Edad;



        }
    }
}



