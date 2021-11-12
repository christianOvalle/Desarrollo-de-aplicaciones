using System;

namespace practicas
{
    class Program
    {
        static void Main(string[] args)
        {

            Computadora computador = new Computadora();
            

            computador = new Computadora("HP");
            

            computador = new Computadora("HP",3);
           

            computador = new Computadora("HP",3,"azul");
            

            computador = new Computadora("HP", 3, "azul","2");
         

            computador = new Computadora("HP", 3, "azul", "2","8 GB");
           

            computador = new Computadora("HP", 3, "azul", "2", "8 GB",12000);
            computador.Mostrar();

           








        }
    }
}
