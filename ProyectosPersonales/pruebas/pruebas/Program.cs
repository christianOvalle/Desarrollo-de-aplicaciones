using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pruebas
{
    public class Program
    {

     
        public static string calculer( string num1, string num2)
        {

           
            
            int r = Convert.ToInt32(num1) + Convert.ToInt32(num2);



            Console.WriteLine(r);
            Console.ReadKey();

            return r.ToString();
        }
        public static void Main(string[] args)
        {
            calculer(Console.ReadLine(),Console.ReadLine());

          }
       

    }
}
