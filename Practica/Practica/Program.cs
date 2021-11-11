using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica
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

            Console.WriteLine("Datos de person:\n nombre: {0} \n cedula: {1} \n Tamano: {2} \n edad: {3} \n Discapacidad: {4} \n color: {5}", persona2.nombre, persona2.numero_de_cedula, persona2.tamano, persona2.edad, persona2.discapacidad, persona2.color);

            Console.WriteLine("Datos de empleado :\n nombre: {0} \n puesto: {1} \n Telefono: {2} \n Codigo: {3} \n Cedula: {4} \n apellido: {5}", trabajador.nombre, trabajador.puesto, trabajador.telefono, trabajador.codigo, trabajador.cedula, trabajador.apellido);




        }
    }
}