using Lab2.Accounts;
using Laba3.Accounts;
using Laba3.Accounts.States;

namespace Lab3.Handlers
  {
  public class PlayerFactory
    {
    public GameAccount CreateAccount(PlayerType type, string UserName, int Rating)
      {
      if (type == PlayerType.Noob)
        { return new NoobGameAccount(UserName, Rating); }

      else if (type == PlayerType.Pro)
        { return new ProGameAccount(UserName, Rating); }

      else if (type == PlayerType.Hacker) 
      { return new HackerGameAccount(UserName, Rating); }

      else 
      { throw new ArgumentException("Немає такого типу гравця"); }
        
      }
    }
  }
