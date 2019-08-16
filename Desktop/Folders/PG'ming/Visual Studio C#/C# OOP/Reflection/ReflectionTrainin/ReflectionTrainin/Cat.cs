using System;
using System.Collections.Generic;
using System.Text;

namespace ReflectionTrainin
{
    class Cat : Animal,IAnimal
    {
        public Cat(string name) : base(name)
        {

        }
        private string name;
        public override string Name {
            get
            {
                return name;
            }
            set
            {
                if (value.Length < 3)
                {
                    throw new ArgumentException("Name lenght shoult be 3+");
                }
                name = value;
            }
        }
        public int Age { get; set; }
        public string SayHello()
        {
            return "Hello from cat named " + name;
        }
    }
}
