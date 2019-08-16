using System;
using System.Collections.Generic;
using System.Text;

namespace Pizza
{
    public class Doughts
    {
        private string flour;
        private string baking;
        private double grams;
        public string Flour {
            get
            {
                return flour;
            }
            set
            {
                if (value != "white" && value != "wholegrain")
                {
                    
                    Console.WriteLine("Invalid type of dough.");
                    Environment.Exit(0);
                }
                else
                {
                    flour = value;
                }
            }
        }
        public string Baking {
            get
            {
                return baking;
            }
            set
            {
                if (value != "crispy" && value != "chewy" && value != "homemade")
                {
                    Console.WriteLine("Invalid type of dough.");
                    Environment.Exit(0);
                }
                else
                {
                    baking = value;
                }
            }
        }
        public double Grams {
            get
            {
                return grams;
            }
            set
            {
                if (value < 1 || value > 200)
                {
                    Console.WriteLine("Dough weight should be in the range [1..200].");
                    Environment.Exit(0);
                }
                grams = value;
            }
        }
        public double Calories()
        {
            double flourmodifier = 0;
            double bakingmodifier = 0;
            if (this.Flour == "white")
            {
                flourmodifier = 1.5;
            }
            else if (this.Flour == "wholegrain")
            {
                flourmodifier = 1.0;
            }
            if (this.Baking == "crispy")
            {
                bakingmodifier = 0.9;
            }
            else if (this.Baking == "chewy")
            {
                bakingmodifier = 1.1;
            }
            else if (this.Baking == "homemade")
            {
                bakingmodifier = 1.0;
            }

            return (2 * Grams) * flourmodifier * bakingmodifier;
        }
    }
}   
