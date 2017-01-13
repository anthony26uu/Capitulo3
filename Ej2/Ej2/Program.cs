using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string entrada = "";
            int i = 0;
            float grados = 0f;

            float resultado = 0f;

            Console.WriteLine("\t \t Conversor de Grados \n \n Ingrese Opcion deseada \n 1- Grados a Rdianes \n 2- Radianes a grados  "); // Escribe por pantalla un string

            entrada = Console.ReadLine();
            i = System.Int32.Parse(entrada);
            //   i = Convert.ToSingle(entrada);
            switch (i)
            {
                case 1:
                    Console.WriteLine("Ingrese Numero de grados  "); // Escribe por pantalla un string 
                    entrada = Console.ReadLine();
                    grados = Convert.ToSingle(entrada);
                    resultado = 3.15f * grados;

                    Console.Write(" Resultado es " + resultado); // Escribe por pantalla un string 

                    break;
                case 2:

                    Console.WriteLine("Ingrese Numero de Radianes  "); // Escribe por pantalla un string 
                    entrada = Console.ReadLine();
                    grados = Convert.ToSingle(entrada);
                    resultado = 180f * grados / 3.14f;

                    Console.Write(" Resultado es " + resultado); // Escribe por pantalla un string 
                    break;
                default:

                    break;
            }

            Console.ReadKey();
        }
    }
}