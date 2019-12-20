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
            for (int i = 4; i >= 0; i--)
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
        }
    }
}
