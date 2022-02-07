using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practicas
{
    class Computadora
    {

        public string marca;
        public int nucleos;
        public string color;
        public string numero_de_discos;
        public string cantidad_de_ram;
        public int precio;



        public Computadora()
        {

            Console.WriteLine("Vacio");

        }


        public Computadora(string mrc)
        {

            this.marca = mrc;

        }

        public Computadora(string mrc, int proce)
        {

            this.marca = mrc;
            this.nucleos = proce;


        }

        public Computadora(string mrc, int proce, string colo)
        {


            this.marca = mrc;
            this.nucleos = proce;
            this.color = colo;

        }

        public Computadora(string mrc, int proce, string colo,string Discos)
        {


            this.marca = mrc;
            this.nucleos = proce;
            this.color = colo;
            this.numero_de_discos = Discos;

        }

        public Computadora(string mrc, int proce, string colo, string Discos, string ram)
        {


            this.marca = mrc;
            this.nucleos = proce;
            this.color = colo;
            this.numero_de_discos = Discos;
            this.cantidad_de_ram = ram;

        }


        public Computadora(string mrc, int proce, string colo, string Discos, string ram,int price)
        {


            this.marca = mrc;
            this.nucleos = proce;
            this.color = colo;
            this.numero_de_discos = Discos;
            this.cantidad_de_ram = ram;
            this.precio = price;

        }



        public void Mostrar()
        {

            Console.WriteLine("Marca: "+marca);
            Console.WriteLine("Procesadores :" + nucleos);
            Console.WriteLine("Color: "+color);
            Console.WriteLine("Cantidad de discos: "+numero_de_discos);
            Console.WriteLine("cantidad_de_ram: "+cantidad_de_ram);
            Console.WriteLine("Precio: "+precio);


        }

    }
}




    

