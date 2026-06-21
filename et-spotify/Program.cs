using et_spotify;

class Program
{
    static void Main()
    {
        Client client = new Client();
        DataBase dataBase = new DataBase();

        Console.WriteLine("kies een nummer en geef aan met een getal welke je wil");
        int keuze = Convert.ToInt32(Console.ReadLine());

        if (keuze <= 10)
        {
            dataBase.Play(keuze);
            client.pauze(0);
           
        }
        else if (keuze >= 11)
        {

        }

        client.stop(0);
    }
}