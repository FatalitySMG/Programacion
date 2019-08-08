using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadorDeEdad
{
    class Program
    {
        static void Main()
        {
            Console.Write("Ingrese la cantidad de personas total: ");
            int cantP = int.Parse(Console.ReadLine());
            double total = 0;
            int contador = 0;
            int maximo = 0;
            int minimo = 200;
            string nombreMin = "Nadie";
            string nombreMax = "Nadie";

            while (contador < cantP)
            {
                Console.Write("Ingrese el nombre: ");
                string nombre = Console.ReadLine();
                Console.Write("Edad: ");
                int edad = int.Parse(Console.ReadLine());
                if (contador == 0)
                {
                    maximo = edad;
                    minimo = edad;
                }
                if (edad < minimo)
                {
                    minimo = edad;
                    nombreMin = nombre;
                }
                if (edad > maximo)
                {
                    maximo = edad;
                    nombreMax = nombre;
                }
                total += edad;
                contador += 1;
                

            }
            
            double promedio = total / cantP;
            Console.WriteLine("Promedio: " + promedio);
            Console.WriteLine("Mayor: " + maximo);
            Console.WriteLine("Minimo: " + minimo);
            Console.WriteLine("Nombre del Mayor: " + nombreMin);
            Console.WriteLine("Nombre del menor: " + nombreMax);


        }
    }
}
