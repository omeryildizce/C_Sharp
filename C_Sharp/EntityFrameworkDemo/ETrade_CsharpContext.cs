using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkDemo
{
    public class ETrade_CsharpContext:DbContext
    {
        public DbSet<Product> Products { get; set; }

    }
}
