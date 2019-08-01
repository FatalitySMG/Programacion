using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Votacion_de_partidos
{
    class Program
    {
        static void Main()
        {
            //Entrada principal

            Console.WriteLine("ingrese el numero de votos del partido 1 ");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("ingrese el numero de votos del partido 2 ");
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine("ingrese el numero de votos en blanco ");
            int blanco = int.Parse(Console.ReadLine());

            Console.WriteLine("ingrese el numero de votos anulados ");
            int nule = int.Parse(Console.ReadLine());

            Console.WriteLine("ingrese el numero total de poblacion ");
            int totpob = int.Parse(Console.ReadLine());

            int votos = (a + b + blanco + nule);

            int dif = a - b;

            //Si el total de votos es superior al total de la población
            bool c1 = (votos > totpob);
            //La diferencia de votos entre el partido 1 y 2 es menor al 10% de los votos totales
            bool c2 = Math.Abs(dif) < (votos * 0.1);
            //El número de votantes es inferior al 30% de la población
            bool c3 = (votos > (totpob * 0.3));

            //Numero de votos tiene que ser menor a la poblacion total por ejemplo, votantes 30 - totpob 200
            //La diferencia osea p1 menos p2 tiene que ser menor a el 10% de la poblacion total por ejemplo 30-20=10 y tot pob *10% =20
            //los votantes totales son menos de el 30% de tot pob osea totpob * 0.3 = 60 por lo tanto votantes totales debe ser en este caso mx 59 personas 

            //Salida

            if ((c1 || c2) && c3)
            {
                Console.WriteLine("Tecnicamente todo esta bien, pero como que algo no me cuadra");
            }
            else
            {
                if (a > b)
                {
                    Console.WriteLine("Gano el partido 1");
                }
                else Console.WriteLine("Gano el partido 2");

            }
            Console.WriteLine(c1);
            Console.WriteLine(c2);
            Console.WriteLine(c3);
        }
    }
}
