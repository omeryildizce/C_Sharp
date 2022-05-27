using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Utilities utilites = new Utilities();
            List<string> result = utilites.BuildList<string>("Ankara", "İzmir", "Adana");
            List<int> result1 = utilites.BuildList<int>(2,3,5,7,9,11);

            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
            foreach (var item in result1)
            {
                Console.WriteLine(item);
            }

            List<Customer> result2 = utilites.BuildList<Customer>(new Customer { FirstName="Ahmet"}, new Customer { FirstName = "Mehmet" });
            foreach (var customer in result2)
            {
                Console.WriteLine(customer.FirstName);
            }
        }
    }
    class Utilities
    {
        public List<T> BuildList<T>(params T[] items)
        {
            return new List<T>(items);
        }
    }
    class Product
    {

    }
    interface IProductDal:IRepository<Product>
    {
        
         
    }

    class Customer:IEntity
    {
        public string FirstName { get; set; }

    }
    interface ICustomerDal:IRepository<Customer>
    {


    }
    interface IStudentDal:IRepository<Student> 
    {

    }
    class Student:IEntity
    {

    }
    interface IEntity
    {

    }

    interface IRepository<T> where T : class,IEntity, new() // class reference type
    {
        List<T> Getall();
        T Get(int id);

        void Add(T entity);
        void Delete(T entity);
        void Update(T entity); 
    }

    class ProductDal : IProductDal
    {
        public void Add(Product entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Product entity)
        {
            throw new NotImplementedException();
        }

        public Product Get(int id)
        {
            throw new NotImplementedException();
        }

        public List<Product> Getall()
        {
            throw new NotImplementedException();
        }

        public void Update(Product entity)
        {
            throw new NotImplementedException();
        }
    }
    class CustomerDal : ICustomerDal
    {
        public void Add(Customer entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Customer entity)
        {
            throw new NotImplementedException();
        }

        public Customer Get(int id)
        {
            throw new NotImplementedException();
        }

        public List<Customer> Getall()
        {
            throw new NotImplementedException();
        }

        public void Update(Customer entity)
        {
            throw new NotImplementedException();
        }
    }
}
