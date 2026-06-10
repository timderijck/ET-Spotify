using System;
using System.Collections.Generic;
using System.Text;

namespace et_spotify
{
    internal class playlist
    {

        public int playlist(int playlist)
        {
            Console.WriteLine("kies een playlist");
            int keuze = Convert.ToInt32(Console.ReadLine());


            if (keuze == 1)
            {
                Console.WriteLine("je hebt playlist 1 gekozen");
            }
            

            return playlist;
        }


    }
}
