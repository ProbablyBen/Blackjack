namespace BlackjackLib.Result
{
    using Players;

    public class Bust : GameResult
    {
        public Bust(Person buster, string message) : base(buster, message, false)
        {
        }
    }
}
