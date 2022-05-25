using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Intro();

            string sentence = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.";

            Console.WriteLine(sentence.Length); // karakter sayısı
            Console.WriteLine(sentence.Clone()); //  kopyalar
            Console.WriteLine(sentence.EndsWith(".")); 
            Console.WriteLine(sentence.StartsWith("l"));
            Console.WriteLine(sentence.IndexOf("dummy")); // dummy kelimesinin indeksini bulur
            Console.WriteLine(sentence.LastIndexOf("dummy")); // sondan başlayarak arama yapar
            Console.WriteLine(sentence.Insert(0, "Hello, ")); // metine ekleme yapılır
            Console.WriteLine(sentence.Substring(400)); // 400. indeksden sonra olan metni alır 
            Console.WriteLine(sentence.Substring(22,5)); // 20. karakterden sonra 5 karakter al 
            Console.WriteLine(sentence.ToLower());
            Console.WriteLine(sentence.ToUpper());
            Console.WriteLine(sentence.Replace(" ", "_")); // boşluk yerine alt tire işareti koyulur
            Console.WriteLine(sentence.Remove(5));
            Console.WriteLine(sentence.Remove(2,4));



        }

        private static void Intro()
        {
            string city = "Ankara";
            Console.WriteLine(city[0]);

            foreach (char item in city)
            {
                Console.WriteLine(item);
            }

            string city2 = "İstanbul";
            string result = city + city2;
            Console.WriteLine(result);
        }
    }
}
