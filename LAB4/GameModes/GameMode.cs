using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyGame 
{
    public abstract class GameMode
    {
        public abstract GameMode PlayGame(GameAccount winner, GameAccount loser, int bet);
        public uint gameID;
        public static uint gameIDSeed = 0;
        public GameAccount winner;
        public GameAccount loser;
        public int GameBet;
        public GameMode(GameAccount winner, GameAccount loser, int bet)
        {
            this.winner = winner;
            this.loser = loser;
            GameBet = bet;
            gameID = ++gameIDSeed;

        }
    }
}
