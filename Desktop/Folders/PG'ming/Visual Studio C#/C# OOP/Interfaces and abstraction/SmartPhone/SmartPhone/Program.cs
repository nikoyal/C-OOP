using System;

namespace SmartPhone
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            SmartPhone phone = new Model();
            string[] inputNumbers = Console.ReadLine().Split();
            string[] inputURLS = Console.ReadLine().Split();
            for (int i = 0; i < inputNumbers.Length; i++)
            {
                Console.WriteLine(phone.Call(inputNumbers[i]));
            }
            for (int i = 0; i < inputURLS.Length; i++)
            {
                Console.WriteLine(phone.Browse(inputURLS[i]));
            }
        }
    }
}
