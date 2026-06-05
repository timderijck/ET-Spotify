using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;

public class Song
{
    public string Title;
    public string Artist;
}
class Program
{
    static void Main()
    {


        static void Play()
        {
            Song s = new Song();

            s.Title = "incoming";
            s.Artist = "angerfist";

            Console.WriteLine(" 1 " + s.Title + " by " + s.Artist);


            Song s2 = new Song();
            s2.Title = "just like you";
            s2.Artist = "radical redemtion";

            Console.WriteLine(" 2 " + s2.Title + " by " + s2.Artist);

            Song s3 = new Song();
            s3.Title = "dream on";
            s3.Artist = "aerosmith";

            Console.WriteLine(" 3 " + s3.Title + " by " + s3.Artist);

            Console.WriteLine("kies een nummer en geef aan met een getal welke je wil");
            int keuze = Convert.ToInt32(Console.ReadLine());

            if (keuze == 1)
            {
                Console.WriteLine(s.Title + " by " + s.Artist + " nummer speelt af ");
            }
            else if (keuze == 2)
            {
                Console.WriteLine(s2.Title + " by " + s2.Artist + " nummer speelt af");
            }

            else if (keuze == 3)
            {
                Console.WriteLine(s3.Title + " by " + s3.Artist + " nummer speelt af ");
            }

            else
            {
                Console.WriteLine("geen nummer");
            }
        }
     



        static void Stop()
        {

            Console.WriteLine("klik op 5 om het nummer te stoppen");
            int stop = Convert.ToInt32(Console.ReadLine());

            if (stop == 5)
            {
                Console.WriteLine("het nummer is gestopt kies een nieuw nummer");
            }

        }



    }
}
