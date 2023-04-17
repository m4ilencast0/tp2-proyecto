using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio4TP2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int seg, min, hs;
            Console.WriteLine("ingrese la cantidad de segundos");
            seg = int.Parse(Console.ReadLine());
            hs = (seg / 3600);
            min = ((seg - hs * 3600) / 60);
            seg = seg - (hs * 3600 + min * 60);
            Console.WriteLine("la cantidad de segundos ingresados es: " + hs + "horass" + min + "minutos" + seg + "segundos");
            Console.ReadKey();
        }
    }
}
