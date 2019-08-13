using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimulacroParcialWhile
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Bienvenido a (El juego de dados): ");
            Console.WriteLine("Las reglas son las siguientes:");
            Console.WriteLine("1. Si llegas a 100 puntos o mas ganas");
            Console.WriteLine("2. Si sacas 3 pares seguidos inmediatamente ganas");
            Console.WriteLine("3. Si sacas un par de 1's pierdes");


            Random aleatorio = new Random();
            int dado1 = 0, dado2 = 0, sumaDePares = 0, total = 0, sumaDeParesTotal = 0;
            double masSeis = 0, porcentajeMasSeis = 0, eventos = 0;
            string continuar = "s";

            if (total < 100)
            {
                while (continuar == "s")
                {
                    dado1 = aleatorio.Next(1, 7);
                    dado2 = aleatorio.Next(1, 7);
                    Console.WriteLine("Sacaste " + dado1 + " y " + dado2);
                    total += dado1 + dado2;
                    eventos += 1;
                    if (dado1 == dado2) sumaDeParesTotal += 1;
                    //Bueno
                    if (dado1 == dado2) sumaDePares += 1;
                    else sumaDePares = 0;

                    //Bueno
                    if (dado1 + dado2 > 6) masSeis += 1;
                    porcentajeMasSeis = ((masSeis / eventos) * 100);

                    if (dado1 + dado2 == 2)
                    {
                        Console.WriteLine("Perdiste :(");break;

                    }
                    if (total < 100 )
                    {
                        Console.WriteLine("Suma de pares seguidos: " + sumaDePares);
                        Console.WriteLine("Total: " + total);
                        Console.WriteLine("¿Desea volver a tirar los dados? (s/n) ");
                        continuar = Console.ReadLine();
                    }

                    if (total >= 100 || sumaDePares == 3)
                    {
                        Console.WriteLine("Total: " + total);
                        Console.WriteLine("Ganaste");
                        Console.WriteLine("Porcentaje de veces que en el par de dados lanzados se supero la suma de 6: " + porcentajeMasSeis +"%");
                        Console.WriteLine("Total de pares en la partida: " + sumaDeParesTotal);
                        break;
                    } 

                }
            }


        }
    }
}
