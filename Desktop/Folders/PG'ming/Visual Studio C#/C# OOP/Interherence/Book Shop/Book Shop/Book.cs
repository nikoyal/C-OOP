using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Text.RegularExpressions;

namespace BookShop
{
    class Book
    {
        public Book(string author,string title,double price)
        {
            Title = title;
            Author = author;
            Price = price;
        }
        private string title;
        private string author;
        public double price;
        public string Title {
            get
            {
                return title;
            }
            set
            {

                if (value.Length < 3)
                {
                    throw new ArgumentException("Title not valid!");
                }
                title = value;
            }

        }
        public string Author
        {
            get
            {
                return author;
            }
            set
            {
                string[] split = value.Split();
                string startingchar = split[1].Substring(0, 1);
                Match check = Regex.Match(startingchar, @"[0-9]");
                if (check.Success)
                {
                    throw new ArgumentException("Author not valid!");
                }
                author = value;
            }
        }
        public virtual double Price
        {
            get
            {
                return price;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Price not valid!");
                }
                price = value;
            }
        }

        public override string ToString()
        {
            var resultBuilder = new StringBuilder();
            resultBuilder.AppendLine($"Type: {this.GetType().Name}")
                .AppendLine($"Title: {this.Title}")
                .AppendLine($"Author: {this.Author}")
                .AppendLine($"Price: {this.Price:f2}");

            string result = resultBuilder.ToString().TrimEnd();
            return result;
        }


    }
}
