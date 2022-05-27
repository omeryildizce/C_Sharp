using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkDemo
{
    public class ProductDal
    {
        public List<Product> GetAll()
        {
            //  using görev bittikten sonra belleği temizler
            using (ETrade_CsharpContext context = new ETrade_CsharpContext())
            {
                return  context.Products.ToList();
            }

        }

        public void Add(Product product)
        {
            using (ETrade_CsharpContext context = new ETrade_CsharpContext())
            {
                context.Products.Add(product);
                context.SaveChanges();
            }
        }

        public void Update(Product product)
        {
            using (ETrade_CsharpContext context = new ETrade_CsharpContext())
            {
                var entity = context.Entry(product);
                entity.State = EntityState.Modified;
                context.SaveChanges();
            }
        }

        public void Delete(Product product)
        {
            using (ETrade_CsharpContext context = new ETrade_CsharpContext())
            {
                var entity = context.Entry(product);
                entity.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }
    }
}
