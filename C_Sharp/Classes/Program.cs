using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.Add();
            customerManager.Update();

            Console.WriteLine("-----------------");

            ProductManager productManager = new ProductManager(); 
            productManager.Add();
            productManager.Update();

            Console.WriteLine("-----------------");
            // property

            Customer customer = new Customer();

            customer.Id = 1;
            customer.FirstName = "Ali";
            customer.LastName = "YILDIZ";
            customer.City = "Van";

            Console.WriteLine(customer.FirstName);

            // 2. yol
            Customer customer2 = new Customer 
            {
                Id = 2,
                FirstName = "Ömer",
                LastName = "Yıldız",
                City = "Ankara"
            };

            Console.WriteLine(customer2.FirstName);
        }
    }
}
