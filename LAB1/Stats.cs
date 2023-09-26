using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyGame;
public class GameLogs {
    public string opponentName { get; }
    public decimal rating { get; }
    //constructor
    public GameLogs(string name, decimal rating) {
        this.opponentName = name;
        this.rating = rating;
    }
}