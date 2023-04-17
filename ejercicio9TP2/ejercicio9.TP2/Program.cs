using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio9.TP2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double sueldo, comision, ventas;
            Console.WriteLine("ingrese su sueldo base ");
            sueldo = int.Parse(Console.ReadLine());
            Console.WriteLine("ingrese la cantidad de ventas ");
            ventas = int.Parse(Console.ReadLine());
            Console.WriteLine("su sueldo con su comisión de ventas es " + (sueldo+sueldo * 0.10));

            Console.ReadKey();




        }
    }
}
