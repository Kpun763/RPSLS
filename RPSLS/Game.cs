using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
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


            return 1;
        }

        public void CreatePlayerObjects(int numberOfHumanPlayers)
        {
            if (numberOfHumanPlayers == 1) 
            {
                Console.WriteLine("Enter name for Player One: ");
                string playerOneName = Console.ReadLine();
                playerOne = new HumanPlayer(playerOneName);

                playerTwo = new ComputerPlayer("Computer");

            }
            else if (numberOfHumanPlayers == 2)
            {
                Console.WriteLine("Enter name for Player One: ");
                string playerOneNAme = Console.ReadLine();
                playerOne = new HumanPlayer(playerOneNAme);

                Console.WriteLine("Enter name for Player Two: ");
                string playerTwoName = Console.ReadLine();
                playerTwo = new HumanPlayer(playerTwoName);
            }
            else 
            { Console.WriteLine("Player number is invalid. Please choose either 1 or 2 players only."); }
        }

        public void CompareGestures()
        {
            Console.WriteLine($"Player One ({playerOne.name}) chose {playerOne.chosenGesture}");
            Console.WriteLine($"Player Two ({playerTwo.name}) chose {playerTwo.chosenGesture}");

            int result = playerOne.chosenGesture.CompareTo( playerTwo.chosenGesture );

            if (result == 0)
            {
                Console.WriteLine("It's a Draw");
            }
            else if (result == -1 || result == 4) 
            {
                playerTwo.score++;
                Console.WriteLine($"Player Two ({playerTwo.name}) wins the round");
            }
            else
            {
                playerOne.score++;
                Console.WriteLine($"Player One ({playerOne.name}) wins the round");
            }
        }

        public void DisplayGameWinner()
        {
            Console.WriteLine($"Player One ({playerOne.name}) score: {playerOne.score}");
            Console.WriteLine($"Player Two ({playerTwo.name}) score: {playerTwo.score}");

            if (playerOne.score >= 4)
            {
                Console.WriteLine($"Player One ({playerOne.name}) has won the game!");
            }
            else if (playerTwo.score >= 4)
            {
                Console.WriteLine($"Player two ({playerTwo.name}) has won the game!");
            }
            else 
            {
                Console.WriteLine("No winner yet. Keep on playing!");
            }
        }

        public void RunGame()
        {

            WelcomeMessage();
            int numberOfHumanPlayers = ChooseNumberOfHumanPlayers();
            CreatePlayerObjects(numberOfHumanPlayers);


            while (true)
            {
                Console.WriteLine("\n... Round start!");

                playerOne.ChooseGesture();
                playerTwo.ChooseGesture();

                CompareGestures();

                DisplayGameWinner();

                if (playerOne.score >= 4 || playerTwo.score >= 4)
                {
                    Console.WriteLine("\n... Game Completed!");
                    DisplayGameWinner();
                    break;
                }
            }
        }
    }
}
