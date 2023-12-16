using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyGame 
{
    public class RegularGameMode : GameMode
    {
        public override void PlayAnGame(GameAccount winner, GameAccount loser, int bet)
        {
            if(bet < 1)
            {
                throw new ArgumentOutOfRangeException(nameof(bet), "Rating connot be less than 1");
            }
            if(winner != loser)
            {
                winner.WinGame(loser, winner.CalculatePoints(bet, "Win"));
                loser.LoseGame(winner, loser.CalculatePoints(bet, "Lose"));
            }
            else
            {
                throw new ArgumentException("Player should play agaisnt other player");
            }
        }

    }
}