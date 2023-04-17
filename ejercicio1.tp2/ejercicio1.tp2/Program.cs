using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio1.tp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int nombre, usuario;
            Console.WriteLine("ingrese su nombre");
            nombre = int.Parse(Console.ReadLine());
            Console.WriteLine("hola usuario" + nombre );
            Console.ReadKey();
            
        }
    }
}
