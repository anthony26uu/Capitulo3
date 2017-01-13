using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ej5
{
    class Program
    {
        static void Main(string[] args)
        {
            int caso = 1;

            Console.WriteLine("\t Perimetro y Area de poligono .");
            Console.WriteLine("Ingrese opcion deseada \n 1-Perimetro \n 2- Area.");
            caso = Int32.Parse(Console.ReadLine());

            switch (caso)
            {
                case 1:

                   
                    double perimetro = 0, lado = 0, cantidad = 0;
                    Console.WriteLine("\t \t Estas Buscando Perimetro ");

                    Console.WriteLine("Encontrar el Perimetro  de un Poligono.");


                    Console.Write("Ingrese cantidad de lados del Poligono: ");
                    cantidad = Int32.Parse(Console.ReadLine());

                  
                    Console.Write("Ingrese el lados del Poligono: ");
                   
                    lado = Int32.Parse(Console.ReadLine());





                    //Realiza la operacion
                    perimetro = cantidad * lado;

                  
                    Console.WriteLine("El Perimetro del poligono es: " + perimetro);


                    break;
                case 2:

                    Console.WriteLine("\t \t Estas Buscando Area ");
                    double Perimetro, Apotema, Area, Areap;

                    Console.Write("Ingrese Perimetro ");
                    Perimetro = Int32.Parse(Console.ReadLine());
                    Console.Write("\n ");
                    Console.Write("Ingrese Apotema ");
                    Apotema = Int32.Parse(Console.ReadLine());

                    Area = Perimetro * Apotema;

                    Areap = (Area / 2);

                    Console.Write("Resultado es  "+ Areap);


                    break;
                default:
                    Console.WriteLine("Default case");
                    break;
            }


            Console.ReadKey();
        }

    }
}
