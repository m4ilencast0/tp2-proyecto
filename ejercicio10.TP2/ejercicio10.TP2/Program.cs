using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Una tienda ofrece un descuento del 15% sobre el total de la compra y un cliente desea saber cuánto
deberá pagar finalmente por su compra.*/
namespace ejercicio10.TP2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int total, descuento;
            Console.WriteLine("ingrese el total de su compra realizada");
            total = int.Parse(Console.ReadLine());
            Console.WriteLine("su total a pagar con descuento es " + (total - total * 0.15));

            Console.ReadKey();


        }
    }
}
