using System;
using System.Collections.Generic;
using System.Text;

namespace Spotify
{
    internal class Mainpagina
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" ===  Hoofdpagina  === ");
            Console.WriteLine(" ===  Wat wilt u graag doen?  === ");

            string keuze = Console.ReadLine();

            if (keuze == "1")
            {
                Contact.ContactText();
            }
            else if (keuze == "2")
            {
                Console.WriteLine("Contact");
            }
            else if (keuze == "3")
            {
                Console.WriteLine("Instellingen");
            }
            else
            {
                Console.WriteLine("Ongeldige keuze");
            }
        }
    }
}
