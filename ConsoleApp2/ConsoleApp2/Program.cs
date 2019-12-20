using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Task1 skaiciu suma
            int skaiciuSuma = 0;
            Console.Write("Iveskite skaiciu: ");
            int betKoksSkaicius = Convert.ToInt32(Console.ReadLine());
            for (int ciklas = 1; ciklas <= betKoksSkaicius; ciklas++)
            {
                skaiciuSuma += ciklas;
            }
            Console.WriteLine("Skaiciu suma yra {0}", skaiciuSuma);
            Console.ReadLine();

            //Task2 isveda lyginius skaicius
            Console.Write("Iveskite bet koki skaiciu: ");
            int betKoksSkaicius1 = Convert.ToInt32(Console.ReadLine());
            for (int ciklas1 = 0; ciklas1 <= betKoksSkaicius1; ciklas1 += 2)
            {
                Console.Write(", {0}", ciklas1);
            }
            Console.WriteLine();
            Console.WriteLine("Pabaiga");
            Console.ReadLine();

        }
    }
}
