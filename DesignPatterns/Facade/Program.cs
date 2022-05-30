using System;

namespace Facade
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.Save();        }
    }
    class Logging : ILogging
    {
        public void Log()
        {
            Console.WriteLine("logged");
        }

    }

    internal interface ILogging
    {
        void Log();
    }
    internal interface ICaching
    {
        void Cache();
    }
    internal interface IAuthorize
    {
        void CheckUser();
    }
    class Caching : ICaching
    {
        public void Cache()
        {
            Console.WriteLine("cached");
        }

    }
    class Authorize : IAuthorize
    {
        public void CheckUser()
        {
            Console.WriteLine("user cheecked");
        }

    }
    class CustomerManager
    {
        CrossCuttingConcernsFacade _concerns;
        public CustomerManager()
        {
            _concerns = new CrossCuttingConcernsFacade();
        }
        public void Save()
        {
            _concerns.Caching.Cache();
            _concerns.Logging.Log();
            _concerns.Authorize.CheckUser();
            Console.WriteLine("Saved");
        }
    }

    class CrossCuttingConcernsFacade
    {
        public ILogging Logging;
        public ICaching Caching;
        public IAuthorize Authorize;
        public CrossCuttingConcernsFacade()
        {
            Logging = new Logging();
            Caching = new Caching();
            Authorize = new Authorize();
        }
    }
}
