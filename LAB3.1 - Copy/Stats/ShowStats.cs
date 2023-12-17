namespace Laba3.Stats
  {
    public class ShowStats
    {
      public static string GetStatsForPlayers(string Username, List<Stats> History)
      {
        string res = $"\t\t\tGameHistory for {Username}\n\n";

        foreach (var game in History)
        {
          if (game.Winner.UserName == Username || game.Loser.UserName == Username)
            res +=
              $"| {game.GameId,-3}| {game.gameType,-10}" +
              $"| {game.Winner.UserName,-8}" +
              $"| {game.currentRating1,-4} -> {game.Winner.Rating,-6}" +
              $"| {game.Loser.UserName,-8} " +
              $"| {game.currentRating2,-4} -> {game.Loser.Rating,4}|\n";
        }

        return res;
      }
    public static string GetStats(List<Stats> History)
      {
        string res = "";

        foreach (var game in History)
        {
          res +=
            $"| {game.GameId,-3}| {game.gameType,-10}" +
            $"| {game.Winner.UserName,-8}" +
            $"| {game.currentRating1,-4} -> {game.Winner.Rating,-6}" +
            $"| {game.Loser.UserName,-8} " +
            $"| {game.currentRating2,-4} -> {game.Loser.Rating,4}|\n";
        }

        return res;
      }
    }
  }
