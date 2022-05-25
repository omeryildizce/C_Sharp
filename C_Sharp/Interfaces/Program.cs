using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // InterfacesIntro();

            // DifDatabase();

            ICustomerDal[] customerDals = new ICustomerDal[]
            {
                new SqlServerCustomerDal(),
                new OracleCustomerDal(), 
                new MySqlCustomerDal()
            };

            // save to all database systems
            foreach (var customerDal in customerDals)
            {
                customerDal.Add();
            }


        }

        private static void DifDatabase()
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(new SqlServerCustomerDal());
            customerManager.Update(new OracleCustomerDal());
        }

        private static void InterfacesIntro()
        {
            PersonManager personManager = new PersonManager();
            Customer customer = new Customer
            {
                Id = 1,
                FirstName = "Ömer",
                LastName = "YILDIZ",
                Address = "Ankara"
            };
            personManager.Add(customer);


            Student student = new Student
            {
                Id = 1,
                FirstName = "Ali",
                LastName = "Kaya",
                Departmant = "Computer Sciences"
            };

            personManager.Add(student);


            Worker worker = new Worker
            {
                Id = 1,
                FirstName = "Ahmet",
                LastName = "Kayın"
            };
            personManager.Add(worker);
        }
    }

    interface IPerson
    {
        int Id { get; set; }
        string FirstName { get; set; }
        string LastName { get; set; }
    }

    class Customer : IPerson
    {
        public int Id { get ; set ; }
        public string FirstName { get; set ; }
        public string LastName { get ; set ; }
        public string Address { get; set; }
    }

    class Student : IPerson
    {
        public int Id { get ; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Departmant { get; set; }
    }
    class Worker : IPerson
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Departmant { get; set; }
    }


    class PersonManager
    {
        public void Add(IPerson person)
        {
            Console.WriteLine(person.FirstName);
            
        }
    }
}
