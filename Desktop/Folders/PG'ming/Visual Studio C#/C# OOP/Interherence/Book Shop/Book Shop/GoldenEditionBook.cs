using System;
using System.Collections.Generic;
using System.Text;

namespace BookShop
{
    class GoldenEditionBook : Book
    {
        public GoldenEditionBook(string title,string author,double price) : base (title,author,price)
        {


        }
        
        public override double Price
        {
            get
            {
                return base.Price * 1.3;
            }
        }

    }
}
