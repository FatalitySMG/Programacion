using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio4
{
    class Program
    {
        static void Main()
        {
            //Entrada principal
            Console.WriteLine("ingrese el numero de votos del partido a ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("ingrese el numero de votos del partido b ");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("ingrese el numero de votos en blanco ");
            int blanco = int.Parse(Console.ReadLine());
            Console.WriteLine("ingrese el numero de votos anulados ");
            int nule = int.Parse(Console.ReadLine());
            Console.WriteLine("ingrese el numero de personas ");
            int totpob = int.Parse(Console.ReadLine());
            Console.WriteLine("ingrese el porcentaje de personas mayores de edad ");
            int mEdad = int.Parse(Console.ReadLine());
            int votantes = (a + b + blanco + nule);
            double abstencion = (totpob * mEdad/100) - votantes;
            //Codigo

            bool ca = (nule < ((a + b) * 0.3));
            bool cb = ((a + b) > blanco);
            bool cc = (abstencion < votantes);


            //Ganador

           

            if ((ca || cb) && cc)
            {
                Console.WriteLine("Las votaciones fueron exitosas");
                if (a > b)
                {
                    Console.WriteLine("Gana el partido a");
                }
                else Console.WriteLine("Gana el partido b");
                

            }
            else
            {
                Console.WriteLine("Se ha cometido un error y deben repetirse las votaciones");
            }
            

            //Funciona perra
        }
    }
}
