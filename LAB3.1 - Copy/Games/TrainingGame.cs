using Lab2.Accounts;
using Lab2.Games.States;

namespace Lab2.Games
  {
  class TrainingGame : Game
    {
      public TrainingGame()
      {
        Type = GameType.Training;
      }
    public override int GetRating(GameAccount player) { return 0; }
    }
  }
