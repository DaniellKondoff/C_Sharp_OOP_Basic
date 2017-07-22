using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.OnlineRadioDatabase
{
    class Radio
    {
        static void Main()
        {
            int numberOfEntires = int.Parse(Console.ReadLine());
            List<Song> playlist = new List<Song>();
            for (int i = 0; i < numberOfEntires; i++)
            {
                string[] data = Console.ReadLine().Split(';');
                string artistName = data[0];
                string songName =data[1];

                try
                {
                    int[] songLenght = data[2].Split(':').Select(int.Parse).ToArray();
                    Song song = new Song(artistName, songName, songLenght[0], songLenght[1]);
                    playlist.Add(song);
                    Console.WriteLine("Song added.");
                }
                catch (InvalidSongException ise)
                {
                    Console.WriteLine(ise.Message);
                }
                catch (Exception)
                {
                    Console.WriteLine("Invalid song length.");
                }
            }

            Console.WriteLine($"Songs added: {playlist.Count}");
            int totalMinutes = playlist.Sum(s => s.Minutes);
            int totalSeconds = playlist.Sum(s => s.Seconds);

            totalSeconds += totalMinutes * 60;

            int finalMinutes = totalSeconds / 60;
            int finalSeconds = totalSeconds % 60;
            int finalHours = finalMinutes / 60;
            finalMinutes %= 60;
            Console.WriteLine($"Playlist length: {finalHours}h {finalMinutes}m {finalSeconds}s");
        }
    }
}
