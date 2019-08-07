using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabajoenclase3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Calculadora de costos de seguro social

            Console.WriteLine("¿Es un trabajador dependiente (1) o independiente (2)?");
            int opcion = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese su sueldo total");
            double sueldo = double.Parse(Console.ReadLine());
            double bc = sueldo * 40 / 100;
            double pensionD = bc * 4 / 100;
            double pensionI = bc * 16 / 100;
            double epsD = bc * 4 / 100;
            double epsI = bc * 12.5 / 100;
            double arlD = bc * 0;
            double arl1 = bc * 0.522/100;
            double arl2 = bc * 1.022/100;
            double arl3 = bc * 2.436 / 100;
            double arl4 = bc * 4.350 / 100;
            double arl5 = bc * 6.960 / 100;
            double sueldord = (sueldo - pensionD - arlD - epsD);
            double dedd = pensionD + arlD + epsD;
            double ded1 = pensionD + arl1 + epsD;
            double ded2 = pensionD + arl2 + epsD;
            double ded3 = pensionD + arl3 + epsD;
            double ded4 = pensionD + arl4 + epsD;
            double ded5 = pensionD + arl5 + epsD;
            double sueldor1 = (sueldo - pensionD - arl1 - epsD);
            double sueldor2 = (sueldo - pensionD - arl2 - epsD);
            double sueldor3 = (sueldo - pensionD - arl3 - epsD);
            double sueldor4 = (sueldo - pensionD - arl4 - epsD);
            double sueldor5 = (sueldo - pensionD - arl5 - epsD);
            double sanuald = (sueldo + (sueldord * 12));
            double sanuali = (sueldo * 12);
                                   
            //Dependiente
            if (opcion == 1)
            {
                Console.WriteLine("Sueldo incial =" + sueldo);
                Console.WriteLine("Pago de Pension =" + pensionD);
                Console.WriteLine("Pago de EPS =" + epsD);
                Console.WriteLine("Pago de ARL =" + arlD);
                Console.WriteLine("Valor total de deduccion =" + dedd);
                Console.WriteLine("sueldo total despues de la pagar el seguro social =" + sueldord);
                Console.WriteLine("Sueldo anual con bonificaciones =" + sanuald);
            }
            //Independiente
            else
            {
                Console.WriteLine(" Seleccione el riesgo de trabajo que tiene (1,2,3,4,5)");
                double riesgo = double.Parse(Console.ReadLine());
                Console.WriteLine("Sueldo incial =" + sueldo);
                Console.WriteLine("Pago de Pension =" + pensionI);
                Console.WriteLine("Pago de EPS =" + epsI);
                Console.WriteLine("Salario anual con bonificacniones =" + sanuali);

                if (riesgo == 1)
                {
                    Console.WriteLine("Pago de ARL" + arl1);
                    Console.WriteLine("Valor total de deduccion =" + ded1);
                    Console.WriteLine("Sueldo total despues de pagar el seguro social =" + sueldor1);
                }
                if (riesgo == 2)
                {
                    Console.WriteLine("Pago de ARL" + arl2);
                    Console.WriteLine("Valor total de deduccion =" + ded2);
                    Console.WriteLine("Sueldo total despues de pagar el seguro social =" + sueldor2);
                }
                if (riesgo == 3)
                {
                    Console.WriteLine("Pago de ARL" + arl3);
                    Console.WriteLine("Valor total de deduccion =" + ded3);
                    Console.WriteLine("Sueldo total despues de pagar el seguro social =" + sueldor3);
                }
                if (riesgo == 4)
                {
                    Console.WriteLine("Pago de ARL" + arl4);
                    Console.WriteLine("Valor total de deduccion =" + ded4);
                    Console.WriteLine("Sueldo total despues de pagar el seguro social =" + sueldor4);
                }
                if (riesgo == 5)
                {
                    Console.WriteLine("Pago de ARL" + arl5);
                    Console.WriteLine("Valor total de deduccion =" + ded5);
                    Console.WriteLine("Sueldo total despues de pagar el seguro social =" + sueldor5);
                }


            }
        }
    }
}
