using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio2.tp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double pesos, dolares, euro;
            Console.WriteLine("ingrese una cantidad de dinero en pesos argentinos");
            pesos = int.Parse(Console.ReadLine());
            Console.WriteLine("la cantidad ingresada en dolares es: " + pesos*0.0049);
            Console.WriteLine("la cantidad ingresada en euros es: " + pesos*0.0045);
            Console.ReadKey();
        }
    }
}
