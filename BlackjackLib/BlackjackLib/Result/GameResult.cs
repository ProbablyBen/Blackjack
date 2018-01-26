namespace BlackjackLib.Result
{
    using Players;

    public abstract class GameResult
    {
        public Person Winner { get; }

        public string Message { get; }

        public bool NaturalBlackjack { get; }

        protected GameResult(Person winner, string message) : this(winner, message, false)
        {
        }

        protected GameResult(Person winner, string message, bool natural)
        {
            Winner = winner;
            Message = message;
            NaturalBlackjack = natural;
        }
    }
}
