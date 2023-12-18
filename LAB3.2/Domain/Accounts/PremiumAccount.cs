namespace MyGame
{
    public class PremiumAccount : BaseAccount
    {
        public PremiumAccount (string name) : base(name)
        {
            CurrentRating = 100;
        }
        public override int CalculatePoints(int bet, string outcome)
        {
            if(outcome == "Win")
            {
                return bet * 2;
            } 
            else if(outcome == "Lose")
            {
                return bet / 2;
            }
            else
            {
                throw new ArgumentException("Parameter should be \"Win\" or \"Lose\"");
            }
        }
    }
}