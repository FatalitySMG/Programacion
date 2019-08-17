using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MejoraDeWhile
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Bienvenido al juego de dado infinito: ");
            Console.WriteLine("Las reglas son las siguientes:");
            Console.WriteLine("1. Si sacas 2 veces 1 asi no se consecutivo pierdes");
            Console.WriteLine("2. Si sacas 3");
            Console.WriteLine("3. Si sacas un par de 1's pierdes");


            Random aleatorio = new Random();
            int dado1 = 0, SumaDeUnos = 0, total = 0, sumaDeSeis = 0, vidas = 3, SumaDeUnosPar = 0, vidasRecuperadas =0;
            string continuar = "s";


            while (continuar == "s")
            {
                dado1 = aleatorio.Next(1, 7);
                Console.WriteLine("Sacaste " + dado1);

                total += dado1;


                if (dado1 == 1)
                {
                    SumaDeUnos += 1;                      // Si el resultado es 1 entonces el contador de 1 aumenta en 1

                    if (SumaDeUnos % 2 == 0)             // si el contador de unos es un numero par el contador de unos total aumenta en 1
                    {         
                        vidas -= 1;
                        total -= 10;
                    }
                }
                if (vidasRecuperadas < 3)
                {
                    if (dado1 == 6) sumaDeSeis += 1;

                    if (dado1 != 6) sumaDeSeis = 0;

                    if (sumaDeSeis == 2)
                    {
                        vidas += 1;
                        vidasRecuperadas += 1;
                    }

                }


                if (vidas == 0 )
                {
                    Console.WriteLine("Vidas: " + vidas);
                    Console.WriteLine("Numero de unos: " + SumaDeUnos);
                    Console.WriteLine("Numero de seis: " + sumaDeSeis);
                    Console.WriteLine("Perdiste");
                    Console.WriteLine("Total puntos: " + total);
                    break;
                }

                else
                {
                    Console.WriteLine("Vidas: " + vidas);
                    Console.WriteLine("Vidas Recuperadas: " + vidasRecuperadas);
                    Console.WriteLine("Numero de unos: " + SumaDeUnos);
                    Console.WriteLine("Numero de seis: " + sumaDeSeis);
                    Console.WriteLine("Total: " + total);
                    Console.WriteLine("Quieres seguir Jugando? (s/n)");
                    continuar = Console.ReadLine();
                }

            }
        }
    }
}
