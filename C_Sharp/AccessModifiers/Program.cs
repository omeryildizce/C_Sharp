using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifiers
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }


    class Customer
    {
        private int IdPrivate; // Sadece tanımlandığı blokta kullanılabilir 
        protected int IdProtected; //  kalıtım olan sınıflarda kullanılabilir
        
        public void Save()
        {

        }
    }

    class Student:Customer
    {
        public void Save()
        {
            Customer customer = new Customer();
            
            

        }

        public void Save2()
        {
            IdProtected = 1;

        }
    }

    internal class Course // default internal
    {                      // bağlı olduğu proje içinde kullanılabilir 
        public string Name { get; set; }

        // classlar, sadece iç içe olan classlarda private olabilir

        private class NestedClass
        {

        }

        
    }

    public class Course2
    {
        public int MyProperty { get; set; }
    }
}
