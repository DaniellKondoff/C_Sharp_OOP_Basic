﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.OnlineRadioDatabase
{
    class InvalidArtistNameException : InvalidSongException
    {
        private const string Message = "Artist name should be between 3 and 20 symbols.";

        public InvalidArtistNameException()
            :base(Message)
        {
           
        }
        public InvalidArtistNameException(string message)
            :base(message)
        {

        }
    }
}
