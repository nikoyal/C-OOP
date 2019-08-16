using System;
using System.Collections.Generic;
using System.Text;

namespace Ferrari
{
    public class Ferrari : ICar
    {
        public Ferrari(string name)
        {
            this.Name = name;
        }
        public string Name { get; set; }

        public string GetModel()
        {
            return "488-Spider";
        }

        public string Break()
        {
            return "Brakes!";
        }

        public string GasPedal()
        {
            return "Gas!";
        }
    }
}
