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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(game));
            this.game_panel = new System.Windows.Forms.Panel();
            this.HintButton = new System.Windows.Forms.Button();
            this.rulesBtn = new System.Windows.Forms.PictureBox();
            this.InstructionsLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.TimerLabel = new System.Windows.Forms.Label();
            this.computerShipsRemaining = new System.Windows.Forms.Label();
            this.playerShipsRemaining = new System.Windows.Forms.Label();
            this.roundCounter = new System.Windows.Forms.Label();
            this.EndGame = new System.Windows.Forms.PictureBox();
            this.GridButtonTimer = new System.Windows.Forms.Timer(this.components);
            this.game_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rulesBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EndGame)).BeginInit();
            this.SuspendLayout();
            // 
            // game_panel
            // 
            this.game_panel.BackColor = System.Drawing.Color.Navy;
            this.game_panel.BackgroundImage = global::Battleship_Grid_Game.Properties.Resources.MenuEasy;
            this.game_panel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.game_panel.Controls.Add(this.HintButton);
            this.game_panel.Controls.Add(this.rulesBtn);
            this.game_panel.Controls.Add(this.InstructionsLabel);
            this.game_panel.Controls.Add(this.pictureBox1);
            this.game_panel.Controls.Add(this.TimerLabel);
            this.game_panel.Controls.Add(this.computerShipsRemaining);
            this.game_panel.Controls.Add(this.playerShipsRemaining);
            this.game_panel.Controls.Add(this.roundCounter);
            this.game_panel.Controls.Add(this.EndGame);
            this.game_panel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.game_panel.Location = new System.Drawing.Point(34, 11);
            this.game_panel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.game_panel.Name = "game_panel";
            this.game_panel.Size = new System.Drawing.Size(920, 527);
            this.game_panel.TabIndex = 0;
            this.game_panel.Paint += new System.Windows.Forms.PaintEventHandler(this.game_panel_Paint);
            // 
            // HintButton
            // 
            this.HintButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HintButton.Location = new System.Drawing.Point(671, 490);
            this.HintButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.HintButton.Name = "HintButton";
            this.HintButton.Size = new System.Drawing.Size(92, 20);
            this.HintButton.TabIndex = 11;
            this.HintButton.Text = "1 Hint Left";
            this.HintButton.UseVisualStyleBackColor = true;
            this.HintButton.Click += new System.EventHandler(this.HintButton_Click);
            // 
            // rulesBtn
            // 
            this.rulesBtn.Image = global::Battleship_Grid_Game.Properties.Resources.rulesbtn;
            this.rulesBtn.Location = new System.Drawing.Point(408, 410);
            this.rulesBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rulesBtn.Name = "rulesBtn";
            this.rulesBtn.Size = new System.Drawing.Size(106, 45);
            this.rulesBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.rulesBtn.TabIndex = 10;
            this.rulesBtn.TabStop = false;
            this.rulesBtn.Click += new System.EventHandler(this.rulesBtn_Click);
            // 
            // InstructionsLabel
            // 
            this.InstructionsLabel.AutoSize = true;
            this.InstructionsLabel.BackColor = System.Drawing.Color.AliceBlue;
            this.InstructionsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InstructionsLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.InstructionsLabel.Location = new System.Drawing.Point(404, 97);
            this.InstructionsLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.InstructionsLabel.Name = "InstructionsLabel";
            this.InstructionsLabel.Size = new System.Drawing.Size(122, 34);
            this.InstructionsLabel.TabIndex = 9;
            this.InstructionsLabel.Text = "Instructions for \r\nplayer\r\n";
            this.InstructionsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Battleship_Grid_Game.Properties.Resources.new_game2;
            this.pictureBox1.Location = new System.Drawing.Point(408, 362);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(106, 45);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // TimerLabel
            // 
            this.TimerLabel.AutoSize = true;
            this.TimerLabel.BackColor = System.Drawing.Color.AliceBlue;
            this.TimerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimerLabel.Location = new System.Drawing.Point(404, 140);
            this.TimerLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.TimerLabel.Name = "TimerLabel";
            this.TimerLabel.Size = new System.Drawing.Size(122, 34);
            this.TimerLabel.TabIndex = 7;
            this.TimerLabel.Text = "00 seconds \r\nto make a move";
            this.TimerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // computerShipsRemaining
            // 
            this.computerShipsRemaining.AutoSize = true;
            this.computerShipsRemaining.BackColor = System.Drawing.Color.Transparent;
            this.computerShipsRemaining.Location = new System.Drawing.Point(800, 119);
            this.computerShipsRemaining.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.computerShipsRemaining.Name = "computerShipsRemaining";
            this.computerShipsRemaining.Size = new System.Drawing.Size(36, 37);
            this.computerShipsRemaining.TabIndex = 6;
            this.computerShipsRemaining.Text = "3";
            // 
            // playerShipsRemaining
            // 
            this.playerShipsRemaining.AutoSize = true;
            this.playerShipsRemaining.BackColor = System.Drawing.Color.Transparent;
            this.playerShipsRemaining.Location = new System.Drawing.Point(307, 113);
            this.playerShipsRemaining.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.playerShipsRemaining.Name = "playerShipsRemaining";
            this.playerShipsRemaining.Size = new System.Drawing.Size(36, 37);
            this.playerShipsRemaining.TabIndex = 5;
            this.playerShipsRemaining.Text = "3";
            // 
            // roundCounter
            // 
            this.roundCounter.AllowDrop = true;
            this.roundCounter.AutoSize = true;
            this.roundCounter.BackColor = System.Drawing.Color.Transparent;
            this.roundCounter.Location = new System.Drawing.Point(442, 281);
            this.roundCounter.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.roundCounter.Name = "roundCounter";
            this.roundCounter.Size = new System.Drawing.Size(36, 37);
            this.roundCounter.TabIndex = 4;
            this.roundCounter.Text = "0";
            // 
            // EndGame
            // 
            this.EndGame.Image = global::Battleship_Grid_Game.Properties.Resources.end_game2;
            this.EndGame.Location = new System.Drawing.Point(408, 458);
            this.EndGame.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.EndGame.Name = "EndGame";
            this.EndGame.Size = new System.Drawing.Size(106, 46);
            this.EndGame.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.EndGame.TabIndex = 3;
            this.EndGame.TabStop = false;
            this.EndGame.Click += new System.EventHandler(this.EndGame_Click);
            // 
            // GridButtonTimer
            // 
            this.GridButtonTimer.Enabled = true;
            this.GridButtonTimer.Interval = 1000;
            this.GridButtonTimer.Tick += new System.EventHandler(this.GridButtonTimer_Tick);
            // 
            // game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackColor = System.Drawing.Color.RoyalBlue;
            this.BackgroundImage = global::Battleship_Grid_Game.Properties.Resources.Battleship_Game_Background;
            this.ClientSize = new System.Drawing.Size(976, 549);
            this.Controls.Add(this.game_panel);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(996, 604);
            this.MinimizeBox = false;
            this.Name = "game";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "game";
            this.Load += new System.EventHandler(this.game_Load);
            this.game_panel.ResumeLayout(false);
            this.game_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rulesBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EndGame)).EndInit();
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
        private System.Windows.Forms.Label InstructionsLabel;
        private System.Windows.Forms.PictureBox rulesBtn;
        private System.Windows.Forms.Button HintButton;
    }
}