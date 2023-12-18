using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyGame 
{
    public class RegularGameMode : GameMode
    {
        public RegularGameMode(GameAccount winner, GameAccount loser, int bet) : base(winner, loser, bet)
        {
            
        }
        public override GameMode PlayGame(GameAccount winner, GameAccount loser, int bet)
        {
            if(bet < 1)
            {
                throw new ArgumentOutOfRangeException(nameof(bet), "Rating connot be less than 1");
            }
            if(winner != loser)
            {
                return new RegularGameMode(winner, loser, bet);
            }
            else
            {
                throw new ArgumentException("Player should play agaisnt other player");
            }
        }

    }
}