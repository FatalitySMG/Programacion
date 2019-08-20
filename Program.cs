using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CiclosAnillados
{
    class Program
    {
        static void Main()
        {
            Random aleatorio = new Random();
            int a = 0, b = 0, sumaCorrecta = 0, suma = 0, intento = 3;

            while (intento > 0)
            {
                Console.WriteLine("Captcha password: ");
                a = aleatorio.Next(0, 11);
                b = aleatorio.Next(0, 11);
                Console.WriteLine(+a + " + " + b);
                sumaCorrecta = a + b;

                Console.WriteLine("Insert Captcha password");
                suma = int.Parse(Console.ReadLine());

                if (sumaCorrecta == suma)
                {
                    Console.WriteLine("Access allowed");
                    Console.WriteLine("Starting Program...");
                    break;
                }
                else if (intento > 1)
                {
                    intento -= 1;
                    Console.WriteLine("Access denied");
                    Console.WriteLine("Chances left: " + intento);
                    Console.WriteLine("Try again please");

                }
                else
                {
                    Console.WriteLine("Access denied");
                    Console.WriteLine("You aren´t allowed access the program because we couldn´t verify you are a human, sorry try later");
                    intento -= 1;
                }



            }
        }
    }
}
