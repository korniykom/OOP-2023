using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyGame 
{
    public class TrainingGameMode : BaseGameMode 
    {
        public override void PlayAnGame(GameAccount winner, GameAccount loser, int bet = 0)
        {
            winner.WinGame(loser, 0);
            loser.LoseGame(winner, 0);
        }
    }
}