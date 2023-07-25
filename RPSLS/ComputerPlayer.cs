using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    internal class ComputerPlayer : Player
    {
        private Random random;
        
        public ComputerPlayer(string name) : base(name) 
        {
            random = new Random();
        }

        public override void ChooseGesture()
        {
            int randomIndex = random.Next(gestures.Count);
            chosenGesture = gestures[randomIndex];
        }
    }
}
