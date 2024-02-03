namespace Battleship_Grid_Game
{
    partial class game
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
            this.game_panel = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.TimerLabel = new System.Windows.Forms.Label();
            this.computerShipsRemaining = new System.Windows.Forms.Label();
            this.playerShipsRemaining = new System.Windows.Forms.Label();
            this.roundCounter = new System.Windows.Forms.Label();
            this.EndGame = new System.Windows.Forms.PictureBox();
            this.Restart = new System.Windows.Forms.PictureBox();
            this.GridButtonTimer = new System.Windows.Forms.Timer(this.components);
            this.InstructionsLabel = new System.Windows.Forms.Label();
            this.game_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EndGame)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Restart)).BeginInit();
            this.SuspendLayout();
            // 
            // game_panel
            // 
            this.game_panel.BackColor = System.Drawing.Color.Navy;
            this.game_panel.BackgroundImage = global::Battleship_Grid_Game.Properties.Resources.MenuEasy;
            this.game_panel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.game_panel.Controls.Add(this.InstructionsLabel);
            this.game_panel.Controls.Add(this.pictureBox1);
            this.game_panel.Controls.Add(this.TimerLabel);
            this.game_panel.Controls.Add(this.computerShipsRemaining);
            this.game_panel.Controls.Add(this.playerShipsRemaining);
            this.game_panel.Controls.Add(this.roundCounter);
            this.game_panel.Controls.Add(this.EndGame);
            this.game_panel.Controls.Add(this.Restart);
            this.game_panel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.game_panel.Location = new System.Drawing.Point(67, 22);
            this.game_panel.Margin = new System.Windows.Forms.Padding(4);
            this.game_panel.Name = "game_panel";
            this.game_panel.Size = new System.Drawing.Size(1837, 1020);
            this.game_panel.TabIndex = 0;
            this.game_panel.Paint += new System.Windows.Forms.PaintEventHandler(this.game_panel_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Battleship_Grid_Game.Properties.Resources.new_game2;
            this.pictureBox1.Location = new System.Drawing.Point(815, 696);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(213, 87);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // TimerLabel
            // 
            this.TimerLabel.AutoSize = true;
            this.TimerLabel.BackColor = System.Drawing.Color.AliceBlue;
            this.TimerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimerLabel.Location = new System.Drawing.Point(809, 269);
            this.TimerLabel.Name = "TimerLabel";
            this.TimerLabel.Size = new System.Drawing.Size(219, 62);
            this.TimerLabel.TabIndex = 7;
            this.TimerLabel.Text = "00 seconds \r\nto make a move";
            this.TimerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // computerShipsRemaining
            // 
            this.computerShipsRemaining.AutoSize = true;
            this.computerShipsRemaining.BackColor = System.Drawing.Color.Transparent;
            this.computerShipsRemaining.Location = new System.Drawing.Point(1600, 228);
            this.computerShipsRemaining.Name = "computerShipsRemaining";
            this.computerShipsRemaining.Size = new System.Drawing.Size(69, 73);
            this.computerShipsRemaining.TabIndex = 6;
            this.computerShipsRemaining.Text = "3";
            // 
            // playerShipsRemaining
            // 
            this.playerShipsRemaining.AutoSize = true;
            this.playerShipsRemaining.BackColor = System.Drawing.Color.Transparent;
            this.playerShipsRemaining.Location = new System.Drawing.Point(614, 218);
            this.playerShipsRemaining.Name = "playerShipsRemaining";
            this.playerShipsRemaining.Size = new System.Drawing.Size(69, 73);
            this.playerShipsRemaining.TabIndex = 5;
            this.playerShipsRemaining.Text = "3";
            // 
            // roundCounter
            // 
            this.roundCounter.AllowDrop = true;
            this.roundCounter.AutoSize = true;
            this.roundCounter.BackColor = System.Drawing.Color.Transparent;
            this.roundCounter.Location = new System.Drawing.Point(885, 540);
            this.roundCounter.Name = "roundCounter";
            this.roundCounter.Size = new System.Drawing.Size(69, 73);
            this.roundCounter.TabIndex = 4;
            this.roundCounter.Text = "0";
            // 
            // EndGame
            // 
            this.EndGame.Image = global::Battleship_Grid_Game.Properties.Resources.end_game2;
            this.EndGame.Location = new System.Drawing.Point(815, 881);
            this.EndGame.Name = "EndGame";
            this.EndGame.Size = new System.Drawing.Size(213, 88);
            this.EndGame.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.EndGame.TabIndex = 3;
            this.EndGame.TabStop = false;
            this.EndGame.Click += new System.EventHandler(this.EndGame_Click);
            // 
            // Restart
            // 
            this.Restart.Image = global::Battleship_Grid_Game.Properties.Resources.restart_game2;
            this.Restart.Location = new System.Drawing.Point(814, 785);
            this.Restart.Name = "Restart";
            this.Restart.Size = new System.Drawing.Size(214, 90);
            this.Restart.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Restart.TabIndex = 1;
            this.Restart.TabStop = false;
            this.Restart.Click += new System.EventHandler(this.Restart_Click);
            // 
            // GridButtonTimer
            // 
            this.GridButtonTimer.Enabled = true;
            this.GridButtonTimer.Interval = 1000;
            this.GridButtonTimer.Tick += new System.EventHandler(this.GridButtonTimer_Tick);
            // 
            // InstructionsLabel
            // 
            this.InstructionsLabel.AutoSize = true;
            this.InstructionsLabel.BackColor = System.Drawing.Color.AliceBlue;
            this.InstructionsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InstructionsLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.InstructionsLabel.Location = new System.Drawing.Point(770, 190);
            this.InstructionsLabel.Name = "InstructionsLabel";
            this.InstructionsLabel.Size = new System.Drawing.Size(298, 31);
            this.InstructionsLabel.TabIndex = 9;
            this.InstructionsLabel.Text = "Instructions for player\r\n";
            this.InstructionsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackColor = System.Drawing.Color.RoyalBlue;
            this.BackgroundImage = global::Battleship_Grid_Game.Properties.Resources.Battleship_Game_Background;
            this.ClientSize = new System.Drawing.Size(1951, 1055);
            this.Controls.Add(this.game_panel);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1977, 1126);
            this.MinimizeBox = false;
            this.Name = "game";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "game";
            this.Load += new System.EventHandler(this.game_Load);
            this.game_panel.ResumeLayout(false);
            this.game_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EndGame)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Restart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel game_panel;
        private System.Windows.Forms.PictureBox EndGame;
        private System.Windows.Forms.Label roundCounter;
        private System.Windows.Forms.Label computerShipsRemaining;
        private System.Windows.Forms.Label playerShipsRemaining;
        private System.Windows.Forms.Timer GridButtonTimer;
        private System.Windows.Forms.Label TimerLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox Restart;
        private System.Windows.Forms.Label InstructionsLabel;
    }
}