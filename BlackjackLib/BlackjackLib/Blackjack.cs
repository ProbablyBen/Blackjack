namespace BlackjackLib
{
    using System;
    using Players;
    using Cards;
    using Result;

    /// <summary>
    ///     The <see cref="Blackjack"/> class handles all the game logic.
    /// </summary>
    public class Blackjack
    {
        public event EventHandler<CardDealtEventArgs> CardDealt;

        /// <summary>
        ///     The card deck
        /// </summary>
        private readonly IDeck _deck;

        /// <summary>
        ///     The dealer
        /// </summary>
        public readonly Dealer Dealer;

        /// <summary>
        ///     The player
        /// </summary>
        public readonly Player Player;

        /// <summary>
        ///     Initializes a new instance of the <see cref="Blackjack"/> class.
        /// </summary>
        public Blackjack() : this(new Dealer(), new Player())
        {
        }

        /// <summary>
        ///     Initializes a new instance of the <see cref="Blackjack"/> class.
        /// </summary>
        /// <param name="dealer">The dealer</param>
        /// <param name="player">The player</param>
        public Blackjack(Dealer dealer, Player player) : this(dealer, player, new Deck())
        {
        }

        /// <summary>
        ///     Initializes a new instance of the <see cref="Blackjack"/> class.
        /// </summary>
        /// <param name="dealer">The dealer</param>
        /// <param name="player">The player</param>
        /// <param name="deck">The deck</param>
        public Blackjack(Dealer dealer, Player player, IDeck deck)
        {
            Dealer = dealer;
            Player = player;
            _deck = deck;
        }

        /// <summary>
        ///     Prepares the game by shuffling the deck
        /// </summary>
        public void Initialize()
        {
            // Shuffle the deck
            _deck.Shuffle();
        }

        /// <summary>
        ///     Deals cards to the dealer and player
        /// </summary>
        public void FirstDeal()
        {
            for (int i = 0; i < 2; i++)
            {
                Deal(Dealer);
                Deal(Player);
            }
        }

        public void PlayDealer()
        {
            Dealer.Play(this);
        }

        public void HitPlayer()
        {
            Deal(Player);
        }

        /// <summary>
        ///     Finds the winner of the game.
        /// </summary>
        /// <returns>The result of the game.</returns>
        public GameResult GetResult()
        {
            var result = ResultChecker.GetResult(Dealer, Player);
            return result;
        }

        /// <summary>
        ///     Finds the natural winner of the game.
        /// </summary>
        /// <returns>The </returns>
        public GameResult GetNaturalResult()
        {
            var result = ResultChecker.GetNaturalResult(Dealer, Player);
            return result;
        }

        /// <summary>
        ///     Deals a card to a person
        /// </summary>
        /// <param name="person">The person to deal to</param>
        public void Deal(Person person)
        {
            var card = _deck.Pop();
            person.Hand.Add(card);
            OnCardDealt(new CardDealtEventArgs(person, card));
        }

        protected virtual void OnCardDealt(CardDealtEventArgs e)
        {
            CardDealt?.Invoke(this, e);
        }
    }
}
