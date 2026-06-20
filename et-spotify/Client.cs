using System;
using System.Collections.Generic;
using System.Text;
using static System.Net.WebRequestMethods;

namespace et_spotify
{
    internal class Client
    {
        List<playlist> playlists = new List<playlist>();

        public Client()
        {
            loadPlaylist();
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





        List<playlist> playlist = new List<playlist>();

        public void loadPlaylist()
        {
            playlist.Add(new playlist("rock"));
            playlist.Add(new playlist("pop"));

            Console.WriteLine("Beschikbare playlists:");
            for (int i = 0; i < playlist.Count; i++)
            {
                Console.WriteLine($"{i + 11}. {playlist[i].name}");
            }
            
        }

        public void Playplaylist(int keuze)
        {

          
            if (keuze > 0 && keuze <= playlist.Count)
            {
                Console.WriteLine($"Je speelt nu de playlist: {playlist[keuze - 1].name}");
            }
            else
            {
                Console.WriteLine("Ongeldige keuze.");
            }
        }
    }
}