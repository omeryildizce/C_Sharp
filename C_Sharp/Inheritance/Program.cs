using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person[] people = new Person[3]
            {
                new Customer{Id=1, FirstName="Ali", LastName="Demir", City="Van"},
                new Student{Id=2,FirstName="Ömer", LastName="YILDIZ", Department="Engineer" },
                new Person{Id=3, LastName="Kaya", FirstName="Betül" }
            };


            foreach (var person in people)
            {
                Console.WriteLine( person.FirstName+" "+ person.LastName);
            }
        }
    }

    class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }


    class Customer : Person 
    {
        public string City { get; set; }
    }

    class Student : Person
    {
        public string Department { get; set; }
    }
}
