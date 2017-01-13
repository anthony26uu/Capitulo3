using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej_3
{
    class Program
    {
        static void Main(string[] args)
        {

            string entrada = "";
            int i = 0;

            Console.WriteLine("\t \t Dias de la semana \n \n Ingrese Un numero entre 1-7 el programa devolvera el dia  \n "); // Escribe por pantalla un string

            entrada = Console.ReadLine();
            i = System.Int32.Parse(entrada);
            //   i = Convert.ToSingle(entrada);
            switch (i)
            {
                case 1:
                    Console.WriteLine("Dia selecionado es Domingo"); // Escribe por pantalla un string 



                    break;
                case 2:

                    Console.WriteLine("Dia selecionado es Lunes  "); // Escribe por pantalla un string 
                    break;

                case 3:

                    Console.WriteLine("Dia selecionado es Martes  "); // Escribe por pantalla un string 
                    break;

                case 4:

                    Console.WriteLine("Dia selecionado es Miercoles  "); // Escribe por pantalla un string 
                    break;
                case 5:

                    Console.WriteLine("Dia selecionado es Jueves  "); // Escribe por pantalla un string 
                    break;

                case 6:

                    Console.WriteLine("Dia selecionado es Viernes   "); // Escribe por pantalla un string 
                    break;

                case 7:

                    Console.WriteLine("Dia selecionado es Sabado  "); // Escribe por pantalla un string 
                    break;
                default:

                    break;
            }

            Console.ReadKey();

        }
    }
}

