using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace ShoppingSpree
{
    public class Person
    {
        private Dictionary<string, decimal> People = new Dictionary<string, decimal>();
        public void Add(string name, decimal money)
        {
            Match StringCheck = Regex.Match(name,@"[A-Za-z]");
            if (name == null ||!StringCheck.Success)
            {
                Console.WriteLine("Name cannot be empty");
                Environment.Exit(0);
            }
            else if (money < 0)
            {
                Console.WriteLine("Money cannot be negative");
                Environment.Exit(0);
            }
            this.People.Add(name, money);
        }
        public decimal GetMoney(string name)
        {
            return this.People[name];
        }
        public void SetMoney (string name,decimal cost)
        {
            this.People[name] -= cost;
        }
    }
}
