using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // for 
            //ForLoop();

            // while
            //WhileLoop();

            // Do while
            //DoWhileLoop();

            // ForEach
            // ForEachLoop();

            // prime number
            Console.WriteLine("Sayı giriniz:");
            int number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Verilen sayıya kadar olan sayılar:");

            PrimeNumber(number);

            Console.WriteLine("\n");
        }

        private static void PrimeNumber(int number)
        {
            if (number >= 2)
            {
                int sum = 0;
                int total = 0;
                for (int i = 2; i <= number; i++)
                {
                    total = 0;
                    for (int j = 2; j < i; j++)
                    {
                        if (i % j == 0)
                        {
                            total++;

                        }
                    }

                    if (total == 0)
                    {
                        Console.Write("{0} ", i);
                        sum++;

                    }
                }
                Console.WriteLine("\n{0} tane asal sayı var", sum);

            }
        }

        private static void ForEachLoop()
        {
            string[] cars = new string[3] { "Audi", "BMW", "Lotus" };

            foreach (var car in cars)
            {
                Console.WriteLine(car);
            }
            Console.WriteLine("\n");
        }

        private static void DoWhileLoop()
        {
            int number = 10;
            do
            {
                Console.WriteLine(number);
                number--;
            } while (number >= 0);
            Console.WriteLine("\n");
        }

        private static void WhileLoop()
        {
            int number = 100;
            while (number >= 0)
            {
                Console.WriteLine(number);
                number--;
            }
            Console.WriteLine("\n");
        }

        private static void ForLoop()
        {
            // 1-100 arası tüm sayılar
            for (int i = 1; i <= 100; i++)
            {
                Console.Write("{0} ", i);
            }

            Console.WriteLine("\n");
            // 1-100 arası tek sayılar
            for (int i = 1; i <= 100; i += 2)
            {
                Console.Write("{0} ", i);
            }

            Console.WriteLine("\n");

            // 100-1 arası çift sayılar
            for (int i = 100; i > 0; i -= 2)
            {
                Console.Write("{0} ", i);
            }

            Console.WriteLine("\n");
        }
    }
}

