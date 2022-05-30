﻿using System;

namespace Builder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ProducDirector director = new ProducDirector();
            var builder = new NewCustomerProductBuilder();
            director.GenerateProduct(builder);
            //var model = builder.GetModel();
           // Console.WriteLine(model.DiscountedPrice);
        }
    }
    class ProductViewModel
    {

        public int Id { get; set; }
        public string CategoryName { get; set; }
        public string ProductName { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal DiscountedPrice { get; set; }
        public bool DiscountApplied { get; set; }

    }

    public abstract class ProductBuilder
    {
        public abstract void GetProductData();
        public abstract void ApplyDiscount();
      //  public abstract ProductViewModel GetModel();

    }

    public class NewCustomerProductBuilder : ProductBuilder
    {
        ProductViewModel model = new ProductViewModel();


        public override void ApplyDiscount()
        {
            model.DiscountedPrice = model.UnitPrice * (decimal)0.9;
            model.DiscountApplied = true;
        }

        //public override ProductViewModel GetModel()
        //{
        //    return model;
        //}

        public override void GetProductData()
        {
            model.Id = 1;
            model.CategoryName = "Beverages";
            model.ProductName = "Chai";
            model.UnitPrice = 82;
        }
    }
    public class OldCustomerProductBuilder : ProductBuilder
    {
        ProductViewModel model = new ProductViewModel();
        //public override ProductViewModel GetModel()
        //{
        //    return model;
        //}
        public override void ApplyDiscount()
        {
            model.DiscountedPrice = model.UnitPrice;
            model.DiscountApplied = false;
        }

        

        public override void GetProductData()
        {
            model.Id = 1;
            model.CategoryName = "Beverages";
            model.ProductName = "Chai";
            model.UnitPrice = 82;
        }
    }

     class ProducDirector
    {
        public void GenerateProduct(ProductBuilder productBuilder)
        {
            productBuilder.GetProductData();
            productBuilder.ApplyDiscount();
        }
    }
}
