using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Pizza
{
    public class Toppings
    {
        private string toping;
        private double grams;
        public string Toping {
            get
            {
                return toping;
            }
            set
            {
                if (value != "meat" && value != "veggies" && value != "cheese" && value != "sauce")
                {
                    Console.WriteLine("Cannot place {0}{1} on top of your pizza.",value.First().ToString().ToUpper(),value.Substring(1));
                    Environment.Exit(0);
                }
                toping = value;
            }
        }
        public double Grams
        {
            get
            {
                return grams;
            }
            set
            {
                if (value < 1 || value > 50)
                {
                    Console.WriteLine("{0}{1} weight should be in the range [1..50].", toping.First().ToString().ToUpper(), toping.Substring(1));
                    Environment.Exit(0);
                }
                grams = value;
            }
        }
        public double PutTopings()
        {
            double topingmodifier = 0;
            if (this.Toping == "meat")
            {
                topingmodifier = 1.2;
            }
            else if (this.Toping == "veggies")
            {
                topingmodifier = 0.8;
            }
            else if (this.Toping == "cheese")
            {
                topingmodifier = 1.1;
            }
            else if (this.Toping == "sauce")
            {
                topingmodifier = 0.9;
            }
            return (2 * this.Grams) * topingmodifier;
        }
    }
}
