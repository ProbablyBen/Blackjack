namespace BlackjackLib.Cards
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Security.Cryptography;
    using System.Text;
    using Enums;

    public class Deck : IDeck
    {
        /// <summary>
        ///     The internal implementation of the card deck
        /// </summary>
        private List<Card> _deck;

        /// <summary>
        ///     Initializes a new instance of the <see cref="Deck"/> class.
        /// </summary>
        public Deck()
        {
            Create();
        }

        /// <summary>
        ///     Shuffles the deck with the Fisher-Yates Shuffle
        /// </summary>
        public void Shuffle()
        {
            Shuffle(_deck);
        }

        // See https://stackoverflow.com/questions/273313/randomize-a-listt
        private void Shuffle<T>(IList<T> list)
        {
            var provider = new RNGCryptoServiceProvider();
            int n = list.Count;
            while (n > 1)
            {
                byte[] box = new byte[1];
                do provider.GetBytes(box);
                while (!(box[0] < n * (byte.MaxValue / n)));

                int k = (box[0] % n);
                n--;
                T value = list[k];
                list[k] = list[n];
                list[n] = value;
            }
        }

        /// <summary>
        ///     Creates a new deck filled with cards
        /// </summary>
        private void Create()
        {
            var tempDeck = new List<Card>();

            // Get every suit
            var suits = Enum.GetValues(typeof(CardSuit)).Cast<CardSuit>().ToList();

            // Get all card names
            var names = Enum.GetValues(typeof(CardName)).Cast<CardName>().ToList();

            foreach (var suit in suits)
            {
                foreach (var name in names)
                {
                    tempDeck.Add(new Card(suit, new CardValue(name)));
                }
            }

            _deck = tempDeck;
        }

        /// <summary>
        ///     Pops a new card off the bottom of the deck
        /// </summary>
        /// <returns>A card from the deck</returns>
        public Card Pop()
        {
            var card = _deck[0];
            _deck.Remove(card);
            return card;
        }

        public override string ToString()
        {
            var sb = new StringBuilder();

            foreach (var card in _deck)
            {
                sb.Append(card.ToString());
            }

            return sb.ToString();
        }
    }
}
