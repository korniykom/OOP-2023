using Lab3.DB.Entity;
namespace Lab3.DB.Repository.Base
  {
  public interface IGameStatsRepository
    {
    public void Create(StatsEntity game);
    public List<StatsEntity> Read();
    public void Update(StatsEntity game);
    public void Delete(int ID);
    }
  }
