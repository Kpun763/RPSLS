using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    internal class HumanPlayer : Player
    {
        public HumanPlayer(string name) : base(name) { }
        

        public override void ChooseGesture()
        {
            Console.WriteLine("Possible gestures: Rock, Paper, Scissors, Lizard, Spock");
            Console.WriteLine("Please make your selection: ");
            chosenGesture = Console.ReadLine();
        }

    }

}
