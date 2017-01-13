using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ej3
{

    class Program
    {
        static void Main(string[] args)
        {

            string entrada = "";


            double precio = 0;
            double cantidad = 0;
            bool condicion= false;



            Console.WriteLine("\t \t Impuestos  \n "); // Escribe por pantalla un string


            Console.WriteLine("Ingrese cantidad de articulo a comprar ");
            entrada = Console.ReadLine();
            cantidad = Convert.ToDouble(entrada);

            Console.WriteLine("Ingrese  Precio de articulo a comprar ");
            entrada = Console.ReadLine();
            precio = Convert.ToDouble(entrada);

            Console.WriteLine("Si articulo es de medicina ingrese true si no ingrese false ");
            entrada = Console.ReadLine();
            condicion = Convert.ToBoolean(entrada);


            if (condicion)
            {
                double r= (precio* cantidad);
                Console.WriteLine("Cantidad a pagar es  " + r);
                Console.Write("Como Articulo es de medicina no paga impuestos....");

            }
            else
            {
                
                Console.WriteLine("Pago sin impuestos " + precio*cantidad);
                double r = (precio * cantidad) * 0.18;
                Console.WriteLine("Impuestos  " + r);
                double impuestos = precio * cantidad + r;
                Console.Write("Total a pagar es: " + impuestos);

            }



            
            Console.ReadKey();

        }
    }

}
