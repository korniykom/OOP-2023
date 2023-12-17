using Lab2.Accounts;
using Lab2.Games.States;

namespace Lab2.Games
{
  class RiskGame : Game
  {
    public RiskGame()
    {
      Type = GameType.Risk; 
    }
    public override int GetRating(GameAccount player)
    {
      return player.Rating;
    }
  }
}