using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineRadioDatabase
{
    public class InvalidArtistNameException : Exception
    {
        public InvalidArtistNameException()
            :base(String.Format("Artist name should be between 3 and 20 symbols."))
        {

        }
    }
    public class InvalidSongNameException : Exception
    {
        public InvalidSongNameException()
            :base(String.Format("Song name should be between 3 and 30 symbols."))
        {

        }
    }
    public class InvalidSongLengthException : Exception
    {
        public InvalidSongLengthException()
            :base(String.Format("Invalid song length."))
        {

        }
    }
    public class InvalidSongMinutesException : Exception
    {
        public InvalidSongMinutesException()
            :base(String.Format("Song minutes should be between 0 and 14."))
        {

        }
    }
    public class InvalidSongSecondsException : Exception
    {
        public InvalidSongSecondsException()
            :base(String.Format("Song seconds should be between 0 and 59."))            
        {

        }
    }
}
