namespace Battleship_Grid_Game
{
    partial class game3
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
            this.game3panel = new System.Windows.Forms.Panel();
            this.EndGame = new System.Windows.Forms.PictureBox();
            this.rulesBtn = new System.Windows.Forms.PictureBox();
            this.NewGame = new System.Windows.Forms.PictureBox();
            this.InstructionsLabel = new System.Windows.Forms.Label();
            this.TimerLabel = new System.Windows.Forms.Label();
            this.computerShipsRemaining = new System.Windows.Forms.Label();
            this.playerShipsRemaining = new System.Windows.Forms.Label();
            this.roundCounter = new System.Windows.Forms.Label();
            this.game3panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EndGame)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rulesBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NewGame)).BeginInit();
            this.SuspendLayout();
            // 
            // game3panel
            // 
            this.game3panel.BackColor = System.Drawing.Color.DarkCyan;
            this.game3panel.BackgroundImage = global::Battleship_Grid_Game.Properties.Resources._Game_Hard_level;
            this.game3panel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.game3panel.Controls.Add(this.InstructionsLabel);
            this.game3panel.Controls.Add(this.TimerLabel);
            this.game3panel.Controls.Add(this.computerShipsRemaining);
            this.game3panel.Controls.Add(this.playerShipsRemaining);
            this.game3panel.Controls.Add(this.roundCounter);
            this.game3panel.Controls.Add(this.EndGame);
            this.game3panel.Controls.Add(this.rulesBtn);
            this.game3panel.Controls.Add(this.NewGame);
            this.game3panel.Location = new System.Drawing.Point(67, 22);
            this.game3panel.Margin = new System.Windows.Forms.Padding(4);
            this.game3panel.Name = "game3panel";
            this.game3panel.Size = new System.Drawing.Size(1837, 1020);
            this.game3panel.TabIndex = 0;
            // 
            // EndGame
            // 
            this.EndGame.Image = global::Battleship_Grid_Game.Properties.Resources.end_game2;
            this.EndGame.Location = new System.Drawing.Point(809, 886);
            this.EndGame.Name = "EndGame";
            this.EndGame.Size = new System.Drawing.Size(213, 88);
            this.EndGame.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.EndGame.TabIndex = 15;
            this.EndGame.TabStop = false;
            // 
            // rulesBtn
            // 
            this.rulesBtn.Image = global::Battleship_Grid_Game.Properties.Resources.rulesbtn;
            this.rulesBtn.Location = new System.Drawing.Point(809, 793);
            this.rulesBtn.Name = "rulesBtn";
            this.rulesBtn.Size = new System.Drawing.Size(213, 87);
            this.rulesBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.rulesBtn.TabIndex = 14;
            this.rulesBtn.TabStop = false;
            // 
            // NewGame
            // 
            this.NewGame.Image = global::Battleship_Grid_Game.Properties.Resources.new_game2;
            this.NewGame.Location = new System.Drawing.Point(809, 700);
            this.NewGame.Name = "NewGame";
            this.NewGame.Size = new System.Drawing.Size(213, 87);
            this.NewGame.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.NewGame.TabIndex = 13;
            this.NewGame.TabStop = false;
            // 
            // InstructionsLabel
            // 
            this.InstructionsLabel.AutoSize = true;
            this.InstructionsLabel.BackColor = System.Drawing.Color.AliceBlue;
            this.InstructionsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InstructionsLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.InstructionsLabel.Location = new System.Drawing.Point(816, 183);
            this.InstructionsLabel.Name = "InstructionsLabel";
            this.InstructionsLabel.Size = new System.Drawing.Size(218, 62);
            this.InstructionsLabel.TabIndex = 20;
            this.InstructionsLabel.Text = "Instructions for \r\nplayer\r\n";
            this.InstructionsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TimerLabel
            // 
            this.TimerLabel.AutoSize = true;
            this.TimerLabel.BackColor = System.Drawing.Color.AliceBlue;
            this.TimerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimerLabel.Location = new System.Drawing.Point(816, 265);
            this.TimerLabel.Name = "TimerLabel";
            this.TimerLabel.Size = new System.Drawing.Size(219, 62);
            this.TimerLabel.TabIndex = 19;
            this.TimerLabel.Text = "00 seconds \r\nto make a move";
            this.TimerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // computerShipsRemaining
            // 
            this.computerShipsRemaining.AutoSize = true;
            this.computerShipsRemaining.BackColor = System.Drawing.Color.Transparent;
            this.computerShipsRemaining.Location = new System.Drawing.Point(1620, 253);
            this.computerShipsRemaining.Name = "computerShipsRemaining";
            this.computerShipsRemaining.Size = new System.Drawing.Size(24, 25);
            this.computerShipsRemaining.TabIndex = 18;
            this.computerShipsRemaining.Text = "5";
            // 
            // playerShipsRemaining
            // 
            this.playerShipsRemaining.AutoSize = true;
            this.playerShipsRemaining.BackColor = System.Drawing.Color.Transparent;
            this.playerShipsRemaining.Location = new System.Drawing.Point(635, 244);
            this.playerShipsRemaining.Name = "playerShipsRemaining";
            this.playerShipsRemaining.Size = new System.Drawing.Size(24, 25);
            this.playerShipsRemaining.TabIndex = 17;
            this.playerShipsRemaining.Text = "5";
            // 
            // roundCounter
            // 
            this.roundCounter.AllowDrop = true;
            this.roundCounter.AutoSize = true;
            this.roundCounter.BackColor = System.Drawing.Color.Transparent;
            this.roundCounter.Location = new System.Drawing.Point(906, 567);
            this.roundCounter.Name = "roundCounter";
            this.roundCounter.Size = new System.Drawing.Size(24, 25);
            this.roundCounter.TabIndex = 16;
            this.roundCounter.Text = "0";
            // 
            // game3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Battleship_Grid_Game.Properties.Resources.Battleship_Game_Background;
            this.ClientSize = new System.Drawing.Size(1951, 1055);
            this.Controls.Add(this.game3panel);
            this.Name = "game3";
            this.Text = "game3";
            this.game3panel.ResumeLayout(false);
            this.game3panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EndGame)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rulesBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NewGame)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel game3panel;
        private System.Windows.Forms.PictureBox EndGame;
        private System.Windows.Forms.PictureBox rulesBtn;
        private System.Windows.Forms.PictureBox NewGame;
        private System.Windows.Forms.Label InstructionsLabel;
        private System.Windows.Forms.Label TimerLabel;
        private System.Windows.Forms.Label computerShipsRemaining;
        private System.Windows.Forms.Label playerShipsRemaining;
        private System.Windows.Forms.Label roundCounter;
    }
}