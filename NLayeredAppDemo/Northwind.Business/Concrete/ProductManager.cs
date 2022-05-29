﻿
using Northwind.Business.Abstract;
using Northwind.DataAccess.Abstract;
using Northwind.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.Business.Concrete 
{
    public class ProductManager: IProductService
    {
       private IProductDal _productDal;

        public ProductManager(IProductDal productDal )
        {
            _productDal = productDal;
        }

        public List<Product> GetAll()
        {
            return _productDal.GetAll();
        }

        public List<Product> GetProductsByCategory(int categoryId)
        {
            return _productDal.GetAll(p => p.CategoryId == categoryId);
        }

        public List<Product> GetProductsByCategoryName(string categoryName)
        {
            return _productDal.GetAll(p => p.ProductName.ToLower().Contains(categoryName.ToLower()));
        }
    }
}
