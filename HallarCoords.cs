using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trabajo_en_clase_arreglo_de_datos
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] CoordsX = { 0, 2, 3, 7 }, CoordsY = { 0, 1, 5, 6 };

            double m1 = (CoordsY[1] - CoordsY[0]) / (CoordsX[1] - CoordsX[0]);
            double m2 = (CoordsY[2] - CoordsY[1]) / (CoordsX[2] - CoordsX[1]);
            double m3 = (CoordsY[3] - CoordsY[2]) / (CoordsX[3] - CoordsX[2]);

            double b1 = (CoordsY[0] - (m1 * CoordsX[0]));
            double b2 = (CoordsY[1] - (m2 * CoordsX[1]));
            double b3 = (CoordsY[2] - (m3 * CoordsX[2]));


            double dx1 = (CoordsX[1] - CoordsX[0]), dx2 =(CoordsX[2] - CoordsX[1]), dx3 = (CoordsX[3] - CoordsX[2]);
            double dy1 = (CoordsY[1] - CoordsY[0]), dy2 = (CoordsY[2] - CoordsX[1]), dy3 = (CoordsY[3] - CoordsY[2]);

            double d1 = Math.Sqrt((dx1 * dx1) + (dy1 * dy1)), d2 = Math.Sqrt((dx2 * dx2) + (dy2 * dy2)), d3 = Math.Sqrt((dx3 * dx3) + (dy3 * dy3));



            
            Console.WriteLine("Las pendientes de la recta 1, 2 y 3 son: " + m1 + ", " + m2 + " y " + m3);
            Console.WriteLine("Y sus interceptos respectivos son: " + b1 + ", " + b2 + " y " + b3);


            if ( m1 * b1 == m2 * b2)
            {
                Console.WriteLine("La recta 1 y 2 pertenecen a la misma recta");
            }
            else Console.WriteLine("La recta 1 y 2  no pertenecen a la misma recta");

            if (m2 * b2 == m3 * b3)
            {
                Console.WriteLine("La recta 2 y 3 pertenecen a la misma recta");
            }
            else Console.WriteLine("La recta 2 y 3  no pertenecen a la misma recta");

            if (m1 * b1 == m3 * b3)
            {
                Console.WriteLine("La recta 1 y 3 pertenecen a la misma recta");
            }
            else Console.WriteLine("La recta 1 y 3 no pertenecen a la misma recta");

            // Mayor distancia
            if (d1 > d2 && d1 > d3)Console.WriteLine("La recta con mayor distancia es: d1 " + d1);

            else if (d1 < d2 && d2 > d3) Console.WriteLine("La recta con mayor distancia es: d2 " + d2);

            else Console.WriteLine("La recta con mayor distancia es: d3 " + d3);

        }
    }
}
