using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyGame {
    public class GameLogs { 
        //Constructor
        public GameLogs(string playerName, int playerRating, string opponentName, int opponentRating, string outcome, uint id, int bet) {
            this.playerName = playerName;
            this.playerRating = playerRating;
            this.opponentName = opponentName;
            this.opponentRating = opponentRating;
            this.outcome = outcome;
            gameID = id;
            this.GameBet = bet;
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