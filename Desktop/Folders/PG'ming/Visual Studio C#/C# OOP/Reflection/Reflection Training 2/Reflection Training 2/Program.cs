using System;
using System.Reflection;

namespace Reflection_Training_2
{
    class Program
    {
        static void Main(string[] args)
        {
            var info = typeof(Program).GetMethod("Print");
            Print("hello");

            var types = Assembly.GetExecutingAssembly().GetTypes();
            
            foreach (var type in types)
            {
                type.GetCustomAttribute<CustomAttribute>();
            }

        }
        [Obsolete("ne polzvai tozi method ostarqva",true)]
        public static void Print(string info)
        {
            Console.WriteLine(info);
        }
    }
}
