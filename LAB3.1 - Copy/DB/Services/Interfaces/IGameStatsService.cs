using Laba3.Stats;

namespace Lab3.DB.Services.Base
  {
  public interface IGameStatsService
    {
    public void CreateGame(Stats gameStats);
    public List<Stats> ReadGames();
    public List<Stats> ReadPlayerGamesByPlayerId(int playerID);
    }
  }
