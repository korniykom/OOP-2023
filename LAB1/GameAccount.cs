using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyGame;

public class GameAccount {
    private List<GameLogs> allGames = new List<GameLogs>();
    public string UserName { get; }
    public decimal CurrentRating { get; }
    public decimal GamesCount { get; }

    public void WinGame(string opponentName, decimal rating) {
        if(rating < 1) {
            throw new ArgumentOutOfRangeException(nameof(rating), "Rating cannot be less than 1");
        }
        var gameLog = new GameLogs(opponentName, rating);
        allGames.Add(gameLog);
    }
    public void LoseGame(string opponentName, decimal rating) {
        // to do
    }
    //construct
    public GameAccount(string name) {
        this.UserName = name;
        this.GamesCount = 0;
        this.CurrentRating = 0;
    }
}
