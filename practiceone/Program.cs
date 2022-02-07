using System;
class practiceone
{
    public interface IClub
    {
        string Badge();
        string Colors();
        string Players();
        string Location();
    }
    public class RealSaltLake : IClub
    {
        public string Badge()
        {
            return "sheild";
        }
        public string Colors()
        {
            return "Claret & Cobalt";
        }
        public string Players()
        {
            return "Player 1 -- Player 11";
        }
        public string Location()
        {
            return "Salt Lake City";
        }
    }
    public static void Main()
    {
        RealSaltLake rsl = new RealSaltLake();
        rsl.Badge();
        Console.WriteLine(rsl.Badge);
    }
}