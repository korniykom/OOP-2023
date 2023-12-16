using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyGame 
{
    public abstract class GameMode
    {
        public string modeType = "Base Mode";
        public abstract void PlayAnGame(GameAccount winner, GameAccount loser, int bet);
    }
}
