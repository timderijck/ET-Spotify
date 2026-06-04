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
            Console.WriteLine("Wat wilt u graag doen?");
            Console.WriteLine("Typ 1 t/m 3");
            Console.WriteLine("1. Home");
            Console.WriteLine("2. Hulp");
            Console.WriteLine("3. Instellingen");

            string keuze = Console.ReadLine();

            if (keuze == "1")
            {
                Console.WriteLine("Home");
            }
            else if (keuze == "2")
            {
                Contact.ContactText();
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
