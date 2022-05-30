using System;

namespace Singleton
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var customerManager = CustomerManager.CreateAsSingleton();
            customerManager.Save();

        }
    }

    class CustomerManager
    {
        private static CustomerManager _customerManager;
        private CustomerManager()
        {

        }

        public static CustomerManager CreateAsSingleton()
        {
            if (_customerManager == null)
	        {
                    _customerManager = new CustomerManager();
	        }
            return _customerManager;
        }

        public  void Save()
        {
            Console.WriteLine("Saved!");

        }
    }  
}

