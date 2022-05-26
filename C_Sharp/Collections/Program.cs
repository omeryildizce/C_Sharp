using System;
using System.Collections; // araylist
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // ArrayListEx();

            // ListEX();

           // ListSpecs();

            Dictionary<string, string> dic = new Dictionary<string, string>();
            dic.Add("book", "kitap");
            dic.Add("table", "tablo");
            dic.Add("computer", "bilgisayar");

            Console.WriteLine(dic["book"]);
            foreach (var item in dic)
            {
                Console.WriteLine(item.Value);
            }
            Console.WriteLine(dic.ContainsKey("table"));
            Console.WriteLine(dic.ContainsValue("tablo"));
            

        }

        private static void ListSpecs()
        {
            List<Customer> customers = new List<Customer>
            {
                new Customer {Id = 1, FirstName = "Ömer"},
                new Customer {Id = 2, FirstName = "Hüseyin"},
                new Customer {Id=3, FirstName = "Semih"}
            };

            // specs
            Console.WriteLine(customers.Count());
            customers.Add(new Customer { Id = 4, FirstName = "Hakan" });

            var customer = new Customer
            {
                Id = 5,
                FirstName = "Ahmet"
            };
            customers.Add(customer);
            customers.AddRange(new Customer[2]
            {
                new Customer {Id = 6, FirstName ="Salih"},
                new Customer {Id = 7, FirstName ="Can"}
            });

            // customers.Clear(); // remove list
            Console.WriteLine(customers.Contains(customer));

            Console.WriteLine(customers.IndexOf(customer));
            Console.WriteLine(customers.LastIndexOf(customer));
            customers.Insert(0, new Customer { Id = 8, FirstName = "Aynur" });
            customers.Remove(customer);
            customers.RemoveAll(c => c.FirstName == "Can");
            foreach (var customer1 in customers)
            {
                Console.WriteLine(customer1.FirstName);
            }
            Console.WriteLine(customers.Count());
        }

        private static void ListEX()
        {
            throw new NotImplementedException();
        }

        private static void ListEx()
        {
            List<string> cities = new List<string>();
            cities.Add("Ankara");
            cities.Add("İstanbul");
            cities.Add("İzmir");



            foreach (var city in cities)
            {
                Console.WriteLine(city);
            }
            List<Customer> customers = new List<Customer>();
            customers.Add(new Customer { Id = 1, FirstName = "Ömer" });
            customers.Add(new Customer { Id = 2, FirstName = "Hüseyin" });

            foreach (var customer in customers)
            {
                Console.WriteLine(customer.FirstName);
            }
        }

        private static void ArrayListEx()
        {
            ArrayList cities = new ArrayList();
            cities.Add("Ankara");
            cities.Add("Adana");


            cities.Add("İstanbul");
            Console.WriteLine(cities[2]);

            cities.Add(45);
            Console.WriteLine(cities[3]);

            foreach (var city in cities)
            {
                Console.WriteLine(city);
            }
        }
    }

    class Customer
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
    }
}
