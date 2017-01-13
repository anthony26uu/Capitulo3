using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej_1
{
    class Program
    {
        static void Main(string[] args)
        {

            string entrada = "";


            int i = 0;
            int par = 0;



            Console.WriteLine("\t \t Par o impar \n "); // Escribe por pantalla un string


            Console.WriteLine("Ingrese un numero ");

            entrada = Console.ReadLine();
            par = System.Int32.Parse(entrada);



            if (par % 2 == 0)
            {
                Console.WriteLine("Numero es par");

            }
            else
            {
                Console.WriteLine("Numero es Impar");
            }





            //    Console.WriteLine("Ingrese Numero Grados centígrados  a convertir  "); // Escribe por pantalla un string 
            //  entrada = Console.ReadLine();




            //       Console.Write("Resultado es " + resultado);
            Console.ReadKey();

        }
    }
}