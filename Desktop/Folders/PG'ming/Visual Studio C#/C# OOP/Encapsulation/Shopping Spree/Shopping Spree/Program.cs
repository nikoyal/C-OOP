using System;
using System.Collections.Generic;

namespace ShoppingSpree
{
    class Program
    {
        static void Main(string[] args)
        {
            var Person = new Person();
            var Product = new Product();

            string[] Input = Console.ReadLine().Split(';','=');
            for (int i = 0; i < Input.Length; i+=2)
            {
                Person.Add(Input[i], decimal.Parse(Input[i + 1]));
            }

            string[] InputProducts = Console.ReadLine().Split(';', '=');
            for (int i = 0; i < InputProducts.Length - 1; i += 2)
            {
                Product.AddProduct(InputProducts[i], decimal.Parse(InputProducts[i + 1]));
            }
            var Boughts = new Dictionary<string, List<string>>();
            while (true)
            {
                string[] BuyStuff = Console.ReadLine().Split();
                if (BuyStuff[0] == "END")
                {
                    break;
                }
                decimal money = Person.GetMoney(BuyStuff[0]);
                decimal cost = Product.GetCost(BuyStuff[1]);
                if (money >= cost)
                {
                    Console.WriteLine(BuyStuff[0] + " bought " + BuyStuff[1]);
                    Person.SetMoney(BuyStuff[0], cost);
                    if (!Boughts.ContainsKey(BuyStuff[0]))
                    {
                        Boughts.Add(BuyStuff[0], new List<string>());
                    }
                    Boughts[BuyStuff[0]].Add(BuyStuff[1]);
                }
                else 
                {
                    if (!Boughts.ContainsKey(BuyStuff[0]))
                    {
                        Boughts.Add(BuyStuff[0], new List<string>());
                    }
                    Console.WriteLine(BuyStuff[0] + " can't afford " + BuyStuff[1]);
                }
            }
            foreach (var person in Boughts)
            {
                if (person.Value.Count < 1)
                {
                    Console.WriteLine(person.Key + " - Nothing bought");
                }
                else
                {
                    Console.WriteLine(person.Key + " - " + String.Join(", ", person.Value));
                }
            }
        }
    }
}
