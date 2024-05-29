using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apuestas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double montmen = 0, montmay = 0, monto;
            int contjug = 0;
            string jugmay = "";
            string jugmen = "";
            string apos;

            Console.WriteLine("Ingrese el nombre del apostador o fin para terminar");
            apos = Console.ReadLine();
            while (apos != "fin")
            {
                Console.WriteLine("Ingrese el monto ganado en ronda");
                monto = Convert.ToDouble(Console.ReadLine());
                contjug = contjug++;
                if (contjug == 1)
                {
                    montmay = monto;
                    montmen = monto;
                    jugmen = apos;
                    jugmay = apos;
                }
                else
                {
                    if (monto > montmay)
                    {
                        montmay = monto;
                        jugmay = apos;
                    }
                    if (monto < montmen)
                    {
                        montmen = monto;
                        jugmen = apos;
                    }
                }
                Console.WriteLine("Ingrese el nombre del apostador o fin para terminar");
                apos = Console.ReadLine();
            }

            Console.WriteLine("El apostador con el monto mayor en apuesta es: {0} ", jugmay);
            Console.WriteLine("El apostador con el monto menor en apuesta es: {0} ", jugmen);
            
            Console.ReadKey();
        } 
    }
}
