using Lab3.DB.Entity;
using Lab3.DB.Repository;
using Lab3.DB.Repository.Base;
using Lab3.DB.Services.Base;
using Laba3.Stats;

namespace Lab3.DB.Services
  {
  public class StatsService : IGameStatsService
    {
    private IGameStatsRepository gameStatsRepository;

    public StatsService(DbContext context)
      { gameStatsRepository = new StatsRepository(context); }


    public void CreateGame(Stats stats) 
    { 
      StatsEntity statsEntity = new();
      statsEntity.Winner = stats.Winner;
      statsEntity.Loser = stats.Loser;
      statsEntity.currentRating1 = stats.currentRating1;
      statsEntity.currentRating2 = stats.currentRating2;
      statsEntity.GameID = stats.GameId;
      statsEntity.gameType = stats.gameType;

      gameStatsRepository.Create(statsEntity);
    }

    public List<Stats> ReadGames()
      {
      return gameStatsRepository
        .Read()
        .Select(game => Map(game))
        .ToList();
      }

    public List<Stats> ReadPlayerGamesByPlayerId(int playerId)
      {
      var gameStatsEntities = gameStatsRepository
        .Read()
        .Where(game => game.Winner.playerID == playerId || game.Loser.playerID == playerId)
        .ToList();

      return gameStatsEntities
        .Select(game => Map(game))
        .ToList();
      }

    public Stats Map(StatsEntity statsEntity) 
    { 
      var stats = new Stats(statsEntity.Winner, 
        statsEntity.Loser, 
        statsEntity.currentRating1, 
        statsEntity.currentRating2,
        statsEntity.GameID,
        statsEntity.gameType);
      return stats;
      }
    }
  }
