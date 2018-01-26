using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Blackjack
{
    using BlackjackLib;
    using BlackjackLib.Players;
    using BlackjackLib.Result;

    public partial class FrmMain : Form
    {
        private Blackjack _game;

        public int TotalPlayerWins { get; set; }

        public int TotalDealerWins { get; set; }

        public int TotalTies { get; set; }

        public FrmMain()
        {
            InitializeComponent();
        }

        private void BtnToggleGame_Click(object sender, EventArgs e)
        {
            // Toggle buttons
            btnToggleGame.Visible = !btnToggleGame.Visible;
            btnHit.Visible = !btnHit.Visible;
            btnStand.Visible = !btnStand.Visible;

            SetupGame();
        }

        private void OnCardDealt(object sender, CardDealtEventArgs e)
        {
            if (e.DealtTo is Player)
            {
                lstPlayer.Items.Add(e.Card);
                lblPlayerTotal.Text = "Total: " + _game.Player.Hand.Total;
            }
            else if (e.DealtTo is Dealer)
            {
                UpdateDealerCards(true);
            }
        }

        private void BtnHit_Click(object sender, EventArgs e)
        {
            _game.HitPlayer();
            if (_game.Player.Hand.IsBusted)
            {
                CheckResult();
            }
        }

        private void BtnStand_Click(object sender, EventArgs e)
        {
            // Dealers turn
            _game.PlayDealer();

            CheckResult();
        }

        private void CheckResult()
        {
            var result = _game.GetResult();
            if (result != null)
            {
                UpdateDealerCards(false);
                MessageBox.Show(result.Message);
                UpdateWins(result);
                SetupGame();
            }
        }

        private void UpdateDealerCards(bool hideCards)
        {
            if (_game.Dealer.Hand.Cards.Length < 2)
            {
                return;
            }

            lstDealer.Items.Clear();

            if (hideCards)
            {
                lstDealer.Items.Add("Hidden");
                lstDealer.Items.Add(_game.Dealer.Hand.Cards[1]);
                lblDealerTotal.Text = "Total: Hidden";
            }
            else
            {
                foreach (var card in _game.Dealer.Hand.Cards)
                {
                    lstDealer.Items.Add(card);
                    lblDealerTotal.Text = "Total: " + _game.Dealer.Hand.Total;
                }
            }
        }

        private void SetupGame()
        {
            // Reset items
            lstDealer.Items.Clear();
            lstPlayer.Items.Clear();


            _game = new Blackjack(new Dealer("Dealer"), new Player("Player"));
            _game.CardDealt += OnCardDealt;

            lblDealerName.Text = _game.Dealer.Name;
            lblPlayerName.Text = _game.Player.Name;

            // Initialize game
            _game.Initialize();
            _game.FirstDeal();
            UpdateDealerCards(true);

            // Check for natural blackjacks
            _game.GetNaturalResult();
        }

        private void UpdateWins(GameResult result)
        {
            if (result is Win || result is Bust)
            {
                switch (result.Winner)
                {
                    case Player _:
                        TotalPlayerWins++;
                        break;
                    case Dealer _:
                        TotalDealerWins++;
                        break;
                }
            }
            else if (result is Tie)
            {
                TotalTies++;
            }
            lblDealerWins.Text = "Dealer Wins: " + TotalDealerWins;
            lblPlayerWins.Text = "Player Wins: " + TotalPlayerWins;
            lblTies.Text = "Ties: " + TotalTies;
        }
    }
}
