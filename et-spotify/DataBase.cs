using System;
using System.Collections.Generic;
using System.Text;

namespace et_spotify
{
    internal class DataBase
    {
        public DataBase()
        {
            LoadSongs();
        }

        List<Song> songs = new List<Song>();

        public void LoadSongs()
        {
            songs.Add(new Song("Shape of You", "Ed Sheeran"));
            songs.Add(new Song("Blinding Lights", "The Weeknd"));
            songs.Add(new Song("Someone Like You", "Adele"));
            songs.Add(new Song("Uptown Funk", "Mark Ronson"));
            songs.Add(new Song("Rolling in the Deep", "Adele"));
            songs.Add(new Song("Bad Guy", "Billie Eilish"));
            songs.Add(new Song("Viva La Vida", "Coldplay"));
            songs.Add(new Song("Counting Stars", "OneRepublic"));
            songs.Add(new Song("Happy", "Pharrell Williams"));
            songs.Add(new Song("Believer", "Imagine Dragons"));

            Console.WriteLine("aanbevolen nummers");
            for (int i = 0; i < songs.Count; i++)
            {
                Console.WriteLine($"{i + 1} {songs[i].Title} by {songs[i].Artist}");
            }

           
        }

        public void Play(int keuze)
        {
            if (keuze > 0 && keuze <= songs.Count)
            {
                Console.WriteLine(songs[keuze - 1].Title + " by " +
                                  songs[keuze - 1].Artist +
                                  " nummer speelt af");
            }
            else
            {
                Console.WriteLine("geen nummer");
            }
        }
    }
}