using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyGame {
    public class GameAccount {
        private List<GameLogs> allGames = new List<GameLogs>();
        //constructor
        public GameAccount(string name) {
            this.UserName = name;
            CurrentRating = 1;
        }
        private string UserName;
        private int _currentRating;
        public int CurrentRating {
            get {return _currentRating;}
            set {
                if(value < 1) {
                    _currentRating = 1;
                } else {
                    _currentRating = value;
                }
            }
        }
        private int GamesCount { get { return allGames.Count;} }
        public void GameResult(GameAccount opponent, int rating, string outcome) {
            if(rating < 1) {
                throw new ArgumentOutOfRangeException(nameof(rating), "Rating cannot be less than 1");
            }
            if(opponent != this) {
                if(outcome == "Win") {
                    this.WinGame(opponent, rating);
                    opponent.LoseGame(this, rating);
                    // GameLogs.gameIDSeed++;
                } else if(outcome == "Lose") {
                    this.LoseGame(opponent, rating);
                    opponent.WinGame(this, rating);
                    // GameLogs.gameIDSeed++;
                } else {
                    throw new ArgumentException("You should pass correct outcome");
                }
            } else {
                throw new ArgumentException("Player should play against other player");
            }
        }
        private void WinGame(GameAccount opponent, int rating) {
            CurrentRating += rating;

           // var gameLog = ;
            allGames.Add(new GameLogs(UserName, CurrentRating, opponent.UserName, opponent.CurrentRating, "Win", GameLogs.gameIDSeed, rating));
        }
        private void LoseGame(GameAccount opponent, int rating) {
            CurrentRating -= rating;
            
            //var gameLog = ;
            allGames.Add(new GameLogs(UserName, CurrentRating, opponent.UserName, opponent.CurrentRating, "Lose", GameLogs.gameIDSeed, rating));
        }
        public string GetStats() {
            System.Console.WriteLine("Stats of " + UserName);
            var report = new System.Text.StringBuilder();

            report.AppendLine("|--------|----------|------------|--------------|-------|------|---|");
            report.AppendLine("|UserName|UserRating|OpponentName|OpponentRating|Outcome|GameID|Bet|");
            report.AppendLine("|--------|----------|------------|--------------|-------|------|---|");
            
            foreach(var item in allGames) {
                report.AppendLine(String.Format("|{0,8}|{1,10}|{2,12}|{3,14}|{4,7}|{5,6}|{6,3}|", item.playerName, item.playerRating, item.opponentName,item.opponentRating, item.outcome, item.gameID, item.GameBet));
                report.AppendLine("|--------|----------|------------|--------------|-------|------|---|");
            }
            return report.ToString();
        }
    }
}
