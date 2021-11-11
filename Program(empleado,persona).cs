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

            Console.ReadKey();

        }
    }
}
