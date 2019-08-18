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
            Console.WriteLine("1. Por cada par de 6s consecutivos recuperas una vida");
            Console.WriteLine("2. Solo puedes recuperar hasta 3 vidas");
            Console.WriteLine("3. Cada 2 turnos pierndes una vida");


            Random aleatorio = new Random();
            int dado1 = 0, SumaDeUnos = 0, total = 0, sumaDeSeis = 0, vidas = 3, SumaDeUnosPar = 0, vidasRecuperadas = 0, turnos = 0;
            string continuar = "s";


            while (continuar == "s")
            {
                turnos += 1;
                Console.WriteLine("Turno: " + turnos);
                dado1 = aleatorio.Next(1, 7);
                Console.WriteLine("Sacaste " + dado1);

                total += dado1;

                if (turnos%2 ==0)
                {
                    vidas -= 1;
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


                if (vidas == 0)
                {
                    Console.WriteLine("Vidas: " + vidas);
                    Console.WriteLine("Numero de seis: " + sumaDeSeis);
                    Console.WriteLine("Perdiste");
                    Console.WriteLine("Total puntos: " + total);
                    break;
                }

                else
                {
                    Console.WriteLine("Vidas: " + vidas);
                    Console.WriteLine("Vidas Recuperadas: " + vidasRecuperadas);
                    Console.WriteLine("Numero de seis: " + sumaDeSeis);
                    Console.WriteLine("Total: " + total);
                    Console.WriteLine("Quieres seguir Jugando? (s/n)");
                    continuar = Console.ReadLine();
                }

            }
        }
    }
}