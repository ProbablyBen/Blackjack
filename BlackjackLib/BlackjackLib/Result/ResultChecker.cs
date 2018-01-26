namespace BlackjackLib.Result
{
    using Cards;
    using Players;

    internal class ResultChecker
    {
        public static GameResult GetResult(Dealer dealer, Player player)
        {
            var busted = CheckBust(dealer, player);
            if (busted != null)
            {
                // Someone has busted
                return busted;
            }

            var tied = CheckTie(dealer, player);
            if (tied != null)
            {
                // Someone has tied
                return tied;
            }

            // Check if dealer has more
            if (dealer.Hand.Total > player.Hand.Total)
            {
                return new Win(dealer, dealer.Name + " has won!");
            }
            else
            {
                // Player has more
                return new Win(player, player.Name + " has won!");
            }
        }

        public static GameResult GetNaturalResult(Dealer dealer, Player player)
        {
            var busted = CheckBust(dealer, player);

            if (busted != null)
            {
                // Someone has busted
                return busted;
            }

            // Tie natural
            if (player.Hand.Total == Hand.Win && dealer.Hand.Total == Hand.Win)
            {
                return new Tie();
            }

            // Player natural
            if (player.Hand.Total == Hand.Win)
            {
                return new Win(player, dealer.Name + " has won!", true);
            }
            // Dealer natural
            if (player.Hand.Total == Hand.Win)
            {
                return new Win(dealer, dealer.Name + " has won!", true);
            }

            // No natural win
            return null;
        }

        /// <summary>
        ///     Checks if one person has busted
        /// </summary>
        /// <param name="dealer">The dealer</param>
        /// <param name="player">The player</param>
        /// <returns>An instance of the <see cref="Bust"/> class if busted; otherwise null</returns>
        public static Bust CheckBust(Dealer dealer, Player player)
        {
            if (player.Hand.IsBusted)
            {
                return new Bust(dealer, player.Name + " has busted!");
            }

            if (dealer.Hand.IsBusted)
            {
                return new Bust(player, dealer.Name + " has busted!");
            }
            return null;
        }

        /// <summary>
        ///     Checks for a tie in blackjack
        /// </summary>
        /// <returns>An instance of the <see cref="Tie"/> class if tied; otherwise null</returns>
        public static Tie CheckTie(Dealer dealer, Player player)
        {
            if (dealer.Hand.Total == player.Hand.Total)
            {
                return new Tie();
            }
            return null;
        }

    }
}
