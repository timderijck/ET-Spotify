using System;
using System.Collections.Generic;
using System.Text;
using static System.Net.WebRequestMethods;
namespace et_spotify
{
    internal class Client
    {

  

        public Client ()
        {
            LoadSongs();
        }


        public int pauze(int pauze)
        {


            Console.WriteLine("klik op 5 om het nummer te stoppen");
             pauze = Convert.ToInt32(Console.ReadLine());

            if (pauze == 5)
            {
                Console.WriteLine("het nummer is gestopt kies een nieuw nummer");
            }

            Console.WriteLine("klik op 6 om het nummer weer af te spelen");
            pauze = Convert.ToInt32(Console.ReadLine());
            if (pauze == 6)
            {
                Console.WriteLine("het nummer speelt weer af");
            }

            return pauze;
        }



        List<Song> songs = new List<Song>();

        public void LoadSongs()
        {
            songs.Add(new Song("appel", "peer"));
            songs.Add(new Song("qw", "er"));
            songs.Add(new Song("fbhe", "fsyuf"));

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
