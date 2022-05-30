using System;

namespace AbstractFactory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ProductManager productManager = new ProductManager(new Factory1());
            productManager.GetAll();
        }
    }
    public abstract class Logging
    {
        public abstract void Log(string message);
    }

    public class Log4NetLogger : Logging
    {
        public override void Log(string message)
        {
            Console.WriteLine("Logged with log4net!");
        }
    }
    public class NLogger : Logging
    {
        public override void Log(string message)
        {
            Console.WriteLine("Logged with nlogger!");
        }
    }
    public abstract class Caching
    {
        public abstract void Cache(string data);
    }
    public class MemCache : Caching
    {
        public override void Cache(string data)
        {
            Console.WriteLine("Cached with MemCache");
        }
    }

    public class RedisCache : Caching
    {
        public override void Cache(string data)
        {
            Console.WriteLine("Cached with Redis");
        }
    }

    public abstract class CrossCuttingConcernsFactory
    {
        public abstract Logging CreateLogger();
        public abstract Caching CreateCaaching();

    }
    public class Factory1 : CrossCuttingConcernsFactory
    {
        public override Caching CreateCaaching()
        {
            return new RedisCache();

        }

        public override Logging CreateLogger()
        {
            return new Log4NetLogger();

        }
    }

    public class Factory2 : CrossCuttingConcernsFactory
    {
        public override Caching CreateCaaching()
        {

            return new RedisCache();
        }

        public override Logging CreateLogger()
        {
            
            return new Log4NetLogger();
        }
    }

    public class ProductManager: IProductService
    {
        private CrossCuttingConcernsFactory _crossCuttingConcernsFactory;
        private Logging _logging;
        private Caching _caching;
        public ProductManager(CrossCuttingConcernsFactory crossCuttingConcernsFactory)
        {
            _crossCuttingConcernsFactory = crossCuttingConcernsFactory;
            _logging = _crossCuttingConcernsFactory.CreateLogger();
            _caching = _crossCuttingConcernsFactory.CreateCaaching();

        }
        public void GetAll()
        {

            _logging.Log("Logged");
            _caching.Cache("Caching");
            Console.WriteLine("Products listed!");
        }
    }

    public interface IProductService
    {
    }
}
