namespace BlackjackLib.Players
{
    using System;
    using Cards;

    public class CardDealtEventArgs : EventArgs
    {
        public Card Card { get; }

        public Person DealtTo { get; }

        public CardDealtEventArgs(Person person, Card c)
        {
            DealtTo = person;
            Card = c;
        }
    }
}
