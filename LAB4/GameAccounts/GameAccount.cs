using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyGame 
{
    public abstract class GameAccount
    {
        private List<GameLogs> allGames = new ();
        public string UserName {get; set;}
        public int id {get; set;}
        public int idSeed = 1;
        private int _currentRating;
        public int CurrentRating 
        {
            get { return _currentRating; }
            set
            {
                if ( value < 1) 
                {
                    _currentRating = 1;
                }
                else
                {
                    _currentRating = value;
                }
            }
        }
        public GameAccount(string name)
        {
            UserName = name;
            id = ++idSeed;
        }
        private int GamesCount 
        {
            get { return allGames.Count;}
        }
        public abstract int CalculatePoints(int bet, string outcome);
        public void WinGame(GameAccount opponent, int bet)
        {
            CurrentRating += bet;
            allGames.Add(new GameLogs(this, opponent, "Win", bet));
        }
        public void LoseGame(GameAccount opponent, int bet)
        {
            CurrentRating -= bet;
            allGames.Add(new GameLogs(this, opponent, "Lose", bet)); 
        }
        public string GetStats()
        {
            var report = new System.Text.StringBuilder();
            report.AppendLine("Stats of " + UserName + "\n|==================================================================|\n|UserName|UserRating|OpponentName|OpponentRating|Outcome|GameID|Bet|");
            foreach(var game in allGames)
            {
                report.AppendLine(String.Format("|{0,8}|{1,10}|{2,12}|{3,14}|{4,7}|{5,6}|{6,3}|", game.playerName, game.playerRating, game.opponentName,game.opponentRating, game.outcome, game.gameID, game.GameBet));
            }
            report.AppendLine("|==================================================================|");
            return report.ToString();
        }
    }
}