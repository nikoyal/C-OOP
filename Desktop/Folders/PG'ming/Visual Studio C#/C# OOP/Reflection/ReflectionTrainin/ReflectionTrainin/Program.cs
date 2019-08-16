using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace ReflectionTrainin
{
    class Program
    {
        static void Main(string[] args)
        {
            string animaltype = Console.ReadLine();
            var instanceAnimal = Type.GetType($"ReflectionTrainin.{animaltype}");
            var animalconstructor = instanceAnimal.GetConstructors().First();
            var parameters = animalconstructor.GetParameters();
            var parametersvalue = new List<object>();
            foreach (var parameter in parameters)
            {
                Console.Write($"input {parameter.Name}: ");
                parametersvalue.Add(Console.ReadLine());
            }
            var AnimalInstance = (Animal)Activator.CreateInstance(instanceAnimal, parametersvalue.ToArray());
            Console.WriteLine(AnimalInstance.Name);
        }
    }
}
