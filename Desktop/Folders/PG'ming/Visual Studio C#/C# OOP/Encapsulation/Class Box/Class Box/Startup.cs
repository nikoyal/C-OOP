using System;

namespace ClassBox
{
    class StartUp
    {
        static void Main(string[] args)
        {
            Box box = new Box(double.Parse(Console.ReadLine()), double.Parse(Console.ReadLine()), double.Parse(Console.ReadLine()));
            Console.WriteLine("Surface Area - {0:f2}\nLateral Surface Area - {1:f2}\nVolume - {2:f2}", box.SArea(), box.LSArea(), box.Volume());
        }
    }
}
