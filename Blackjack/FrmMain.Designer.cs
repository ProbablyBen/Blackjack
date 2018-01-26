namespace Blackjack
{
    partial class FrmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.btnToggleGame = new System.Windows.Forms.Button();
            this.btnHit = new System.Windows.Forms.Button();
            this.btnStand = new System.Windows.Forms.Button();
            this.lstDealer = new System.Windows.Forms.ListBox();
            this.lstPlayer = new System.Windows.Forms.ListBox();
            this.lblPlayerName = new System.Windows.Forms.Label();
            this.lblDealerName = new System.Windows.Forms.Label();
            this.lblPlayerTotal = new System.Windows.Forms.Label();
            this.lblDealerTotal = new System.Windows.Forms.Label();
            this.lblDealerWins = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblPlayerWins = new System.Windows.Forms.Label();
            this.lblTies = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnToggleGame
            // 
            this.btnToggleGame.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(33)))), ((int)(((byte)(122)))));
            this.btnToggleGame.FlatAppearance.BorderSize = 0;
            this.btnToggleGame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnToggleGame.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnToggleGame.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnToggleGame.Location = new System.Drawing.Point(239, 147);
            this.btnToggleGame.Name = "btnToggleGame";
            this.btnToggleGame.Size = new System.Drawing.Size(75, 46);
            this.btnToggleGame.TabIndex = 7;
            this.btnToggleGame.Text = "Start Game";
            this.btnToggleGame.UseVisualStyleBackColor = false;
            this.btnToggleGame.Click += new System.EventHandler(this.BtnToggleGame_Click);
            // 
            // btnHit
            // 
            this.btnHit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(33)))), ((int)(((byte)(122)))));
            this.btnHit.FlatAppearance.BorderSize = 0;
            this.btnHit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHit.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHit.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnHit.Location = new System.Drawing.Point(239, 252);
            this.btnHit.Name = "btnHit";
            this.btnHit.Size = new System.Drawing.Size(75, 23);
            this.btnHit.TabIndex = 8;
            this.btnHit.Text = "Hit";
            this.btnHit.UseVisualStyleBackColor = false;
            this.btnHit.Visible = false;
            this.btnHit.Click += new System.EventHandler(this.BtnHit_Click);
            // 
            // btnStand
            // 
            this.btnStand.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(33)))), ((int)(((byte)(122)))));
            this.btnStand.FlatAppearance.BorderSize = 0;
            this.btnStand.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStand.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStand.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnStand.Location = new System.Drawing.Point(239, 281);
            this.btnStand.Name = "btnStand";
            this.btnStand.Size = new System.Drawing.Size(75, 23);
            this.btnStand.TabIndex = 9;
            this.btnStand.Text = "Stand";
            this.btnStand.UseVisualStyleBackColor = false;
            this.btnStand.Visible = false;
            this.btnStand.Click += new System.EventHandler(this.BtnStand_Click);
            // 
            // lstDealer
            // 
            this.lstDealer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.lstDealer.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lstDealer.Font = new System.Drawing.Font("Consolas", 9.75F);
            this.lstDealer.ForeColor = System.Drawing.Color.Gainsboro;
            this.lstDealer.FormattingEnabled = true;
            this.lstDealer.ItemHeight = 15;
            this.lstDealer.Location = new System.Drawing.Point(13, 40);
            this.lstDealer.Name = "lstDealer";
            this.lstDealer.Size = new System.Drawing.Size(193, 135);
            this.lstDealer.TabIndex = 10;
            // 
            // lstPlayer
            // 
            this.lstPlayer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.lstPlayer.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lstPlayer.Font = new System.Drawing.Font("Consolas", 9.75F);
            this.lstPlayer.ForeColor = System.Drawing.Color.Gainsboro;
            this.lstPlayer.FormattingEnabled = true;
            this.lstPlayer.ItemHeight = 15;
            this.lstPlayer.Location = new System.Drawing.Point(13, 252);
            this.lstPlayer.Name = "lstPlayer";
            this.lstPlayer.Size = new System.Drawing.Size(193, 135);
            this.lstPlayer.TabIndex = 11;
            // 
            // lblPlayerName
            // 
            this.lblPlayerName.AutoSize = true;
            this.lblPlayerName.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerName.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblPlayerName.Location = new System.Drawing.Point(12, 234);
            this.lblPlayerName.Name = "lblPlayerName";
            this.lblPlayerName.Size = new System.Drawing.Size(49, 15);
            this.lblPlayerName.TabIndex = 12;
            this.lblPlayerName.Text = "Player";
            // 
            // lblDealerName
            // 
            this.lblDealerName.AutoSize = true;
            this.lblDealerName.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDealerName.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblDealerName.Location = new System.Drawing.Point(12, 22);
            this.lblDealerName.Name = "lblDealerName";
            this.lblDealerName.Size = new System.Drawing.Size(49, 15);
            this.lblDealerName.TabIndex = 13;
            this.lblDealerName.Text = "Dealer";
            // 
            // lblPlayerTotal
            // 
            this.lblPlayerTotal.AutoSize = true;
            this.lblPlayerTotal.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerTotal.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblPlayerTotal.Location = new System.Drawing.Point(12, 390);
            this.lblPlayerTotal.Name = "lblPlayerTotal";
            this.lblPlayerTotal.Size = new System.Drawing.Size(56, 15);
            this.lblPlayerTotal.TabIndex = 14;
            this.lblPlayerTotal.Text = "Total: ";
            // 
            // lblDealerTotal
            // 
            this.lblDealerTotal.AutoSize = true;
            this.lblDealerTotal.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDealerTotal.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblDealerTotal.Location = new System.Drawing.Point(12, 178);
            this.lblDealerTotal.Name = "lblDealerTotal";
            this.lblDealerTotal.Size = new System.Drawing.Size(56, 15);
            this.lblDealerTotal.TabIndex = 15;
            this.lblDealerTotal.Text = "Total: ";
            // 
            // lblDealerWins
            // 
            this.lblDealerWins.AutoSize = true;
            this.lblDealerWins.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDealerWins.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblDealerWins.Location = new System.Drawing.Point(6, 19);
            this.lblDealerWins.Name = "lblDealerWins";
            this.lblDealerWins.Size = new System.Drawing.Size(91, 15);
            this.lblDealerWins.TabIndex = 16;
            this.lblDealerWins.Text = "Dealer Wins:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblTies);
            this.groupBox1.Controls.Add(this.lblPlayerWins);
            this.groupBox1.Controls.Add(this.lblDealerWins);
            this.groupBox1.Font = new System.Drawing.Font("Consolas", 9.75F);
            this.groupBox1.ForeColor = System.Drawing.Color.Gainsboro;
            this.groupBox1.Location = new System.Drawing.Point(239, 35);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(154, 100);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Stats";
            // 
            // lblPlayerWins
            // 
            this.lblPlayerWins.AutoSize = true;
            this.lblPlayerWins.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerWins.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblPlayerWins.Location = new System.Drawing.Point(6, 44);
            this.lblPlayerWins.Name = "lblPlayerWins";
            this.lblPlayerWins.Size = new System.Drawing.Size(91, 15);
            this.lblPlayerWins.TabIndex = 17;
            this.lblPlayerWins.Text = "Player Wins:";
            // 
            // lblTies
            // 
            this.lblTies.AutoSize = true;
            this.lblTies.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTies.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblTies.Location = new System.Drawing.Point(6, 70);
            this.lblTies.Name = "lblTies";
            this.lblTies.Size = new System.Drawing.Size(42, 15);
            this.lblTies.TabIndex = 18;
            this.lblTies.Text = "Ties:";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(405, 432);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblDealerTotal);
            this.Controls.Add(this.lblPlayerTotal);
            this.Controls.Add(this.lblDealerName);
            this.Controls.Add(this.lblPlayerName);
            this.Controls.Add(this.lstPlayer);
            this.Controls.Add(this.lstDealer);
            this.Controls.Add(this.btnStand);
            this.Controls.Add(this.btnHit);
            this.Controls.Add(this.btnToggleGame);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Blackjack";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnToggleGame;
        private System.Windows.Forms.Button btnHit;
        private System.Windows.Forms.Button btnStand;
        private System.Windows.Forms.ListBox lstDealer;
        private System.Windows.Forms.ListBox lstPlayer;
        private System.Windows.Forms.Label lblPlayerName;
        private System.Windows.Forms.Label lblDealerName;
        private System.Windows.Forms.Label lblPlayerTotal;
        private System.Windows.Forms.Label lblDealerTotal;
        private System.Windows.Forms.Label lblDealerWins;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblPlayerWins;
        private System.Windows.Forms.Label lblTies;
    }
}

