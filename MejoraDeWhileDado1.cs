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
            Console.WriteLine("1. Cada 3 turnos lanzas 3 dados y si cae par ganas");
            Console.WriteLine("2. Solo puedes recuperar hasta 3 vidas");
            Console.WriteLine("3. Cada 2 turnos pierndes una vida");


            Random aleatorio = new Random();
            int dado1 = 0, SumaDeUnos = 0, total = 0, sumaDeSeis = 0, vidas = 3, SumaDeUnosPar = 0, vidasRecuperadas = 0, turnos = 0,dado2 = 0, par = 0;
            string continuar = "s";


            while (continuar == "s")
            {
                turnos += 1;
                Console.WriteLine("Turno: " + turnos);

                if (turnos%3 == 0)
                {
                    dado1 = aleatorio.Next(1, 7);
                    dado2 = aleatorio.Next(1, 7);
                    Console.WriteLine("Sacaste " + dado1 + " y " + dado2);
                    total += dado1 + dado2;

                    if (dado1 == dado2)
                    {
                        par = 1;
                    }
                }
                else
                {
                    dado1 = aleatorio.Next(1, 7);
                    Console.WriteLine("Sacaste " + dado1);
                    total += dado1;
                }

                if (turnos%2 ==0)
                {
                    vidas -= 1;
                }

                if (par ==1)
                {
                    Console.WriteLine("Vidas: " + vidas);
                    Console.WriteLine("Numero de seis: " + sumaDeSeis);
                    Console.WriteLine("Ganaste");
                    Console.WriteLine("Total puntos: " + total);
                    break;
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
