using System;

namespace practicas
{
    class Program
    {
        static void Main(string[] args)
        {

            Computadora computador = new Computadora();
            //computador.Mostrar();

            computador = new Computadora("HP");
            //computador.Mostrar();

            computador = new Computadora("HP",3);
            //computador.Mostrar();

            computador = new Computadora("HP",3,"azul");
            //computador.Mostrar();

            computador = new Computadora("HP", 3, "azul","2");
           // computador.Mostrar();

            computador = new Computadora("HP", 3, "azul", "2","8 GB");
           // computador.Mostrar();

            computador = new Computadora("HP", 3, "azul", "2", "8 GB",12000);
            computador.Mostrar();

            //Computadora computador2 = new Computadora("4 gb",15.28,"dell" );








        }
    }
}
