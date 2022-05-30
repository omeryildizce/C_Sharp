using System;

namespace FactoryMethod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager(new LoggerFactory2());
            customerManager.Save(); 
        }
    }

    public class LoggerFactory : ILoggerFactory
    {
        public ILogger CreateLoger()
        {
            return new EdLogger();
        }
    }
    public class LoggerFactory2 : ILoggerFactory
    {
        public ILogger CreateLoger()
        {
            return new LogFNetLogger();
        }
    }

    public interface ILoggerFactory
    {
        ILogger CreateLoger();
    }

    public interface ILogger
    {
        void Log();
    }
    public class EdLogger : ILogger
    {
        public void Log()
        {
            Console.WriteLine("Logged with EdLogger");
        }
    }
    public class LogFNetLogger : ILogger
    {
        public void Log()
        {
            Console.WriteLine("Logged with LogFNetLogger");
        }
    }
    public class CustomerManager
    {
        private ILoggerFactory _loggerFactory;
        public CustomerManager(ILoggerFactory loggerFactory)
        {
            _loggerFactory = loggerFactory;
        }
        public void Save()
        {
            Console.WriteLine("Saved!");
            ILogger logger = _loggerFactory.CreateLoger();
            logger.Log();
        }
    }
}
