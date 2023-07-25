using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    internal class Game 
    {
        //Member Variabes (HAS A)
        public Player playerOne;
        public Player playerTwo;

        //Constructor
        public Game()
        {

        }

        //Member Methods (CAN DO)
        public void WelcomeMessage()
        {
            Console.WriteLine("Welcome to RPSLS! Here are the rules:\n");
            Console.WriteLine("Here are the rules:");
            Console.WriteLine("Rock beats Scissors and Lizard");
            Console.WriteLine("Paper beats Rock and Spock");
            Console.WriteLine("Scissors beats Paper and Lizard");
            Console.WriteLine("Lizard beats Paper and Spock");
            Console.WriteLine("Spock beats Scissors and Rock \n");
            Console.WriteLine("The game will be a first to 4, meaning the first player to win 4 rounds will win the game.");
        }

        public int ChooseNumberOfHumanPlayers()
        {
            int numberOfPlayers;
            
            do
            {
             
             Console.WriteLine("How many players are playing? (Enter 1 or 2):");
            } while (!int.TryParse(Console.ReadLine(), out numberOfPlayers) || (numberOfPlayers != 1 && numberOfPlayers != 2));


            return 2;
        }

        public void CreatePlayerObjects(int numberOfHumanPlayers)
        {

        }

        public void CompareGestures()
        {

        }

        public void DisplayGameWinner()
        {

        }

        public void RunGame()
        {
            WelcomeMessage();
        }
    }
}
