using System;
using System.Collections.Generic;
using System.Text;

namespace ReflectionTrainin
{
    class Dog : Animal, IAnimal
    {
        public Dog(string name) : base(name)
        {

        }
        private string name;
        public override string Name { get => name; set => name = value; }
        public string SayHello()
        {
            return "Bark";
        }
    }
}
