using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            int lu = 0;
            int alum = 0;
            double prom = 0;
            double promen = 0;
            double promay = 0;
            string nom = "";
            string menor = "";
            string mayor = "";

            Console.WriteLine("Ingrese la cantidad de alumnos");
            alum = Convert.ToInt32(Console.ReadLine());

            for (i = 1; i <= alum; i++)
            {
                Console.WriteLine("Ingrese el nombre del alumno");
                nom = Console.ReadLine();

                Console.WriteLine("Ingrese el promedio del alumno");
                prom = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Ingrese el número de libreta");
                lu = Convert.ToInt16(Console.ReadLine());

                if (i == 1)
                {
                    menor = nom;
                    mayor = nom;
                    promen = prom;
                    promay = prom;
                }
                else
                {
                    if (prom > promay)
                    {
                        mayor = nom;
                        promay = prom;
                    }
                    if (prom < promen)
                    {
                        promen = prom;
                        menor = nom;
                    }

                }
            }
            Console.WriteLine("El nombre del alumno con mayor promedio es: {0:C}", mayor);
            Console.WriteLine("El nombre del alumno con menor promedio es: {0:C}", menor);

            Console.ReadKey();
        }
    }
}
