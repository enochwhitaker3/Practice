using System;
namespace practicetwo;
class Program
{
    enum soccerPlayer
    {
        academyPlayer,
        unSigned,
        underContract,
        freeAgent, 
        retired
    }
    
    public static void Main(string[] args)
    {
        soccerPlayer iniesta;
        iniesta = soccerPlayer.retired;
        Console.WriteLine(iniesta);
    }
}
