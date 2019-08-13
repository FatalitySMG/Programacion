using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Bienvenido a BlackJack: ");

            Random aleatorio = new Random();
            int carta1 = 0, carta2 = 0, total = 0, sumaCartas = carta1 + carta2;
            string continuar = "s";

            while (continuar == "s" && total < 21)
            {
                carta1 = aleatorio.Next(1, 11);
                Console.WriteLine("Carta dada: " + carta1);
                total += carta1;
                if (total < 21)
                {
                    Console.WriteLine("Total: " + total);
                    Console.WriteLine("¿Desea otra Carta? (s/n) ");
                    continuar = Console.ReadLine();
                }
                else if (total == 21)
                {
                    Console.WriteLine("Ganaste");
                    Console.WriteLine("Total: " + total);
                }
                else
                {
                    Console.WriteLine("Eliminado");
                    Console.WriteLine("Total: " +total);
                }
            }
        }
    }
}
