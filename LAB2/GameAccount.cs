using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyGame {

    public abstract class BaseClass {
        protected List<GameLogs> allGames;
        protected string UserName;
        protected int _currentRating;
        protected int CurrentRating {
            get {return _currentRating;}
            set {
                if(value < 1) {
                    _currentRating = 1;
                } else {
                    _currentRating = value;
                }
            }
        }
        protected int GamesCount { get { return allGames.Count;} }
        public BaseClass() {
            allGames = new List<GameLogs>();
            CurrentRating = 1;
        }
        public virtual string GetStats() {
            System.Console.WriteLine("Stats of " + this.UserName);
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
        public virtual void WinGame(PremiumGameAccount opponent, int rating) {
                this.CurrentRating += rating;
                allGames.Add(new GameLogs(UserName, CurrentRating, opponent.UserName, opponent.CurrentRating, "Win", GameLogs.gameIDSeed, rating));
        }
        public virtual void LoseGame(PremiumGameAccount opponent, int rating) {
                this.CurrentRating -= rating;
                allGames.Add(new GameLogs(UserName, CurrentRating, opponent.UserName, opponent.CurrentRating, "Lose", GameLogs.gameIDSeed, rating));
        }
        public virtual void WinGame(DefaultGameAccount opponent, int rating) {
                this.CurrentRating += rating;
                allGames.Add(new GameLogs(UserName, CurrentRating, opponent.UserName, opponent.CurrentRating, "Win", GameLogs.gameIDSeed, rating));
        }
        public virtual void LoseGame(DefaultGameAccount opponent, int rating) {
                this.CurrentRating -= rating;
                allGames.Add(new GameLogs(UserName, CurrentRating, opponent.UserName, opponent.CurrentRating, "Lose", GameLogs.gameIDSeed, rating));
        }
    }




    /*******************************************/
    public class DefaultGameAccount: BaseClass {
        public DefaultGameAccount(string name) : base() {   
            this.UserName = name;
        }
        
        
        public  void GameResult(DefaultGameAccount opponent, int rating, string outcome) {
            if(rating < 1) {
                throw new ArgumentOutOfRangeException(nameof(rating), "Rating cannot be less than 1");
            }
           
                if(outcome == "Win") {
                    this.WinGame(opponent, rating); 
                    opponent.LoseGame(this, rating);
                } else if(outcome == "Lose") {
                    this.LoseGame(opponent, rating);
                    opponent.WinGame(this, rating);
                } else {
                    throw new ArgumentException("You should pass correct outcome");
                }
            
        }
        public  void GameResult(PremiumGameAccount opponent, int rating, string outcome) {
            if(rating < 1) {
                throw new ArgumentOutOfRangeException(nameof(rating), "Rating cannot be less than 1");
            }
            
                if(outcome == "Win") {
                    this.WinGame(opponent, rating); 
                    opponent.LoseGame(this, rating);
                } else if(outcome == "Lose") {
                    this.LoseGame(opponent, rating);
                    opponent.WinGame(this, rating);
                } else {
                    throw new ArgumentException("You should pass correct outcome");
                }
            
        }
        
    }
      public class PremiumGameAccount: BaseClass {
        public PremiumGameAccount(string name) : base() {   
            this.UserName = name;
        }
        
        public  void GameResult(PremiumGameAccount opponent, int rating, string outcome) {
            if(rating < 1) {
                throw new ArgumentOutOfRangeException(nameof(rating), "Rating cannot be less than 1");
            }
            
                if(outcome == "Win") {
                    //getting 10 additinal points
                    this.WinGame(opponent, rating + 10); 
                    opponent.LoseGame(this, rating);
                } else if(outcome == "Lose") {
                    this.LoseGame(opponent, rating);
                    opponent.WinGame(this, rating);
                } else {
                    throw new ArgumentException("You should pass correct outcome");
                }
           
        }
        public  void GameResult(DefaultGameAccount opponent, int rating, string outcome) {
            if(rating < 1) {
                throw new ArgumentOutOfRangeException(nameof(rating), "Rating cannot be less than 1");
            }
           
                if(outcome == "Win") {
                    //getting 10 additinal points
                    this.WinGame(opponent, rating + 10); 
                    opponent.LoseGame(this, rating);
                } else if(outcome == "Lose") {
                    this.LoseGame(opponent, rating);
                    opponent.WinGame(this, rating);
                } else {
                    throw new ArgumentException("You should pass correct outcome");
                }
            
        }
        
    }
    
}