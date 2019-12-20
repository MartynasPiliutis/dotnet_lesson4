using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Example1 savaites dienu sarasas
            //string pirmadienis = "pirmadienis";

            string[] savaitesDienos =
            {
                "Pirmadienis",
                "Antradienis",
                "Treciadienis",
                "Ketvirtadienis",
                "Penktadienis",
                "Sestadienis",
                "Sekmadienis"
            };

            for (int i = 0; i < savaitesDienos.Length; i++)
            {
                Console.WriteLine(savaitesDienos[i]);
            }
            Console.ReadLine();

            //Example2 elemento keitimas

            Console.WriteLine("Pries:");
            foreach (var diena in savaitesDienos)
            {
                Console.WriteLine(diena);
            }

            savaitesDienos[2] = "TRECIADIENIS";

            Console.WriteLine("");
            Console.WriteLine("Po:");

            foreach (var diena in savaitesDienos)
            {
                Console.WriteLine(diena);
            }
            Console.ReadLine();

        }
    }
}
