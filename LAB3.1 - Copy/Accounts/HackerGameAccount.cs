using Lab2.Games;
using Laba3.Accounts.States;

namespace Lab2.Accounts
  {
  class HackerGameAccount : GameAccount
    {
    public HackerGameAccount(string UserName, int rating) : base(UserName, rating)
      {
      Type = PlayerType.Hacker;
      }

    public override void LoseGame(Game game)
      {
      Rating = Rating - game.GetRating(this) / 2;
      }
    }
  }