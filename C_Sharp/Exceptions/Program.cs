using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ExceptionIntro();


            // ActionDemo();

            Func<int, int, int> add = Topla ;
            Console.WriteLine(add(3,5));
            Func<int> getRandomNumber = delegate ()
            {
                Random random = new Random();
                return random.Next(1, 100);

            };
            Console.WriteLine(getRandomNumber());

            Func<int> getRandomNumber2 = () => new Random().Next(1, 100);
            Console.WriteLine(getRandomNumber2());
        }
        static int Topla(int x , int y)
        {
            return x + y;
        }

        private static void ActionDemo()
        {
            HandleException(() =>
            {
                Find();

            });
        }

        private static void HandleException(Action p)
        {
            try
            {
                p.Invoke();
            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message); ;
            }
        }

        private static void Find()
        {
            string name = "Hüseyin";

            List<string> students = new List<string> { "Engin", "Ömer", "Semih" };
            if (!students.Contains(name))
            {
                throw new RecordNotFound("Record not found!");
            }
            else
            {
                Console.WriteLine("Record found");
            }
        }

        private static void ExceptionIntro()
        {
            try
            {
                string[] student = new string[3] { "Ömer", "Hüseyin", "Semih" };

                student[3] = "Ahmet";
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine(e.InnerException);
                Console.WriteLine("Hata");
            }
        }
    }
}
