using Lab2.Games.States;
using Lab2.Games;

namespace Lab2.Handlers
  {
  public class GameFactory
    {
    public Game CreateGame(GameType type) 
    { 
        if (type == GameType.Default) { return new DefaultGame(); }
        
        else if (type == GameType.Training) { return new TrainingGame(); }
        
        else if (type == GameType.Risk) { return new RiskGame(); }
        
        else { throw new ArgumentException("Немає такого типу гри"); }
      }
    }
  }