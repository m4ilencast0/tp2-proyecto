using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio7TP2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int lado1, lado2, altura;
            Console.WriteLine("ingrese el valor de la base del paralelogramo");
            lado1 = int.Parse(Console.ReadLine());
            Console.WriteLine("ingrese el valor de otro lado del paralelogramo");
            lado2 = int.Parse(Console.ReadLine());
            Console.WriteLine("el perimetro del paralelodramo es: " + 2 * (lado1 + lado2));
            Console.WriteLine("ingrese el valor de la altura del paralelogramo");
            altura = int.Parse(Console.ReadLine());
            Console.WriteLine("el area del paralelogramo es: " + lado1 * altura);

            Console.ReadKey();




        }
    }
}
