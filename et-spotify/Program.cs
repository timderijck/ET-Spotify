using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;
using et_spotify;

class Program
{
    static void Main()
    {

        Client client = new Client();
        playlist play = new playlist();











        Console.WriteLine("kies een nummer en geef aan met een getal welke je wil");
        int keuze = Convert.ToInt32(Console.ReadLine());


        play.playlist(keuze);
        client.Play(keuze);
        client.pauze(keuze);




    }
}


