namespace BlackjackLib.Result
{
    using Players;

    public class Win : GameResult
    {
        public Win(Person winner, string message) : base(winner, message)
        {
        }

        public Win(Person winner, string message, bool natural) : base(winner, message, natural)
        {
        }
    }
}
