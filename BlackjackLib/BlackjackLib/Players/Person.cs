namespace BlackjackLib.Players
{
    using Cards;

    public abstract class Person
    {
        public Hand Hand { get; }

        public string Name { get; }

        protected Person(Hand hand, string name)
        {
            Hand = hand;
            Name = name;
        }
    }
}
