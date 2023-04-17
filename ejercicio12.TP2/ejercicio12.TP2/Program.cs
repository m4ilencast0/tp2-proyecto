using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;
/*Realizar un programa que lea un número y que muestre su raíz cuadrada y su raíz cúbica. C# tiene
función que permita calcular la raíz cuadrada cúbica. ¿Cómo se puede calcular?*/
namespace ejercicio12.TP2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            for (int contador =0; contador < 10; contador++)
            {
                Console.WriteLine("{2}" + "{0 --- {1}", contador, contador * 2, contador*3);
            }
            Console.ReadKey();


        }
    }
}
