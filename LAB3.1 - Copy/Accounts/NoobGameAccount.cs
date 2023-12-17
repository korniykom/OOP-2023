using Lab2.Accounts;
using Lab2.Games;
using Laba3.Accounts.States;

namespace Laba3.Accounts
  {
  public class NoobGameAccount : GameAccount
    {
    public NoobGameAccount(string UserName, int rating) : base(UserName, rating)
      { Type = PlayerType.Noob; }

    public override void WinGame(Game game)
      { Rating = Rating + game.GetRating(this); }

    public override void LoseGame(Game game)
      {
      Rating = Rating - game.GetRating(this);
      }
    }
  }