using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System;


namespace MyGame {
    public class GameLogs { 
        public GameLogs( GameAccount player, GameAccount opponent, string outcome, int bet)
        {
            playerName = player.UserName;
            playerRating= player.CurrentRating;
            opponentName = opponent.UserName;
            opponentRating = opponent.CurrentRating;
            this.outcome = outcome;
            gameID = gameIDSeed;
            gameIDSeed++;
            GameBet = bet;
        }
        public uint gameID;
        public static uint gameIDSeed = 100;
        public string playerName;
        public int playerRating;
        public string opponentName;
        public int opponentRating;
        public string outcome;
        public int GameBet;
    }
}