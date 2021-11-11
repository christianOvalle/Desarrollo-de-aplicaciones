using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practicaeudy
{
    class Program
    {
        static void Main(string[] args)
        {


            Perro pitbull = new Perro();

            pitbull.color = "negro";
            pitbull.Discapacidad = "NO";
            pitbull.Raza = "pitbull";
            pitbull.velocidad = "20 KM";
            pitbull.peso = "115 LB";
            pitbull.tamano = "3.4 CM";
           

            Console.WriteLine("Datos de Perro:\ncolor: {0} \nDiscapacidad: {1} \nRaza {2} \nVelocidad: {3} \nPeso: {4} \nTamano: {5}", pitbull.color, pitbull.Discapacidad, pitbull.Raza, pitbull.velocidad, pitbull.peso, pitbull.tamano);
            Console.WriteLine();
            Console.WriteLine (pitbull.metodo1());
            Console.WriteLine(pitbull.metodo2());
            Console.WriteLine(pitbull.metodo3());



            Console.ReadKey();

        }
    }
}
