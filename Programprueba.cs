using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoP0010112021
{
    class Program
    {
        static void Main(string[] args)
        {
            int valor1 = 70;
            int valor2 = 80;
            int valor3 = 85;
            int valor4 = 90;
            int resultado = valor1 + valor2 + valor3 + valor4;
            int promedios = resultado / 4;
            int resultado2 = valor1 / valor2;
            int resultado3 = valor1 - valor2;
            int resultado4 = valor1 % valor2;

            /*Console.WriteLine(resultado);
            Console.WriteLine(resultado1);
            Console.WriteLine(resultado2);
            Console.WriteLine(resultado3);*//*
            //Console.WriteLine("El resultado de la suma es: "+resultado.ToString());

            //Console.WriteLine("El  resultado de la suma es:  {0} \n {1} ", resultado, resultado1);


            //Suma de cuatra notas 
            //La dividan entre 4
            //Promedio de las cuatros notas


            Console.WriteLine("la suma de nota es: "+ resultado.ToString());
            Console.WriteLine("el promedio de nota es: "+ promedios.ToString());

            Console.WriteLine("la suma de nota es: {0}  promedio de nota es: {1} ", resultado, promedios);
            //Console.WriteLine("el promedio de nota es: {0} ",promedios);*/

            //operadores aritmeticos
            //+-*/%

            //Operadores logicos
            /*&&
            ||
            !*/

            //Operadores de comparacion
            /*
            >=
            <=
            ==
            >
            <
            != <>*/

            //Operadores de asignacion
            /*+=
            -=
            *=
            /=
       */

            /* int numero = 1;

             Console.WriteLine(numero);
             numero *= 2;

             Console.WriteLine(numero);
             numero *= 2;

             Console.WriteLine(numero);*/
            /*
                        if (5 < 6)
                        {
                            Console.WriteLine("true");
                        }

                        else {
                            Console.WriteLine("false");
                        }
            */
            /*
                        int edad = 18;


                        if (edad == 17)
                        {
                            Console.WriteLine("17");
                        }
                        else if (edad == 18)
                        {

                            Console.WriteLine("18");
                        }
                        else
                        {
                            Console.WriteLine("No lo veo");
                        }*/
            /*int edad = 19;
            switch (edad)
            {
                case 17:
                    Console.WriteLine("17");
                    break;
                case 18:
                    Console.WriteLine("18");
                    break;

                default:
                    Console.WriteLine("No lo veo");
                    break;
            }
*/

            /*
                        int valo1 = 25;
                        int valo2 = 25;
                        int valor3 = 10;

                        if (valo1 > valo2)
                        {
                            Console.WriteLine("El numero mayor es: {0}", valo1);
                        }
                        else if (valo2 > valo1)
                        {

                            Console.WriteLine("El numero menor es: {0}", valo2);

                        }

                        else {
                            Console.WriteLine("No se puede identificar");           
                        }
            */

            /*int valo1 = 25;
            int valo2 = 15;
            int valo3 = 10;

            if (valo1 > valo2 && valo1 > valo3)
            {
                Console.WriteLine("El numero mayor es: {0}", valo1);
            }
            else if (valo2 > valo1 && valo2 > valo3)
            {

                Console.WriteLine("El numero menor es: {0}", valo2);

            }

            else if (valo3 > valo1 && valo3 > valo2)
            {

                Console.WriteLine("El numero menor es: {0}", valo3);

            }

            else
            {
                Console.WriteLine("No se puede identificar");
            }

*/


            //================================================
            //Bucle
            //================================================
            /*Console.WriteLine("While");
            int contador = 0;
            while (contador < 100) {
                
                contador += 1;
                Console.Write(contador);
                Console.Write(" ");
            }

            Console.WriteLine();
            Console.WriteLine("DO While");
            int contador1 = 0;
            do {
                contador1 += 1;
                Console.Write(contador1);
                Console.Write(" ");
            } while (contador1 < 100);
*/


            /* Console.WriteLine();
             Console.WriteLine("FOR");*/
            /*for (int i = 1; i<=100; i++)
            {
                Console.WriteLine(i);
            }*/
            /*for (int i = 100; i >= 1; i--)
            {
                Console.WriteLine(i);
            }*/
            /*
                        for (int i = 1; i <= 12 ; i++)
                        {
                            for (int c = 1; c <= 12; c++)
                            {
                                Console.WriteLine("{0} x {1} = {2}",i,c,(i*c));

                            }
                            Console.WriteLine("===========================================================================");
                            Console.WriteLine();
                        }*/



            /*
                        foreach (var item in collection)
                        {

                        }*/




            //Mi ejercicio

            /* for (int i = 1; i<= 12; i++) {

                 for (int m = 1; m <= 12; m++) {

                     Console.WriteLine("{0} x {1} = {2}", i, m, (i * m));
                 }
             }*/

            /*
                        int contador = 0;
                        while (contador < 12)
                        {
                            contador += 1;


                            int contador1 = 0;
                            while (contador1 < 12)
                            {
                                contador1 += 1;
                                Console.WriteLine("{0} x {1} = {2}",contador,contador1,(contador *  contador1));
                            }

                            Console.WriteLine();

                        }*/


            /* int contador1 = 0;
             do
             {
                 contador1 += 1;

                 int contador2 = 0;
                 do
                 {
                     contador2 += 1;
                     Console.WriteLine("{0} x {1} = {2}", contador1, contador2, (contador2 * contador1));

                 } while (contador2 < 12);

             } while (contador1 < 12);
 */

            /*int m = 0;
            int i = 0;
            while (m <= 12)
            {

            while (i <= 12) 
                
                    i++;
                    Console.WriteLine("{0} x {1} = {2}", m, i, (i * m));
                
            }
*/
            /*
                        int[] numeros = new int[3];

                        numeros[0] = 5;
                        numeros[1] = 15;
                        numeros[2] = 30;

                        int producto = numeros[0] + numeros[1] + numeros[2];

                        // Console.WriteLine(producto);
                        *//*
                                    for (int i = 0; i < numeros.Length; i++)
                                    {
                                        Console.WriteLine(numeros[i]);
                                    }
                        *//*
                        foreach (int elemento in numeros)
                        {
                            Console.WriteLine(elemento);
                        }
            */












            /*



                        int res = 0;


                        int[] promedio = new int[10];

                        promedio[0] = 80;
                        promedio[1] = 89;
                        promedio[2] = 75;
                        promedio[4] = 98;
                        promedio[5] = 71;
                        promedio[6] = 65;
                        promedio[7] = 89;
                        promedio[8] = 86;
                        promedio[9] = 87;

                        foreach (var item in promedio)
                        {
                            res = item + res;
                        }
                        // Console.WriteLine("El promedio es: {0}", (res / promedio.Length));






                        string texto = "orem Ipsum is simply dummy text of the printing and typesett";

                        *//* for (int i = 0; i < texto.Length; i++)
                         {
                             Console.WriteLine(texto[i]);
                         }*//*


                        foreach (var item in texto)
                        {
                            Console.WriteLine(item);
                        }


            */

            /*
                        string texto2 = @"Lorem Ipsum is simply dummy 
                                        text of the printing and typesetting industry. 
                                        Lorem Ipsum has been the industry's standard 
                                        dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum";



                        Console.WriteLine(texto2);
            */

            Personas persona1 = new Personas();
            persona1.nombre = "Yonsi Cristian";
            persona1.apellido = "Mata";
            persona1.edad = 90;
            persona1.caminar();

            Console.WriteLine("persona {0} {1} {2}", persona1.nombre, persona1.apellido, persona1.edad);


























            /*
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

                        Console.WriteLine("Datos de person:\n nombre: {0} \n cedula: {1} \n Tamano: {2} \n edad: {3} \n Discapacidad: {4} \n color: {5}", persona2.nombre, persona2.numero_de_cedula, persona2.tamano,persona2.edad, persona2.discapacidad, persona2.color);

                        Console.WriteLine("Datos de empleado :\n nombre: {0} \n cedula: {1} \n Tamano: {2} \n edad: {3} \n Discapacidad: {4} \n color: {5}", trabajador.nombre, trabajador.puesto, trabajador.telefono, trabajador.edad, trabajador.discapacidad, trabajador.color);



            */



























































            Console.ReadKey();
        }
    }
}
