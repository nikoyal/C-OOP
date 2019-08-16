using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace ShoppingSpree
{
    public class Product
    {
        private Dictionary<string, decimal> Products = new Dictionary<string, decimal>();
        public void AddProduct(string name, decimal cost)
        {
            Match StringCheck = Regex.Match(name, @"[A-Za-z]");
            if (name == null || !StringCheck.Success)
            {
                Console.WriteLine("Name cannot be empty");
                Environment.Exit(0);
            }
            if (cost < 0)
            {
                Console.WriteLine("Money cannot be negative");
                Environment.Exit(0);
            }
            this.Products.Add(name, cost);
        }
        public decimal GetCost(string name)
        {
            return this.Products[name];
        }
    }
}
