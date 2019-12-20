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

            //Task3 isveda teksta atbuline tvarka
            string tekstas;
            Console.Write("Iveskite teksta: ");
            tekstas = Console.ReadLine();

            for (int t = tekstas.Length-1; t >= 0; t--)
            {
                char a = tekstas[t];
                Console.Write("{0}", a);
            }
            Console.WriteLine();
            Console.WriteLine("Pabaiga");
            Console.ReadLine();

            //Task4 ciklas cikle
            int betKoksSkaicius2;
            Console.Write("Iveskite skaiciu: ");
            betKoksSkaicius2 = Convert.ToInt32(Console.ReadLine());

            for (string ask = y; ; ask == y)
            {
                for (int daugiklis = 0; ask = y; daugiklis++)
                {
                    Console.WriteLine("{0} x {1} = {2}", betKoksSkaicius2, daugiklis, betKoksSkaicius2 * daugiklis);
                }
                Console.Write("Ar norite testi? y/n");
                ask = Console.ReadLine();
            }


        }
    }
}
