using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
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
            Console.WriteLine("klik op 5 om het nummer te pauzeren");
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


        public int stop(int Stop)
        {
            Console.WriteLine("klik op 7 om het nummer te stoppen");
            Stop = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("het nummer is gestopt");
            return Stop;
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


        List<Song> songs = new List<Song>();
        public void Playplaylist(int keuze)
        {


            if (keuze > 0 && keuze <= playlist.Count)
            {
             
                    Console.WriteLine($"je hebt playlist: {playlist[keuze - 1].name} gekozen");
                    songs.Add(new Song("Counting Stars", "OneRepublic"));
                    songs.Add(new Song("Happy", "Pharrell Williams"));
                    songs.Add(new Song("Believer", "Imagine Dragons"));
               
            }
            else
            {
                Console.WriteLine("Ongeldige keuze.");
            }
        }

     




    }

     
    }
