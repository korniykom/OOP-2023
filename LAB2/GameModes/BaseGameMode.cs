using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyGame 
{
    public abstract class BaseGameMode
    {
        public abstract void PlayAnGame(GameAccount winner, GameAccount loser, int bet);
    }
}
