using Lab3.DB.Entity;
using Lab3.DB.Repository.Base;

namespace Lab3.DB.Repository
  {
  public class StatsRepository : IGameStatsRepository
    {
    private DbContext context;

    public StatsRepository(DbContext context)
      { this.context = context; }

    public void Create(StatsEntity game)
      { context.Games.Add(game); }

    public void Delete(int ID)
      {
      throw new NotImplementedException();
      }

    public List<StatsEntity> Read()
      {
      return context.Games;
      }

    public void Update(StatsEntity game)
      {
      throw new NotImplementedException();
      }
    }
  }