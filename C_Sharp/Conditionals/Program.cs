using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conditionals
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // if örneği
            IfMethod();

            // if ve else if örneği 
            var not = 70;
            HarfNotuHesaplama(not);

            // switch
            var number = 20;
            SwitchMethod(number);

            // Demo
            number = 25;
            AndOr(number);

            // iç içe if 
            if (number <= 100)
            {
                Console.WriteLine("Harf Notu");
                if (number >=90 )
                {
                    Console.WriteLine("A");
                }

                else if (number >= 75)
                {
                    Console.WriteLine("B");
                }

                else if (number >= 60)
                {
                    Console.WriteLine("C");
                }
                else if (number >= 0)
                {
                    Console.WriteLine("F");
                }
            }

        }

        private static void AndOr(int number)
        {
            if (number >= 0 && number <= 100)
            {
                Console.WriteLine("Number is between 0-100");
            }
            else if (number > 100 && number <= 200)
            {
                Console.WriteLine("Number is between 101-200");

            }
            else if (number > 200 || number < 0)
            {
                Console.WriteLine("Number is less than 0 or greater than 201");
            }
        }

        private static void SwitchMethod(int number)
        {
            switch (number)
            {
                case 10:
                    Console.WriteLine("number is 10");
                    break;

                case 20:
                    Console.WriteLine("number is 20");
                    break;

                case 30:
                    Console.WriteLine("number is 30");
                    break;

                default:
                    Console.WriteLine("Number is not 10,20 and 30");
                    break;
            }
        }

        private static void HarfNotuHesaplama(int not)
        {
            if (not >= 90)
            {
                Console.WriteLine("A");
            }
            else if (not >= 75)
            {
                Console.WriteLine("B");
            }
            else if (not >= 60)
            {
                Console.WriteLine("C");
            }
            else
            {
                Console.WriteLine("F");
            }
        }

        private static void IfMethod()
        {
            var number = 10;

            if (number == 10)
            {
                Console.WriteLine("Number is 10");
            }
            else
            {
                Console.WriteLine("Number is not 10");
            }
            Console.WriteLine();

            // single line
            number = 11;
            Console.WriteLine(number == 10 ? "Number is 10" : "Number is not 10");
        }
    }
}
