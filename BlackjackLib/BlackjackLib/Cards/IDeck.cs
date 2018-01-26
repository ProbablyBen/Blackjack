using System.Collections.Generic;

namespace BlackjackLib.Cards
{
    public interface IDeck
    {
        void Shuffle();
        Card Pop();
    }
}
