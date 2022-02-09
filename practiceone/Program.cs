using System;
class practiceone
{
    public interface IClub
    {
        string name();
        string badgeShape();
        string colors();
        string players();
        string location();
        string league();
    }
    public class UtahClub : IClub
    {
        public UtahClub()
        {
        }
        public string name()
        {
            return "Real Salt Lake";
        }
        public string badgeShape()
        {
            return "Shield";
        }
        public string colors()
        {
            return "Claret & Cobalt";
        }
        public string players()
        {
            return "Player 1 -- Player 11";
        }
        public string location()
        {
            return "Salt Lake City";
        }
        public string league()
        {
            return "Major League Soccer";
        }
    }
    public class WomensUtahClub : UtahClub
    {
        public new string name()
        {
            return "Utah Royals FC";
        }
        public new string league()
        {
            return "National Women's Soccer League";
        }
    }
    public static void Main()
    {
        UtahClub mensTeam = new UtahClub();
        WomensUtahClub womensTeam = new WomensUtahClub();
        Console.WriteLine($" \nUtah's only professional soccer team is {mensTeam.name()}");
        Console.WriteLine($"Utah also formally had a women's soccer team owned by {mensTeam.name()} and called {womensTeam.name()}");
        Console.WriteLine($"{mensTeam.name()}'s colors are {mensTeam.colors()} and {womensTeam.name()}'s colors are fittingly {womensTeam.colors()} aswell");
    }
}