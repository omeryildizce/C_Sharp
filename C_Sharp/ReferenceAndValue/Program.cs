using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReferenceAndValue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number1 = 10;
            int number2 = 20;
            number2 = number1;
            number1 = 30;
            // number1 = 30, number2 =10
            Console.WriteLine("Number 1:{0}, Number 2:{1}",number1, number2);

            string[] cities1 = new string[] {"Adana", "Ağrı", "Ankara", "Antalya" };
            string[] cities2 = new string[] { "Balıkesir", "Bartın", "Bursa", "Bolu" };
            cities2 = cities1;
            cities1[0] = "İstanbul";
            cities1[1] = "İzmir";


            foreach (string city in cities2)
            {
                Console.WriteLine(city);
            }
        }
    }
}
