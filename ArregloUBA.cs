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
            int[] A = { 0, 0, 3, 6, 6, 6, 12, 12, 12, 9, 15, 18, 18 };
            int[] B = { 0, 0, 2, 2, 4, 6, 6, 6, 8, 10, 12, 12, 14, 16, 18, 18 };
            int[] U = new int[31];

            //Inicio visualizacion de Datos
            Console.WriteLine("Datos de los arreglos U, B, y A \nU:"); // ESTA PARTE ES FUNCIONAL Y YA TENGO LOS DATOS BIEN INSERTADOS...
            for (int i = 0; i < U.Length; i++)
            {
                U[i] = i;
                Console.Write(U[i] + ",");
            }
            Console.WriteLine("\nA:");
            for (int i = 0; i < A.Length; i++)
            {
                A[i] = i;
                Console.Write(A[i] + ",");
            }
            Console.WriteLine("\nB:");
            for (int i = 0; i < B.Length; i++)
            {
                B[i] = i;
                Console.Write(B[i] + ",");
            }
            Console.WriteLine("\n");
            //Fin visualizacion de Datos

            //Aparicion de el arreglo almacen de repetidos...
            int[] repetidos = new int[B.Length];
            for(int i = 0; i < B.Length; i++)
            {
                int valorA = A[i];
                int valorB = B[i];
                repetidos[i] = (A[i] - B[i]);
                Console.Write(repetidos[i] + ",\n");
            }
            Console.WriteLine("\n");
            //Aparece Arreglo para asignar los valores repetidos a el almacen...
            for (int i = 0; i < B.Length; i++)
            {

            }
            

        }
    }
}
