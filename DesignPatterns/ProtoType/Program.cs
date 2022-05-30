using System;

namespace ProtoType
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer() { FirstName = "ömer", LastName="YILDIZ", City="Ankara", Id= 1};
            Console.WriteLine(customer.FirstName);

            var customer2 = customer.Clone();
            customer2.FirstName = "No Name";

            var customer3 = (Customer)customer.Clone();
            customer3.City = "Van";

            Console.WriteLine(customer.FirstName);
            Console.WriteLine(customer2.FirstName);



        }
    }
    public abstract class Person
    {
        public abstract Person Clone();
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

    }
    public class Customer : Person
    {
        public string City { get; set; }

        public override Person Clone()
        {
            return (Person)MemberwiseClone();

        }
    }
    public class Employee : Person
    {
        public decimal Salary { get; set; }

        public override Person Clone()
        {
            return (Person)MemberwiseClone();

        }
    }

}
