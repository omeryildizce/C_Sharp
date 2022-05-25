using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClasses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SqlServer sqlServer = new SqlServer();
            Oracle oracle = new Oracle();

            sqlServer.Add();
            oracle.Add();

            sqlServer.Delete();
            oracle.Delete();
        }
    }

    abstract class Database
    {
        public void Add()
        {
            Console.WriteLine("Added by default"); 
        }

        public abstract void Delete();
    }

    class SqlServer : Database
    {
        public override void Delete()
        {
            Console.WriteLine("Deleted by Sqlserver");
        }
    }

    class Oracle : Database
    {
        public override void Delete()
        {
            Console.WriteLine("Deleted by Oracle");
        }
    }

}
