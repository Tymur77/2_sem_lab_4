using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading;
using System.IO;

namespace TestApplication
{

    class Program
    {
        static StreamWriter writer1;
        static StreamWriter writer2;
        static bool stop = false;

        static void Main(string[] args)
        {
            writer1 = new StreamWriter("fibonacci.txt");
            writer2 = new StreamWriter("prime.txt");

            Thread t1 = new Thread(Fibonacci);
            Thread t2 = new Thread(Prime);

            t1.Start();
            t2.Start();

            Console.ReadLine();

            stop = true;

            writer1.Close();
            writer2.Close();

            int lines;
            lines = File.ReadLines("fibonacci.txt").Count();
            Console.WriteLine("{0} fibonacci numbers found", lines);
            lines = File.ReadLines("prime.txt").Count();
            Console.WriteLine("{0} prime numbers found", lines);
        }

        static void Fibonacci()
        {
            ulong a = 0;
            ulong b = 1;

            while (true)
            {
                if (stop)
                    return;

                ulong c = a + b;
                writer1.WriteLine(c);
                a = b;
                b = c;
            }
        }

        static void Prime()
        {
            ulong number = 2;
            while (true)
            {
                if (stop)
                    return;

                bool isPrime = true;
                for (uint i = 2; i < number; i++)
                {
                    if (number % i == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }

                if (isPrime)
                    writer2.WriteLine(number);

                number++;
            }
        }

    }
}
