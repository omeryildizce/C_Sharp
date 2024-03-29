﻿using System;

namespace Strategy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager._creditCalculatorBase = new After2010CreditCalculator();
            customerManager.SaveCredit();
        }
    }
    abstract class CreditCalculatorBase
    {
        public abstract void Calculate();
    }

    class Before2010CreditCalculator : CreditCalculatorBase
    {
        public override void Calculate()
        {
            Console.WriteLine("Credit calculated using before 2010");
        }
    }
    class After2010CreditCalculator : CreditCalculatorBase
    {
        public override void Calculate()
        {
            Console.WriteLine("Credit calculated using after 2010");
        }
    }

    class CustomerManager
    {
        public CreditCalculatorBase _creditCalculatorBase { get; set; }
        public void SaveCredit()
        {
            Console.WriteLine("Customer manager business");
            _creditCalculatorBase.Calculate();
        }
    }
}

        