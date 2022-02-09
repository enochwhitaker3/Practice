using System;
class Program
{
    public interface IClub
    {
        string teamName();
        string teamColors();
        string teamCountry();
        string teamCity();
        string teamLeague();
    }
    public class UtahClub : IClub
    {
        public string teamName()
        {
            return "Real Salt Lake";
        }
        public string teamColors()
        {
            return"Claret & Cobalt";
        }
        public string teamCountry()
        {
            return"USA";
        }
        public string teamCity()
        {
            return"Salt Lake City";
        }
        public string teamLeague()
        {
            return"Major League Soccer";
        }
    }
    public class WomensUtahClub : UtahClub
    {
        public new string teamName()
        {
            return"Utah Royals FC";
        }
        public new string teamLeague()
        {
            return"National Women's Soccer League";
        }
    }
    public class userClub : IClub
    {
        private string name;
        private string colors;
        private string country;
        private string city;
        private string league;
        public string Name
        {
            get
            {
                return name;
            }
        }
        public string Colors
        {
            get
            {
                return colors;
            }
        }
        public string Country
        {
            get
            {
                return country;
            }
        }
        public string City
        {
            get
            {
                return city;
            }
        }
        public string League
        {
            get
            {
                return league;
            }
        }

        public userClub(string userTeamName, string userColors, string userCountry, string userCity, string userLeague)
        {
            name = userTeamName;
            colors = userColors;
            country = userCountry;
            city = userCity;
            league = userLeague;

        }
        public string teamName()
        {
            return name;
        }
        public string teamCountry()
        {
            return country;
        }
        public string teamColors()
        {
            return colors;
        }
        public string teamCity()
        {
            return city;
        }
        public string teamLeague()
        {
            return league;
        }
    }
    public static void Main()
    {
        UtahClub mensTeam = new UtahClub();
        WomensUtahClub womensTeam = new WomensUtahClub();
        Console.WriteLine($" \nUtah's only professional soccer team is {mensTeam.teamName()}");
        Console.WriteLine($"Utah also formally had a women's soccer team owned by {mensTeam.teamName()} and called {womensTeam.teamName()}");
        Console.WriteLine($"{mensTeam.teamName()}'s colors are {mensTeam.teamColors()} and {womensTeam.teamName()}'s colors were fittingly {womensTeam.teamColors()} aswell");

        Console.WriteLine("Would you like to create your own club? Y or N?");
        string userInput = Console.ReadLine();
        if (userInput == "Y" )
        {
            Console.WriteLine("\nWhat would you like to name your club?");
            string userTeamName = Console.ReadLine();
            Console.WriteLine("\nWhat would you like the team's colors to be?");
            string userColors = Console.ReadLine();
            Console.WriteLine("\nWhat country is your team based in?");
            string userCountry = Console.ReadLine();
            Console.WriteLine("\nWhat city is your team located in?");
            string userCity = Console.ReadLine();
            Console.WriteLine("\nLastly, what league does your team compete in?");
            string userLeague = Console.ReadLine();
            userClub userclub1 = new userClub(userTeamName, userColors, userCountry, userCity, userLeague);
            Console.WriteLine($"\nYour team is located in {userclub1.teamCity()}, {userclub1.teamCountry()} and is known by the monocer {userclub1.teamName()}.");
            Console.WriteLine($"{userclub1.teamName()} competes in {userclub1.teamLeague()}, the top teir league in {userclub1.teamCountry()} ");
            Console.WriteLine($"{userclub1.teamName()} is well known throughout {userclub1.teamCountry()} for their {userclub1.teamColors()} colored kits");
        }
        else
        {
            Console.WriteLine("Thanks for visting my program :)");
        }
    }
    
}