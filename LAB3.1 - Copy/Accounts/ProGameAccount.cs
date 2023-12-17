using Lab2.Games;
using Lab2.Games.States;
using Laba3.Accounts.States;

namespace Lab2.Accounts
  {
  public class ProGameAccount : GameAccount 
  {
    private readonly int MIN_STREAK = 3;
    public int Pro 
    {
      get
      {
        return winStreak > MIN_STREAK ? winStreak * 2 : 0;
      }
    }
    private int winStreak { get; set; } = 0;
    public ProGameAccount(string UserName, int rating) : base(UserName, rating)
      { Type = PlayerType.Pro; }


    public override void WinGame(Game game)
      {
      if (game.Type != GameType.Training) 
        winStreak++;
      Rating = Rating + Pro;
      base.WinGame(game);
      }

    public override void LoseGame(Game game)
      { 
        if (game.Type != GameType.Training) 
          winStreak = 0; 
        base.LoseGame(game);
      }
    }
  }
