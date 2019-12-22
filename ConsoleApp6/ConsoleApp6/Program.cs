using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] skaiciuMasyvas = new int[100];
            Random rnd = new Random();

            for (int i = 0; i <= skaiciuMasyvas.Length-1; i++)
            {
                int a = rnd.Next(1, 1000);
                skaiciuMasyvas[i] = a;
            }

            foreach (var item in skaiciuMasyvas)
            {
                Console.Write("{0} ", item);
            }
            Console.WriteLine();
            Console.ReadLine();

            int temp = 0;

            for (int i = 0; i <= skaiciuMasyvas.Length - 1; i++)
            {
                for (int h = i; h <= skaiciuMasyvas.Length - 1; h++)
                {

                    if (skaiciuMasyvas[i] > skaiciuMasyvas[h])
                    {
                        temp = skaiciuMasyvas[h];
                        skaiciuMasyvas[h] = skaiciuMasyvas[i];
                        skaiciuMasyvas[i] = temp;
                    }
                }
            }

            Console.WriteLine("Didziausias skaicius yra {0}", skaiciuMasyvas[skaiciuMasyvas.Length - 1]);
            Console.WriteLine("Maziausias skaicius yra {0}", skaiciuMasyvas[0]);
            
            foreach (var item in skaiciuMasyvas)
            {
                Console.Write("{0} ", item);
            }
            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
