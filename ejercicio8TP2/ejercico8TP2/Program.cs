using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercico8TP2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int grad;
            Console.WriteLine("ingrese los grados de un fahernheit");
            grad = int.Parse(Console.ReadLine());
            Console.WriteLine("es igual a: " + (grad - 32) * (5 / 9) + "° cecius");
            Console.ReadKey();
        }
    }
}
