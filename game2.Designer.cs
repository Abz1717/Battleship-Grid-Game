namespace Battleship_Grid_Game
{
    partial class game2
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
            this.components = new System.ComponentModel.Container();
            this.game2panel = new System.Windows.Forms.Panel();
            this.InstructionsLabel = new System.Windows.Forms.Label();
            this.TimerLabel = new System.Windows.Forms.Label();
            this.computerShipsRemaining = new System.Windows.Forms.Label();
            this.playerShipsRemaining = new System.Windows.Forms.Label();
            this.roundCounter = new System.Windows.Forms.Label();
            this.EndGame = new System.Windows.Forms.PictureBox();
            this.rulesBtn = new System.Windows.Forms.PictureBox();
            this.NewGame = new System.Windows.Forms.PictureBox();
            this.GridButtonTimer = new System.Windows.Forms.Timer(this.components);
            this.game2panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EndGame)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rulesBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NewGame)).BeginInit();
            this.SuspendLayout();
            // 
            // game2panel
            // 
            this.game2panel.BackColor = System.Drawing.Color.MidnightBlue;
            this.game2panel.BackgroundImage = global::Battleship_Grid_Game.Properties.Resources.Game_Medium_level;
            this.game2panel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.game2panel.Controls.Add(this.InstructionsLabel);
            this.game2panel.Controls.Add(this.TimerLabel);
            this.game2panel.Controls.Add(this.computerShipsRemaining);
            this.game2panel.Controls.Add(this.playerShipsRemaining);
            this.game2panel.Controls.Add(this.roundCounter);
            this.game2panel.Controls.Add(this.EndGame);
            this.game2panel.Controls.Add(this.rulesBtn);
            this.game2panel.Controls.Add(this.NewGame);
            this.game2panel.Location = new System.Drawing.Point(67, 22);
            this.game2panel.Margin = new System.Windows.Forms.Padding(4);
            this.game2panel.Name = "game2panel";
            this.game2panel.Size = new System.Drawing.Size(1837, 1020);
            this.game2panel.TabIndex = 0;
            this.game2panel.Paint += new System.Windows.Forms.PaintEventHandler(this.game2panel_Paint);
            // 
            // InstructionsLabel
            // 
            this.InstructionsLabel.AutoSize = true;
            this.InstructionsLabel.BackColor = System.Drawing.Color.AliceBlue;
            this.InstructionsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InstructionsLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.InstructionsLabel.Location = new System.Drawing.Point(806, 185);
            this.InstructionsLabel.Name = "InstructionsLabel";
            this.InstructionsLabel.Size = new System.Drawing.Size(218, 62);
            this.InstructionsLabel.TabIndex = 17;
            this.InstructionsLabel.Text = "Instructions for \r\nplayer\r\n";
            this.InstructionsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TimerLabel
            // 
            this.TimerLabel.AutoSize = true;
            this.TimerLabel.BackColor = System.Drawing.Color.AliceBlue;
            this.TimerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimerLabel.Location = new System.Drawing.Point(806, 267);
            this.TimerLabel.Name = "TimerLabel";
            this.TimerLabel.Size = new System.Drawing.Size(219, 62);
            this.TimerLabel.TabIndex = 16;
            this.TimerLabel.Text = "00 seconds \r\nto make a move";
            this.TimerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // computerShipsRemaining
            // 
            this.computerShipsRemaining.AutoSize = true;
            this.computerShipsRemaining.BackColor = System.Drawing.Color.Transparent;
            this.computerShipsRemaining.Location = new System.Drawing.Point(1623, 254);
            this.computerShipsRemaining.Name = "computerShipsRemaining";
            this.computerShipsRemaining.Size = new System.Drawing.Size(24, 25);
            this.computerShipsRemaining.TabIndex = 15;
            this.computerShipsRemaining.Text = "4";
            // 
            // playerShipsRemaining
            // 
            this.playerShipsRemaining.AutoSize = true;
            this.playerShipsRemaining.BackColor = System.Drawing.Color.Transparent;
            this.playerShipsRemaining.Location = new System.Drawing.Point(638, 245);
            this.playerShipsRemaining.Name = "playerShipsRemaining";
            this.playerShipsRemaining.Size = new System.Drawing.Size(24, 25);
            this.playerShipsRemaining.TabIndex = 14;
            this.playerShipsRemaining.Text = "4";
            // 
            // roundCounter
            // 
            this.roundCounter.AllowDrop = true;
            this.roundCounter.AutoSize = true;
            this.roundCounter.BackColor = System.Drawing.Color.Transparent;
            this.roundCounter.Location = new System.Drawing.Point(903, 565);
            this.roundCounter.Name = "roundCounter";
            this.roundCounter.Size = new System.Drawing.Size(24, 25);
            this.roundCounter.TabIndex = 13;
            this.roundCounter.Text = "0";
            // 
            // EndGame
            // 
            this.EndGame.Image = global::Battleship_Grid_Game.Properties.Resources.end_game2;
            this.EndGame.Location = new System.Drawing.Point(811, 886);
            this.EndGame.Name = "EndGame";
            this.EndGame.Size = new System.Drawing.Size(213, 88);
            this.EndGame.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.EndGame.TabIndex = 12;
            this.EndGame.TabStop = false;
            this.EndGame.Click += new System.EventHandler(this.EndGame_Click);
            // 
            // rulesBtn
            // 
            this.rulesBtn.Image = global::Battleship_Grid_Game.Properties.Resources.rulesbtn;
            this.rulesBtn.Location = new System.Drawing.Point(811, 793);
            this.rulesBtn.Name = "rulesBtn";
            this.rulesBtn.Size = new System.Drawing.Size(213, 87);
            this.rulesBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.rulesBtn.TabIndex = 11;
            this.rulesBtn.TabStop = false;
            // 
            // NewGame
            // 
            this.NewGame.Image = global::Battleship_Grid_Game.Properties.Resources.new_game2;
            this.NewGame.Location = new System.Drawing.Point(811, 700);
            this.NewGame.Name = "NewGame";
            this.NewGame.Size = new System.Drawing.Size(213, 87);
            this.NewGame.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.NewGame.TabIndex = 9;
            this.NewGame.TabStop = false;
            // 
            // GridButtonTimer
            // 
            this.GridButtonTimer.Enabled = true;
            this.GridButtonTimer.Interval = 1000;
            this.GridButtonTimer.Tick += new System.EventHandler(this.GridButtonTimer_Tick);
            // 
            // game2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackgroundImage = global::Battleship_Grid_Game.Properties.Resources.Battleship_Game_Background;
            this.ClientSize = new System.Drawing.Size(1951, 1055);
            this.Controls.Add(this.game2panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "game2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "game2";
            this.Load += new System.EventHandler(this.game2_Load);
            this.game2panel.ResumeLayout(false);
            this.game2panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EndGame)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rulesBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NewGame)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel game2panel;
        private System.Windows.Forms.PictureBox NewGame;
        private System.Windows.Forms.PictureBox rulesBtn;
        private System.Windows.Forms.PictureBox EndGame;
        private System.Windows.Forms.Label InstructionsLabel;
        private System.Windows.Forms.Label TimerLabel;
        private System.Windows.Forms.Label computerShipsRemaining;
        private System.Windows.Forms.Label playerShipsRemaining;
        private System.Windows.Forms.Label roundCounter;
        private System.Windows.Forms.Timer GridButtonTimer;
    }
}