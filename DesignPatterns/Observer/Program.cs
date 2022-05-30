using System;
using System.Collections.Generic;

namespace Observer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var customerObserver = new CustomerObserver();
           ProductManager productManager = new ProductManager();

            productManager.Attach(customerObserver);
            productManager.Attach(new EmployeeObserver());

            productManager.Detach(customerObserver);
            productManager.UpdatePrice();

        }
    }

    class ProductManager
    {
        List<Observer> _observer = new List<Observer>();

        public void UpdatePrice()
        {
            Console.WriteLine("product price changed!");
            Notify();

        }
        public void Attach(Observer observer)
        {
            _observer.Add(observer);
        }
        public void Detach(Observer observer)
        {
            _observer.Remove(observer);
        }
        private void Notify()
        {
            foreach (var observer in _observer)
            {
                observer.Update();
            }
        }
    }
    abstract class Observer
    {
        public abstract void Update();
    }
    class CustomerObserver : Observer
    {
        public override void Update()
        {
            Console.WriteLine("Message to Customer : product price changed!");
        }
    }
    class EmployeeObserver : Observer
    {
        public override void Update()
        {
            Console.WriteLine("Message to Employee : product price changed!");
        }
    }
}
