using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgParaProm
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Ingrese el numero de personas: ");
            int n = int.Parse(Console.ReadLine()), max = 0, min =200, indice = 0;
            string nombresMin = "Nadie", nombresMax = "Nadie", Cerc = "Nadie";
            double total = 0, distMin = 200;
            //Edades...
            int[] edades = new int[n];
            string[] nombres = new string[n];

            for (int i = 0; i < edades.Length; i++)
            {
                Console.Write("Ingrese el nombre de la persona: ");
                nombres[i] = Console.ReadLine();

                Console.Write("Ingrese edad: ");
                edades[i] = int.Parse(Console.ReadLine());

                total += edades[i];

                if (edades[i] > max)
                {
                    max = edades[i];
                    nombresMax = nombres[i];
                    indice = i;
                }
                else if(edades[i]< min)
                {
                    min = edades[i];
                    nombresMin = nombres[i];
                    indice = i;
                }
            }
            //Promdeio y desviacion estandar...

            double promedio = total / edades.Length,suma = 0;

            double[] sumatoria = new double[n];

            for (int i = 0; i < edades.Length; i++)
            {
                int xi = edades[i];
                suma += Math.Pow((xi - promedio),2);

                if (Math.Pow((xi - promedio), 2) < distMin)
                {
                    distMin = Math.Pow((xi - promedio), 2);
                    Cerc = nombres[i];
                }
            }

            double desviacion = Math.Sqrt(suma / n);
            Console.WriteLine("El nombre del mayor es: " + nombresMax + " y su edad es " + max);
            Console.WriteLine("El nombre del menor es: " + nombresMin + " y su edad es " + min);
            Console.WriteLine("3. El promedio es: " + promedio + " y la desviacion estandar es: " + desviacion );
            Console.WriteLine("La persona con la edad mas cercana al promedio es: " +Cerc);
        }
    }
}
