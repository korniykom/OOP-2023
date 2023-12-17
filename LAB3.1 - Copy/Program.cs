using Lab2.Games.States;
using Lab2.Handlers;
using Lab3.DB;
using Lab3.DB.Services;
using Laba3.Stats;

namespace Lab2
  {
  internal class Program
    {
    static void Main(string[] args)
      {
      DbContext context = new();

      StatsService StatsService = new(context);
      PlayerService PlayerService = new(context);

      var players = PlayerService.ReadAccounts();

      GameFactory factory = new();

      var game = factory.CreateGame(GameType.Default);


      game.Play(players[0], players[2], StatsService);
      game.Play(players[3], players[2], StatsService);
      game.Play(players[5], players[1], StatsService);
      game.Play(players[4], players[0], StatsService);

      game = factory.CreateGame(GameType.Training);

      game.Play(players[0], players[2], StatsService);
      game.Play(players[3], players[2], StatsService);
      game.Play(players[5], players[1], StatsService);
      game.Play(players[4], players[0], StatsService);

      game = factory.CreateGame(GameType.Risk);

      game.Play(players[0], players[2], StatsService);
      game.Play(players[3], players[2], StatsService);
      game.Play(players[5], players[1], StatsService);
      game.Play(players[4], players[0], StatsService);

      Console.WriteLine(ShowStats.GetStatsForPlayers("Jason", StatsService.ReadGames()));

      Console.WriteLine("\t\t\tFull GameHistory\n");
      Console.WriteLine(ShowStats.GetStats(StatsService.ReadGames()));
      }
    }
  }