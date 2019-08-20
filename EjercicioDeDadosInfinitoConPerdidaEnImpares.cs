using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuegoDeDado2Numero2ConFinalEn1210
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenido a (El juego de dados): ");
            Console.WriteLine("Las reglas son las siguientes:");
            Console.WriteLine("1. Si llegas a 100 puntos o mas ganas");
            Console.WriteLine("2. Si sacas un 1o seguido de un 12 ganas");
            Console.WriteLine("3. Si sacas un numero impar pierdes");

            Random aleatorio = new Random();
            int dado1 = 0, total = 0, inicial = 0, contador12 = 0, contador10 = 0, final = 0;
            string continuar = "s";
            string repetir = "s";

            while (continuar == "s" || total <100)
            {
                while (inicial < 3 && repetir == "s")
                {
                    dado1 = aleatorio.Next(1, 13);
                    Console.WriteLine("Sacaste: " + dado1);
                    Console.WriteLine("Quieres seguir jugando? (s/n)");
                    repetir = Console.ReadLine();
                    inicial += 1;
                    total += dado1;
                    
                    if (repetir != "s") 
                    {
                        final = 1;
                        break;
                    }    
                }
                if (final ==1) break;
                
                dado1 = aleatorio.Next(1, 13);
                Console.WriteLine("Sacaste: " + dado1);
                total += 1;

                if (dado1%2 != 0)
                {
                    Console.WriteLine("Perdiste");
                    Console.WriteLine("Total: " + total);
                    break;
                }

                if (dado1 == 12)
                {
                    contador12 = 1;
                    Console.WriteLine("Si sacas un 10 en el siguiente turno ganas");
                }

                if (contador12 == 1)
                {
                    if (dado1 == 10) contador10 = 1;
                    else contador10 = 0;
                }
                if (dado1 != 12) contador12 = 0;

                if (contador12 + contador10 ==2)
                {
                    Console.WriteLine("Ganaste");
                    Console.WriteLine("Total: " + total);
                    break;
                }     
                
                Console.WriteLine("Quieres seguir jugando? (s/n)");
                continuar = Console.ReadLine();
            }
            if (total >= 100) Console.WriteLine("Ganaste");            
        }
    }
}
