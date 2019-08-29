using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArregloAlgorBurbuja
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese el numero de estudiantes: ");
            int n = int.Parse(Console.ReadLine()), t = 0;
            string nT = "Nadie";
            int[] notas = new int[n];
            string[] nombres = new string[n];

            for (int i = 0; i < notas.Length; i++)
            {
                Console.Write("Nombre del estudiante: ");
                nombres[i] = Console.ReadLine();

                Console.Write("Nota del estudiante ");
                notas[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < notas.Length - 1; i++)
            {
                if (notas[i] < notas[i + 1])
                {
                    t = notas[i + 1];
                    notas[i + 1] = notas[i];
                    notas[i] = t;

                    nT = nombres[i + 1];
                    nombres[i+1] = nombres[i];
                    nombres[i] = nT;

                }
            }
            for (int i = 0; i < notas.Length; i++)
            {
                Console.WriteLine( nombres[i] + " " + notas[i]);
            }
        }
    }
}
