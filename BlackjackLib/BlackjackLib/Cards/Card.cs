namespace BlackjackLib.Cards
{
    using System;
    using Enums;

    public class Card : IEquatable<Card>
    {

        public CardSuit Suit { get; }

        public CardValue Value { get; }

        public Card(CardSuit suit, CardValue value)
        {
            Suit = suit;
            Value = value;
        }

        public override string ToString()
        {
            return Enum.GetName(typeof(CardName), Value.Name) + " of " + Enum.GetName(typeof(CardSuit), Suit);
        }

        public bool Equals(Card other)
        {
            if (other is null) return false;
            if (this == other) return true;
            return Suit == other.Suit && Equals(Value.Value, other.Value.Value);
        }

    }
}
