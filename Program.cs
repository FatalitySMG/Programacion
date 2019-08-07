using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_binarios
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Conversor de binarios a decimal");

            Console.WriteLine("Valor 1");
            int b4 = int.Parse(Console.ReadLine());

            Console.WriteLine("Valor 2");
            int b3 = int.Parse(Console.ReadLine());

            Console.WriteLine("Valor 3");
            int b2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Valor 4");
            int b1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Valor 5");
            int b0 = int.Parse(Console.ReadLine());

            double bf = b4 * Math.Pow(2, 4) + b3 * Math.Pow(2, 3) + b2 * Math.Pow(2, 2) + b1 * Math.Pow(2, 1) + b0 * Math.Pow(2, 0);

            Console.WriteLine("Respuesta = " + bf);


        }
    }
}
