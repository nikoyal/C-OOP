namespace P02_BlackBoxInteger
{
    using System;
    using System.Reflection;

    public class BlackBoxIntegerTests
    {
        public static void Main()
        {
            while (true)
            {
                string[] input = Console.ReadLine().Split('_');
                if (input[0] == "END")
                {
                    break;
                }
                if (input[0] == "Add")
                {
                    var add = typeof(BlackBoxInteger).GetMethod("Add", BindingFlags.NonPublic | BindingFlags.Instance);
                    add.Invoke(add, new object[] { 3 });
                }
                Console.WriteLine(typeof(BlackBoxInteger).GetMethod("innerValue",BindingFlags.NonPublic | BindingFlags.Instance).Name);
            }
        }
    }
}
