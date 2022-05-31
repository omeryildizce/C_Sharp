using System;
using System.Collections.Generic;

namespace Command
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StockManager stockManager = new StockManager();
            BuyStock buyStock = new BuyStock(stockManager);
            SellStock sellStock = new SellStock(stockManager);

            StockCotroller stockCotroller = new StockCotroller();
            stockCotroller.TakeOrder(buyStock);
            stockCotroller.TakeOrder(sellStock);
            stockCotroller.TakeOrder(buyStock);

            stockCotroller.PlaceOrders();   
        }
    }

    class StockManager
    {
        private string _name = "Laptop";
        private int _quantity = 10;

        public void Buy()
        {
            Console.WriteLine("Stock : {0}, {1} bought!", _name, _quantity);
        }
        public void Sell()
        {
            Console.WriteLine("Stock : {0}, {1} sold!", _name, _quantity);
        }
    }
    interface IOrder
    {
        void Execute();
    }
    class BuyStock : IOrder
    {
        private StockManager _stockManager;
        public BuyStock(StockManager stockManager)
        {
            _stockManager = stockManager;  
        }
        public void Execute()
        {
            _stockManager.Buy();
        }
    }
    class SellStock : IOrder
    {
        private StockManager _stockManager;
        public SellStock(StockManager stockManager)
        {
            _stockManager = stockManager;
        }
        public void Execute()
        {
            _stockManager.Sell  ();
        }
    }
    class StockCotroller
    {
        List<IOrder> _orders = new List<IOrder>();
        public void TakeOrder(IOrder order)
        {
            _orders.Add(order);
        }
        public void PlaceOrders()
        {
            foreach (IOrder order in _orders)
            {
                order.Execute();
            }
            _orders.Clear();
        }

    }
}
