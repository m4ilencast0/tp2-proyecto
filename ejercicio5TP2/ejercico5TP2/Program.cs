using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercico5TP2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int lado, diagonal1, diagonal2;
            Console.WriteLine("ingrese el tamaño de sus lados");
            lado = int.Parse(Console.ReadLine());
            Console.WriteLine("ingrese el tamaño de su primera diagonal");
            diagonal1 = int.Parse(Console.ReadLine());
            Console.WriteLine("ingrese el tamaño de su segunda diagonal");
            diagonal2 = int.Parse(Console.ReadLine());
            Console.WriteLine("el area del rombo es: " + (diagonal2 * diagonal1) / 2+ "cm 2");
            Console.WriteLine("el perimetro del rombo es: " + 4 * lado + "cm");

            Console.ReadKey();

        }
    }
}
