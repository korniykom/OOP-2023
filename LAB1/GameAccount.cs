using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyGame;

public class GameAccount {
    private List<GameLogs> allGames = new List<GameLogs>();
    private decimal gameSeed = 100;
    public string UserName { get; }
    public decimal CurrentRating { get; set; }
    public decimal GamesCount { get; set; }
    public void WinGame(GameAccount opponent, decimal rating) {
        if(rating < 1) {
            throw new ArgumentOutOfRangeException(nameof(rating), "Rating cannot be less than 1");
        }
        decimal id = gameSeed;
        gameSeed++;
        if(opponent.CurrentRating - rating < 1) {
            opponent.CurrentRating = 1;
            CurrentRating += rating - opponent.CurrentRating;
        } else {
            opponent.CurrentRating = opponent.CurrentRating - rating;
            CurrentRating += rating;
        }
        GamesCount++;
        var gameLog = new GameLogs(opponent.UserName, CurrentRating, opponent.CurrentRating, true, rating, id);
        allGames.Add(gameLog);
        var opponentGameLog = new GameLogs(UserName, opponent.CurrentRating, CurrentRating, false, rating, id);
        opponent.allGames.Add(opponentGameLog);
    }
    public void LoseGame(GameAccount opponent, decimal rating) {
        if(rating < 1) {
            throw new ArgumentOutOfRangeException(nameof(rating), "Rating cannot be less than 1");
        }
        if(CurrentRating - rating < 1) {
            CurrentRating = 1;
            opponent.CurrentRating += rating - CurrentRating;
        } else {
        CurrentRating -= rating;
        opponent.CurrentRating += rating;
        }
        decimal id = gameSeed;
        gameSeed++;
        GamesCount++;
        var gameLog = new GameLogs(opponent.UserName, CurrentRating, opponent.CurrentRating, false, rating, id);
        allGames.Add(gameLog);

        var opponentGameLog = new GameLogs(UserName, opponent.CurrentRating, CurrentRating, true, rating, id);
        opponent.allGames.Add(opponentGameLog);
    }
    public string GetStats() {
        System.Console.WriteLine("Stats of " + UserName);
        var report = new System.Text.StringBuilder();
        var outcome = "Won";
        decimal Rate = 0;
        report.AppendLine("|--------|----------|------------|--------------|-------|----|------|");
        report.AppendLine("|UserName|UserRating|OpponentName|OpponentRating|Outcome|Rate|GameID|");
        report.AppendLine("|--------|----------|------------|--------------|-------|----|------|");
        foreach(var item in allGames) {
            if(item.outcome) {
                outcome = "Won";
                Rate = item.winRate;
            } else {
                outcome = "Lost";
                Rate = -item.winRate;
            }
            report.AppendLine(String.Format("|{0,8}|{1,10}|{2,12}|{3,14}|{4,7}|{5,4}|{6,6}|", UserName, item.rating, item.opponentName,item.OpponentRating, outcome, Rate, item.GameID));
            report.AppendLine("|--------|----------|------------|--------------|-------|----|------|");
        }
        return report.ToString();
    }
    //construct
    public GameAccount(string name) {
        this.UserName = name;
        this.GamesCount = 0;
        this.CurrentRating = 1;
    }
}
