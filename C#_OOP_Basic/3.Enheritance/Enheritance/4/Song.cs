using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineRadio
{
    public class Song
    {
        private string artisName;
        private string songName;
        private int seconds;
        private int minutes;

        public Song(string artist,string songName,int minutes,int seconds )
        {
            this.ArtistName = artist;
            this.SongName = songName;
            this.Seconds = seconds;
            this.Minutes = minutes;
        }

        public string ArtistName
        {
            get { return this.artisName; }
            set
            {
                if (value.Length <3 || value.Length >20)
                {
                    throw new InvalidArtistNameException();
                }
                this.artisName = value;
            }
        }
        public string SongName
        {
            get
            {
                return this.songName;
            }
            set
            {
                if (value.Length <3 || value.Length >30)
                {
                    throw new InvalidSongNameException();
                }
                this.songName = value;
            }
        }

        public int Seconds
        {
            get
            {
                return this.seconds;
            }

            set
            {
                if (value < 0 || value > 59)
                {
                    throw new InvalidSongSecondsException();
                }
                this.seconds = value;
            }
        }

        public int Minutes
        {
            get
            {
                return this.minutes;
            }

            set
            {
                if (value < 0 || value > 14)
                {
                    throw new InvalidSongMinutesException();
                }
                this.minutes = value;
            }
        }

    }
}
