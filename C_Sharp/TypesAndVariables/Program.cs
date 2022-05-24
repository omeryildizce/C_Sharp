using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypesAndVariables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Value Types
            int number1 = 10;
            Console.WriteLine("Number 1 : {0}", number1);

            // integer
            int minint = int.MinValue;
            int maxint = int.MaxValue;

            Console.WriteLine("int min:{0} max:{1}",minint, maxint);
            Console.WriteLine();

            // long
            long minlong = long.MinValue;
            long maxlong = long.MaxValue;

            Console.WriteLine("long min:{0} max:{1}", minlong, maxlong);
            Console.WriteLine();

            // short
            short minshort = short.MinValue;
            short maxshort = short.MaxValue;

            Console.WriteLine("short min:{0} max:{1}", minshort, maxshort);
            Console.WriteLine();

            // byte
            byte minbyte = byte.MinValue;
            byte maxbyte = byte.MaxValue;

            Console.WriteLine("byte min:{0} max:{1}", minbyte, maxbyte);
            Console.WriteLine();

            // byte
            bool false1 = false;
            bool true1 = true;

            Console.WriteLine("bool {0}, {1}", false1, true1);
            Console.WriteLine();

            // char 
            char minchar = char.MinValue;
            char maxchar = char.MaxValue;

            Console.WriteLine("char min:'{0}'={1} max:'{2}'={3}", minchar, (int)minchar, maxchar, (int)maxchar);
            Console.WriteLine();

            // double 
            double mindouble = double.MinValue;
            double maxdouble = double.MaxValue;

            Console.WriteLine("double min:{0} max:{1}", mindouble, maxdouble);
            Console.WriteLine();

            // decimal
            decimal mindecimal = decimal.MinValue;
            decimal maxdecimal = decimal.MaxValue;

            Console.WriteLine("decimal min:{0} max:{1}", mindecimal, maxdecimal);
            Console.WriteLine();

            // enum
            Console.WriteLine(Days.Monday);
            Console.WriteLine((int)Days.Monday);

            // var
            var number = 10;
            Console.WriteLine("var: {0}",number);
            number = 'A';
            Console.WriteLine("var: {0}",(char)number);
        }


        enum Days
        {
            Monday = 1, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday 
        }
    }
}
