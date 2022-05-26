using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ctor1();
            //Ctor2();
            //Ctor3();

            Teacher.Number = 45;

            Manager manager = new Manager();
            manager.Do2();

            Manager.Do(); // static
        }

        private static void Ctor3()
        {
            PersonManager personManager = new PersonManager("product");
            personManager.Add();
        }

        private static void Ctor2()
        {
            EmployeeManager employeeManager = new EmployeeManager(new DatabaseLogger());
            employeeManager.Add();
        }

        private static void Ctor1()
        {
            CustomerManager customerManager = new CustomerManager(25);
            customerManager.Add();
            customerManager.List();

            Product product = new Product();
            product.Name = "Laptop";
            // or
            Product product1 = new Product { Id = 5, Name = "TV" };
            // or
            Product product2 = new Product(8, "Phone");
        }
    }
    static class Teacher
    {
        public static int Number { get; set; }
    }
    static class Utilities
    {
        public static void Validate()
        {
            Console.WriteLine("Validation is done");
        }
    }
    class Manager
    {
        public static void Do()
        {
            Console.WriteLine("Done");
        }
        public void Do2()
        {
            Console.WriteLine("Done 2");
        }
    }
    class CustomerManager
    {
        private int _count = 25;
        public CustomerManager(int count)
        {
            _count = count;
        }

        public CustomerManager()
        {

        }
        public void List()
        {
            Console.WriteLine("Listed {0} items", _count);
        }

        public void Add()
        {
            Console.WriteLine("Added! ");
        }
    }

    class Product
    {
        public Product()
        {

        }
        int _id;
        string _name;
        public Product(int id, string name)
        {
            _id = id;
            _name = name;
        }
        public int Id { get; set; }
        public string Name { get; set; }

    }

    interface ILogger
    {
        void Log();
    }

    class DatabaseLogger : ILogger
    {
        public void Log()
        {
            Console.WriteLine("Logged to dataabase");
        }
    }

    class FileLogger : ILogger
    {
        public void Log()
        {
            Console.WriteLine("Logged to file");
        }
    }
    class EmployeeManager
    {
        private ILogger _logger;
        public EmployeeManager(ILogger logger)
        {
            _logger = logger;
        }
        public void Add()
        {
            _logger.Log();
            Console.WriteLine("Added");
        }

    }

    class BaseClass
    {
        string _entity;
        public BaseClass(string entity)
        {
            _entity = entity;
        }
        public void Message()
        {
            Console.WriteLine("{0} message", _entity);
        }
    }
    class PersonManager : BaseClass
    {
        public PersonManager(string entity) : base(entity)
        {

        }

        public void Add()
        {
            Console.WriteLine("Added!!!");
            Message();
        }
    }
}
