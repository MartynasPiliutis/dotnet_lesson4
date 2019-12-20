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

        }
    }
}
