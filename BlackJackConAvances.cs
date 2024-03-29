﻿using System;
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
            int carta1 = 0, carta2 = 0, total = 0, sumaCartas = carta1 + carta2, jugador = 0, n = 5, m = 2, contadorJ = 0;
            string continuar = "s", ganador = "Nadie";

            Console.WriteLine("Ingrese el numero de jugadores (minimo 2 maximo 5)");
            jugador = int.Parse(Console.ReadLine());

            while (jugador > n || jugador < m)
            {
                Console.WriteLine("Error. Minimo 2 jugadores, maximo 5");
                jugador = int.Parse(Console.ReadLine());
            }

            while (jugador > contadorJ)
            {
                Console.WriteLine("Inicio del juego");

                Console.WriteLine("\nBienvenido jugador: ");
                Console.WriteLine("Ingrese el nombre del jugador");
                string nombre = Console.ReadLine();

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
                        ganador = nombre;
                        Console.WriteLine("Ganaste");
                        Console.WriteLine("Total: " + total);
                        break;
                    }
                    else
                    {
                        ganador = nombre;
                        Console.WriteLine("Eliminado");
                        Console.WriteLine("Total: " + total);
                        total = 0;
                        break;
                    }
                }

                jugador -= 1;


            }
            Console.WriteLine("Gandaor: " + ganador);
            Console.WriteLine("Gracias por participar ");
        }
    }
}
