using System;
using System.Collections.Generic;
using System.Text;

namespace Reflection_Training_2
{ 
    [AttributeUsage(AttributeTargets.Property)]
    class CustomAttribute : Attribute
    {
        public CustomAttribute(string name)
        {
            Name = name;
        }
        public string Name { get; set; }
        public int Year { get; set; }
    }
}
