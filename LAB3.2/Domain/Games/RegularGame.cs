namespace MyGame
{
    public class RegularGame : BaseGame
    {
        public override BaseGame PlayAGame(BaseAccount winner, BaseAccount loser, int bet)
        {
            if(bet < 1)
            {
                throw new ArgumentOutOfRangeException(nameof(bet), "Rating connot be less than 1");               
            }
            if(winner != loser)
            {
                var regularGame = new RegularGame(winner, loser, bet);
                return regularGame;
            }
        }
    }
}
}