using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyGame;

public class GameAccount {
    private List<GameLogs> allGames = new List<GameLogs>();
    public string UserName { get; }
    public decimal CurrentRating { get; set; }
    public decimal GamesCount { get; set; }

    public void WinGame(string opponentName, decimal rating) {
        if(rating < 1) {
            throw new ArgumentOutOfRangeException(nameof(rating), "Rating cannot be less than 1");
        }
        CurrentRating += rating;
        GamesCount++;
        var gameLog = new GameLogs(opponentName, CurrentRating);
        allGames.Add(gameLog);
    }
    public void LoseGame(string opponentName, decimal rating) {
        if(rating < 1) {
            throw new ArgumentOutOfRangeException(nameof(rating), "Rating cannot be less than 1");
        }
        if(CurrentRating - rating < 1) {
            CurrentRating = 1;
        }
        CurrentRating -= rating;
        GamesCount++;
        var gameLog = new GameLogs(opponentName, CurrentRating);
        allGames.Add(gameLog);
    }
    public string GetHistory() {
        var report = new System.Text.StringBuilder();
        decimal won = 0;
        decimal lost = 0;
        foreach(var item in allGames) {
            report.AppendLine($"________\n Player {UserName} had rating of {item.rating} point(s) after game against player {item.opponentName}");
        }
        return report.ToString();
    }
    //construct
    public GameAccount(string name) {
        this.UserName = name;
        this.GamesCount = 0;
        this.CurrentRating = 0;
    }
}
