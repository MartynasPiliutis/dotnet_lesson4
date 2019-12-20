using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Task1
            int[] skaiciuMasyvas = new int[5];
            for (int i = skaiciuMasyvas.Length - 1; i >= 0; i--)
            {
                Console.Write("Iveskite skaiciu: ");
                skaiciuMasyvas[i] = Convert.ToInt32(Console.ReadLine());
            }

            foreach (var skaicius in skaiciuMasyvas)
            {
                Console.Write("{0} ", skaicius);
            }
            Console.WriteLine();

            //Task2
            int suma = 0;

            foreach (var skaicius in skaiciuMasyvas)
            {
                suma += skaicius;
            }
            Console.Write("Suma: {0}", suma);
            Console.ReadLine();

            //Task3
            int[] skaiciuMasyvas2 = new int[10];
            for (int i1 = 0; i1 <= skaiciuMasyvas.Length - 1; i1++)
            {
                foreach (var skaicius in skaiciuMasyvas2)
                {
                    skaiciuMasyvas2[i1] = skaiciuMasyvas[i1];
                }
            }
            foreach (var skaicius in skaiciuMasyvas2)
            {
                Console.Write("{0} ", skaicius);
            }
            Console.ReadLine();
        }
    }
}
