using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio3.tp2_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double salario;
            Console.WriteLine("ingrese su salario bruto");
            salario = int.Parse(Console.ReadLine());
            Console.WriteLine("ingrese su salario es $" + (salario-(salario*0.20)));

            Console.ReadKey();
        }
    }
}
