using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //// Tek boyutlu dizi uygulamaları
            //TekBoyutluDizi();


            //// Çok boyutlu dizi uygulamaları
            string[,] regions = new string[7, 3]
            {
                {"İstanbul", "İzmit", "Balıkesir"},
                {"Ankara", "Konya", "Kırıkkale" },
                { "Antalya", "Adana","Mersin"},
                { "Trabzon", "Samsun", "Sinop"},
                {"İzmir" , "Muğla",  "Aydın"},
                {"Batman" , "Kahramanmaraş", "Şanlıurfa"},
                {"Erzurum", "Van", "Bitlis" }
            };

            for (int region = 0; region <= regions.GetUpperBound(0); region++)
            {
                for (int city = 0; city <= regions.GetUpperBound(1); city++)
                {
                    Console.WriteLine("{0}",regions[region, city]);
                }
                Console.WriteLine("*****************");
            }


        }

        private static void TekBoyutluDizi()
        {
            //string student1 = "Ömer";
            //string student2 = "Semih";
            //string student3 = "Hüseyin";

            // Array
            string[] students = new string[3];

            students[0] = "Ömer";
            students[1] = "Semih";
            students[2] = "Hüseyin";

            foreach (string student in students)
            {
                Console.WriteLine(student);
            }

            Console.WriteLine("-------------------------------");
            string[] students2 = new[] { "Ali", "Mehmet", "Ceyda" };
            foreach (var student in students2)
            {
                Console.WriteLine(student);
            }

            Console.WriteLine("-------------------------------");
            string[] students3 = { "Metin", "Ayşe", "Erdal" };
            foreach (var student in students3)
            {
                Console.WriteLine(student);
            }
        }
    }
}
