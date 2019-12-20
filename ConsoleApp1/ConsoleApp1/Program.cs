using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        }
    }
}
