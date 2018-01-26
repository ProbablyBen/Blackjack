namespace BlackjackLib.Players
{
    using Cards;

    public class Dealer : Person
    {
        public const int MaxHit = 16;

        public Dealer() : this("Player")
        {
        }

        public Dealer(string name) : base(new Hand(), name)
        {
        }

        public void Play(Blackjack game)
        {
            while (Hand.Total <= MaxHit)
            {
                game.Deal(this);
            }
        }
    }
}
