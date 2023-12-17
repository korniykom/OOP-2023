using Lab2.Accounts;
using Lab2.Games.States;

namespace Lab2.Games
  {
  class DefaultGame : Game
    {
    public DefaultGame()
      {
      Type = GameType.Default;
      }
    public override int GetRating(GameAccount player)
      {
      return 20;
      }
    }
  }
