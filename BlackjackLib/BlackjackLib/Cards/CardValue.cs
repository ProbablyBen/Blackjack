namespace BlackjackLib.Cards
{
    using Enums;

    public class CardValue
    {
        public CardName Name { get; }

        public int Value => GetValue();

        public CardValue(CardName name)
        {
            Name = name;
        }

        private int GetValue()
        {
            switch (Name)
            {
                case CardName.Two:
                    return 2;
                case CardName.Three:
                    return 3;
                case CardName.Four:
                    return 4;
                case CardName.Five:
                    return 5;
                case CardName.Six:
                    return 6;
                case CardName.Seven:
                    return 7;
                case CardName.Eight:
                    return 8;
                case CardName.Nine:
                    return 9;
                case CardName.Ten:
                case CardName.Jack:
                case CardName.Queen:
                case CardName.King:
                    return 10;
                case CardName.Ace:
                    return 11;
                default:
                    return -1;
            }
        }
    }
}
