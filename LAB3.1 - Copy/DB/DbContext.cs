using Lab3.DB.Entity;
using Laba3.Accounts.States;

namespace Lab3.DB
  {
  public class DbContext
    {
    public List<PlayerEntity> Accounts { get; set; }
    public List<StatsEntity> Games { get; set; }
    public DbContext()
      {
      Accounts = new() {
        new PlayerEntity {Name = "Norman", Rating = 20, Type = PlayerType.Noob},
        new PlayerEntity {Name = "Brian", Rating = 20, Type = PlayerType.Noob},
        new PlayerEntity {Name = "John", Rating = 20, Type = PlayerType.Noob},
        new PlayerEntity {Name = "Ryan", Rating = 200, Type = PlayerType.Pro},
        new PlayerEntity {Name = "Kyle", Rating = 200, Type = PlayerType.Pro},
        new PlayerEntity {Name = "Jason", Rating = 2000, Type = PlayerType.Hacker}
      };
      Games = new();
      }
    }
  }
