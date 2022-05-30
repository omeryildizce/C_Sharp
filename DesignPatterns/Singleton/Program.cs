﻿using System;

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
        static object _lockObject = new object();
        private CustomerManager()
        {

        }

        public static CustomerManager CreateAsSingleton()
        {

            lock (_lockObject)
            {
                if (_customerManager == null)
                {
                    _customerManager = new CustomerManager();
                }
              }
            return _customerManager;
        }

        public void Save()
        {
            Console.WriteLine("Saved!");

        }
    }
}

