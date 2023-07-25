using System.Security.Cryptography.X509Certificates;

namespace RPSLS
{
    public class Program
    {
        static void Main(string[] args)
        {
            Game game = new Game();
            game.RunGame();
            game.ChooseNumberOfHumanPlayers();
           
        }
    }
}