using System;
using System.Text.RegularExpressions;

namespace Pizza
{
    class Program
    {
        static void Main(string[] args)
        {
            int topingcount = 0;
            double totalcal = 0;
            Toppings topping = new Toppings();
            Doughts dought = new Doughts();
            string pizzatype = Console.ReadLine();
            string pizzaname = pizzatype.Substring(6).Trim();
            if (String.IsNullOrEmpty(pizzaname))
            {
                Console.WriteLine("Pizza name should be between 1 and 15 symbols.");
                Environment.Exit(0);
            }
            if (pizzaname.Length > 15 || pizzaname.Length < 1)
            {
                Console.WriteLine("Pizza name should be between 1 and 15 symbols.");
                Environment.Exit(0);
            }
            while (true)
            {
               string[] Input = Console.ReadLine().Split();
                if (Input[0].ToLower() == "end")
                {
                    break;
                }
                if (Input[0].ToLower() == "dough")
                {
                    dought.Flour = Input[1].ToLower();
                    dought.Baking = Input[2].ToLower();
                    dought.Grams = double.Parse(Input[3]);
                    totalcal += dought.Calories();
                }
                else if (Input[0].ToLower() == "topping")
                {
                    topping.Toping = Input[1].ToLower();
                    topping.Grams = double.Parse(Input[2]);
                    totalcal += topping.PutTopings();
                    topingcount++;
                    if (topingcount > 10)
                    {
                        Console.WriteLine("Number of toppings should be in range [0..10].");
                        Environment.Exit(0);
                    }
                }
                
            }
            Console.WriteLine(pizzaname + " - {0:f2} Calories.",totalcal);
        }
    }
}
