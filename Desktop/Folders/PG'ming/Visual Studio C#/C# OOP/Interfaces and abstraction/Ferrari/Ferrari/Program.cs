using System;

namespace Ferrari
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            string driver = Console.ReadLine();
            ICar ferrari = new Ferrari(driver);
            Console.WriteLine(ferrari.GetModel() + "/" + ferrari.Break() + "/" + ferrari.GasPedal() + "/" + driver);

        }
    }
}
