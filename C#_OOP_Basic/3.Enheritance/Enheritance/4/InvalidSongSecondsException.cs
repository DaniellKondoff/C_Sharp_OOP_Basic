using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineRadio
{
    public class InvalidSongSecondsException : InvalidSongLengthException
    {
        private const string Message = "Song seconds should be between 0 and 59.";

        public InvalidSongSecondsException()
            :base(Message)
        {

        }
        public InvalidSongSecondsException(string message)
            :base(message)
        {

        }
    }
}
