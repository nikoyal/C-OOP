using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Reflection_Training_2
{
    public class Cat
    {
        [Custom("Nikoyalcho", Year = 1)]
        public string Name { get; set; }
        [Custom]
        private string cat = "cat";
    }
}
