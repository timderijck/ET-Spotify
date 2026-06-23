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



        public void Besturing()
        {
            int keuze = 0;

            while (keuze != 7)
            {
                Console.WriteLine("5 pauze en daarna op 6 om het weer verder te spelen, 7 stop");
                keuze = Convert.ToInt32(Console.ReadLine());

                if (keuze == 5)
                {
                    Console.WriteLine("Nummer gepauzeerd");
                }

                if (keuze == 6)
                {
                    Console.WriteLine("Nummer speelt weer af");
                }

                if (keuze == 7)
                {
                    Console.WriteLine("Nummer gestopt");
                }
            }
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
