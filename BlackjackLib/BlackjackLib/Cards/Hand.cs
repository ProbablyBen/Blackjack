namespace BlackjackLib.Cards
{
    using System.Collections.Generic;
    using System.Linq;
    using Enums;

    public class Hand
    {
        public Card[] Cards => _cards.ToArray();

        private readonly List<Card> _cards;

        public int Total
        {
            get
            {
                int total = Cards.Sum(x => x.Value.Value);

                int totalAces = Cards.Count(x => x.Value.Name == CardName.Ace);

                // Determine whether to use 11 or 1 for ace
                while (total > Win && totalAces != 0)
                {
                    // Treat ace as 1
                    total -= 10;
                    totalAces--;
                }

                return total;
            }
        }

        /// <summary>
        ///     The win constant for blackjack.
        ///     You must get 21 to receive a blackjack
        /// </summary>
        public const int Win = 21;

        public bool IsBusted => Total > Win;

        public void Add(Card c)
        {
            _cards.Add(c);
        }

        public Hand()
        {
            _cards = new List<Card>();
        }
    }
}
