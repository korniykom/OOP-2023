using Lab2.Accounts;
using Lab2.Games.States;
using Lab3.DB.Services;
using Laba3.Stats;

namespace Lab2.Games
  {
  public abstract class Game
    {
    protected static int GameID = 1;
    public GameType Type { get; protected init; }
    public abstract int GetRating(GameAccount player);
    public virtual void Play(GameAccount player1, GameAccount player2, StatsService Service)
      {
      Random random = new();
      int temp = random.Next(0, 2);
      int currentRating1 = player1.Rating;
      int currentRating2 = player2.Rating;

      if (temp == 0)
        {
        player1.ChangeRating(this, player2);
        var plr1 = new GameAccount(player1.UserName, player1.Rating);
        var plr2 = new GameAccount(player2.UserName, player2.Rating);
        var game_stats = new Stats(plr1, plr2, currentRating1, currentRating2, GameID, Type);
        Service.CreateGame(game_stats);
        GameID++;
        }
      }
    }
  }