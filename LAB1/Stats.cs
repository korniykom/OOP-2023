using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyGame;
public class GameLogs {
    public string opponentName { get; }
    public decimal OpponentRating { get; }
    public decimal rating { get; }
    public bool outcome { get; }
    public decimal winRate { get;}
    public decimal GameID { get; }
    //constructor
    public GameLogs(string name, decimal rating, decimal opponentRating, bool outcome, decimal rate, decimal id) {
        this.opponentName = name;
        this.rating = rating;
        this.outcome = outcome;
        this.winRate = rate;
        this.GameID = id;
        this.OpponentRating = opponentRating;
    }
}