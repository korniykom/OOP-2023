using Laba3.Accounts.States;

namespace Lab3.DB.Entity
  {
  public class PlayerEntity
    {
    public string Name { get; set; }
    public int Rating { get; set; }
    public PlayerType Type { get; set; }
    public int playerId { get; set; }
    }
  }
