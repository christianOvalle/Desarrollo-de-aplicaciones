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

            /*
                        Perro pitbull = new Perro();

                        pitbull.color = "negro";
                        pitbull.Discapacidad = "NO";
                        pitbull.Raza = "pitbull";
                        pitbull.velocidad = "20 KM";
                        pitbull.peso = "115 LB";
                        pitbull.tamano = "3.4 CM";


                        Console.WriteLine("Datos de Pitbull:\ncolor: {0} \nDiscapacidad: {1} \nRaza {2} \nVelocidad: {3} \nPeso: {4} \nTamano: {5}", pitbull.color, pitbull.Discapacidad, pitbull.Raza, pitbull.velocidad, pitbull.peso, pitbull.tamano);
                        Console.WriteLine();
                        Console.WriteLine (pitbull.metodo1());
                        Console.WriteLine(pitbull.metodo2());
                        Console.WriteLine(pitbull.metodo3());

                        Console.WriteLine("===========================================================================");

                        Animal pitbull2 = new Animal();

                        pitbull2.color = "negro";
                        pitbull2.Discapacidad = "NO";
                        pitbull2.Raza = "pitbull";
                        pitbull2.velocidad = "20 KM";
                        pitbull2.peso = "115 LB";
                        pitbull2.tamano = "3.4 CM";


                        Console.WriteLine("Datos de Perro:\ncolor: {0} \nDiscapacidad: {1} \nRaza {2} \nVelocidad: {3} \nPeso: {4} \nTamano: {5}", pitbull2.color, pitbull2.Discapacidad, pitbull2.Raza, pitbull2.velocidad, pitbull2.peso, pitbull2.tamano);
                        Console.WriteLine();
                        Console.WriteLine (pitbull2.metodo1());
                        Console.WriteLine(pitbull2.metodo2());
                        Console.WriteLine(pitbull2.metodo3());

                        Console.WriteLine("===========================================================================");

                        Person persona2 = new Person();

                        persona2.color = "mulato";
                        persona2.discapacidad = true;
                        persona2.edad = 24;
                        persona2.nombre = "Gabriel";
                        persona2.numero_de_cedula = "40213844541";
                        persona2.tamano = 5.6m;


                        Empleado trabajador = new Empleado();

                        trabajador.nombre = "Jorge";
                        trabajador.puesto = "Almacen";
                        trabajador.telefono = "8295544546";
                        trabajador.codigo = 2425;
                        trabajador.cedula = "401125478740";
                        trabajador.apellido = "Cabrera";

                        Console.WriteLine("Datos de persona:\nnombre: {0} \ncedula: {1} \nTamano: {2} \nedad: {3} \nDiscapacidad: {4} \ncolor: {5}", persona2.nombre, persona2.numero_de_cedula, persona2.tamano, persona2.edad, persona2.discapacidad, persona2.color);
                        Console.WriteLine();
                        persona2.metodo1();
                        persona2.metodo2();
                        persona2.metodo3();

                        Console.WriteLine("==============================================");
                        Console.WriteLine();

                        Console.WriteLine("Datos de empleado:\nnombre: {0} \npuesto: {1} \nTelefono: {2} \ncodigo: {3} \nCedula: {4} \nApellido: {5}", trabajador.nombre, trabajador.puesto, trabajador.telefono, trabajador.codigo, trabajador.cedula, trabajador.apellido);

                        Console.WriteLine();
                        trabajador.metodo1();
                        trabajador.metodo2();
                        trabajador.metodo3();
            */
            Console.WriteLine("Ingrese un valor");
            Estaticos.Valores.num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese un valor");
            Estaticos.Valores.num2 = int.Parse(Console.ReadLine());

            Estaticos.Operaciones.operacion();
            Estaticos.Mensaje.mostrar();


            Console.ReadKey();

        }
    }
}
