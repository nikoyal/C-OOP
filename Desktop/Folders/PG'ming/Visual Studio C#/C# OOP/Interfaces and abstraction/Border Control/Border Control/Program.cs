using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace BorderControl
{
    class StartUp
    {
        static void Main(string[] args)
        {
            int fun = int.Parse(Console.ReadLine());
            Dictionary<string, int> peeps = new Dictionary<string, int>();
            Dictionary<string, int> rebs = new Dictionary<string, int>();
            for (int i = 0; i < fun; i++)
            {
                string[] names = Console.ReadLine().Split();
                if (names.Length == 4)
                {
                    peeps.Add(names[0], 0);
                }
                else
                {
                    rebs.Add(names[0], 0);
                }
            }
            int totalfood = 0;
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "End")
                {
                    break;
                }
                if (peeps.ContainsKey(input))
                {
                    totalfood += 10;
                }
                if (rebs.ContainsKey(input))
                {
                    totalfood += 5;
                }
            }
            Console.WriteLine(totalfood);
        }
    }
}
