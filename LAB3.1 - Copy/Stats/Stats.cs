using Lab2.Accounts;
using Lab2.Games.States;

namespace Laba3.Stats
  {
  public class Stats
    {
    public GameAccount Winner;
    public GameAccount Loser;
    public int currentRating1;
    public int currentRating2;
    public GameType gameType;
    public int GameId;


    public Stats(GameAccount Winner, GameAccount Loser, int currentRating1, int currentRating2, int GameId, GameType gameType)
      {
      this.Winner = Winner;
      this.Loser = Loser;
      this.currentRating1 = currentRating1;
      this.currentRating2 = currentRating2;
      this.GameId = GameId;
      this.gameType = gameType;
      }
    }
  }
