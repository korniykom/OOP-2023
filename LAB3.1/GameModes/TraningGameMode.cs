using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyGame 
{
    public class TrainingGameMode : GameMode 
    {
        public TrainingGameMode(GameAccount winner, GameAccount loser, int bet) : base(winner, loser, bet)
        {
            
        }
        public override GameMode PlayGame(GameAccount winner, GameAccount loser, int bet = 0)
        {
           return new TrainingGameMode(winner, loser, bet); 
        }
    }
}