using Lab2.Accounts;
using Lab3.DB.Entity;
using Lab3.DB.Repository;
using Lab3.DB.Repository.Base;
using Lab3.DB.Services.Base;
using Lab3.Handlers;

namespace Lab3.DB.Services
  {
  public class PlayerService : IPlayerService
    {
    private IPlayerRepository playerRepository;
    public PlayerService(DbContext context)
      {
      playerRepository = new PlayerRepository(context);
      }
    public void CreateAccount(GameAccount player)
      {
      PlayerEntity playerEntity = new();
      playerEntity.Name = player.UserName;
      playerEntity.Rating = player.Rating;
      playerEntity.playerId = player.playerID;
      playerRepository.Create(playerEntity);
      }
    public void DeleteAccountByID(int playerID)
      {
      playerRepository.Delete(playerID);
      }
    public void UpdatePlayerName(string PlayerName, string NewName)
      {
      var player = playerRepository.Update(PlayerName);
      player.Name = NewName;
      }
    public List<GameAccount> ReadAccounts()
      {
      return playerRepository.Read().Select(player => Map(player)).ToList();
      }
    public List<GameAccount> ReadAccountByUserName(string UserName)
      {
      List<PlayerEntity> accountsEntites = playerRepository
          .Read()
          .Where(player => player.Name == UserName)
          .ToList();
      return accountsEntites.Select(player => Map(player)).ToList();
      }
    private GameAccount Map(PlayerEntity player)
      {
      PlayerFactory factory = new();
      var Account = factory.CreateAccount(player.Type, player.Name, player.Rating);
      return Account;
      }
    }
  }
