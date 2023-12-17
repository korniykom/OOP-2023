using Lab3.DB.Entity;
using Lab3.DB.Repository.Base;

namespace Lab3.DB.Repository
  {
  public class PlayerRepository : IPlayerRepository
    {
    private DbContext context;

    public PlayerRepository(DbContext context)
      { this.context = context; }
    public void Create(PlayerEntity player)
      { context.Accounts.Add(player); }
    public void Delete(int playerID)
      {
      PlayerEntity player = context.Accounts.FirstOrDefault(acc => acc.playerId == playerID);

      if (player != null)
        { 
          context.Accounts.Remove(player);
        }
      else
        { 
          Console.WriteLine("Користувача не знайдено");
        }
      }
    public List<PlayerEntity> Read()
      { 
        return context.Accounts;
      }
    public PlayerEntity Update(string playerName)
      { 
        var player = context.Accounts.FirstOrDefault(player => player.Name == playerName); 
        return player;
      }
    }
  }