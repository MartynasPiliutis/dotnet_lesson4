using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Example1
            for (int i = 10-1; i >= 0; i--)
            {
                Console.WriteLine("i reiksme: {0}", i);
            }
            Console.ReadLine();

            //Example2 pereina simbolius (ASCII kodavimo reiksmes)
            for (char c = 'a'; c <= 'z'; c++)
            {
                Console.WriteLine("c reiksme: {0}", c);
            }
            Console.ReadLine();

            //Example3 masyvo elementu kiekvieno paemimas

            string vardas = "Martynas";
            for (int v = 0; v < vardas.Length; v++)
            {
                char current = vardas[v];
                Console.WriteLine(current);
            }
            Console.ReadLine();

            //Example4 progres bar

            for (int p = 0; p<50; p++)
            {
                //Reikia prideti Using.System.Threading;
                Thread.Sleep(100); //milisekundemis
                Console.Write("#");
            }
            Console.WriteLine(); ;
            Console.WriteLine("Pabaiga");
            Console.ReadLine();
        }
    }
}
