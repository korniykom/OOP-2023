using Lab2.Accounts;
using Lab2.Games.States;

namespace Lab3.DB.Entity
  {
  public class StatsEntity
    {
    public GameAccount Winner;

    public GameAccount Loser;

    public int currentRating1;

    public int currentRating2;

    public GameType gameType;

    public int GameID;
    }
  }
