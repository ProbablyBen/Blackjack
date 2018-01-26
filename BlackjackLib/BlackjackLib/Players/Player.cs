namespace BlackjackLib.Players
{
    using Cards;

    public class Player : Person
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="Player"/> class.
        /// </summary>
        public Player() : this("Player")
        {
        }

        /// <summary>
        ///     Initializes a new instance of the <see cref="Player"/> class.
        /// </summary>
        /// <param name="name">The player name</param>
        public Player(string name) : base(new Hand(), name)
        {
        }
    }
}
