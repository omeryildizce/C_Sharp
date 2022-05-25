using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Add();

            //// add2
            //int sum = Add2(20, 30);
            //Console.WriteLine("Toplam {0}", sum);

            //// add3 reference type: ref or out
            //int number1 = 20;
            //int number2 = 100;
            //var result = Add3(ref number1, number2);
            //Console.WriteLine(result);
            //Console.WriteLine(number1);


            // method overloading
            Console.WriteLine(Multiply(2, 4));
            Console.WriteLine(Multiply(2, 4, 8));
            Console.WriteLine(Multiply(2.5, 3.7, 10));


            // params
            Console.WriteLine(Params(5,2,3,4,5,6,7,8,9,10,11));
        }
        static int Params(int number1 = 0, params int[] numbers)
        {
            return numbers.Sum() * number1;
        }
        static int Multiply(int number1, int number2)
        {
            return number1 * number2;
        }
        static int Multiply(int number1, int number2, int number3)
        {
            return number1 * number2 * number3;
        }
        static double Multiply(double number1, double number2, double number3)
        {
            return number1 * number2 * number3;
        }
        private static void Add()
        {
            Console.WriteLine("Added!!!");
        }

        static int Add2(int number1 = 0, int number2 = 0)
        {
            return number1 + number2;
        }

        static int Add3(ref int number1, int number2)
        {
            number1 = 30;
            return (number1 + number2);
        }
    }
}
