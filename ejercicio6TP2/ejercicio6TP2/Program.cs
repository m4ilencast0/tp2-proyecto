using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio6TP2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int perimetro, lado, ap;
            Console.WriteLine("ingrese el tamaño de los lados de su hexagono");
            lado = int.Parse(Console.ReadLine());
            perimetro = 6 * lado;
            Console.WriteLine("el perimetro de su hexagono es: " + perimetro);
            Console.WriteLine("ingrese el valor del apotema:");
            ap = int.Parse(Console.ReadLine());
            Console.WriteLine("el area del hexagono es: " + perimetro * ap / 2);
            Console.ReadKey();
        }
    }
}
