using Lab3.DB.Entity;
using Lab3.Handlers;
using Laba3.Accounts.States;

namespace Lab3.DB.Repository.Base
  {
  public interface IPlayerRepository
    {
    public void Create(PlayerType type, string name, int Rating);
    public List<PlayerEntity> Read();
    public PlayerEntity Update(string PlayerName);
    public void Delete(int playerID);
    }
  }
