using System;

namespace OnlineRadioDatabase
{
    class Program
    {
        static void Main(string[] args)
        {
            int MinutesLength = 0;
            int SecondsLength = 0;
            int songs = 0;

            int BookNumber = int.Parse(Console.ReadLine());
            for (int i = 0; i < BookNumber; i++)
            {
                string[] Input = Console.ReadLine().Split(';');
                int seconds = int.Parse(Input[3]);
                int minutes = int.Parse(Input[2]);
                if (Input[0].Length < 3 || Input[0].Length > 20)
                {
                    throw new InvalidArtistNameException();
                }
                if (Input[1].Length < 3 || Input[1].Length > 20)
                {
                    throw new InvalidSongNameException();
                }
                if (minutes > 14 && seconds > 59)
                {
                    throw new InvalidSongLengthException();
                }
                if (minutes > 14)
                {
                    Console.WriteLine(InvalidSongMinutesException);
                }
                if (seconds > 59)
                {
                    throw new InvalidSongSecondsException();
                }
            }
        }
    }
}
