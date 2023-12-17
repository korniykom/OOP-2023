using Lab2.Accounts;

namespace Lab3.DB.Services.Base
  {
  public interface IPlayerService
    {
    public void CreateAccount(GameAccount player);
    public void DeleteAccountByID(int playerID);
    public void UpdatePlayerName(string PrevName, string NewName);
    public List<GameAccount> ReadAccounts();
    public List<GameAccount> ReadAccountByUserName(string UserName);
    }
  }
