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
            this.game_panel = new System.Windows.Forms.Panel();
            this.roundCounter = new System.Windows.Forms.Label();
            this.EndGame = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.Restart = new System.Windows.Forms.PictureBox();
            this.playerShipsRemaining = new System.Windows.Forms.Label();
            this.computerShipsRemaining = new System.Windows.Forms.Label();
            this.game_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EndGame)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Restart)).BeginInit();
            this.SuspendLayout();
            // 
            // game_panel
            // 
            this.game_panel.BackColor = System.Drawing.Color.Navy;
            this.game_panel.BackgroundImage = global::Battleship_Grid_Game.Properties.Resources.menu__8_;
            this.game_panel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.game_panel.Controls.Add(this.computerShipsRemaining);
            this.game_panel.Controls.Add(this.playerShipsRemaining);
            this.game_panel.Controls.Add(this.roundCounter);
            this.game_panel.Controls.Add(this.EndGame);
            this.game_panel.Controls.Add(this.pictureBox3);
            this.game_panel.Controls.Add(this.Restart);
            this.game_panel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.game_panel.Location = new System.Drawing.Point(59, 13);
            this.game_panel.Margin = new System.Windows.Forms.Padding(4);
            this.game_panel.Name = "game_panel";
            this.game_panel.Size = new System.Drawing.Size(1934, 1063);
            this.game_panel.TabIndex = 0;
            this.game_panel.Paint += new System.Windows.Forms.PaintEventHandler(this.game_panel_Paint);
            // 
            // roundCounter
            // 
            this.roundCounter.AllowDrop = true;
            this.roundCounter.AutoSize = true;
            this.roundCounter.BackColor = System.Drawing.Color.Transparent;
            this.roundCounter.Location = new System.Drawing.Point(936, 564);
            this.roundCounter.Name = "roundCounter";
            this.roundCounter.Size = new System.Drawing.Size(69, 73);
            this.roundCounter.TabIndex = 4;
            this.roundCounter.Text = "0";
            // 
            // EndGame
            // 
            this.EndGame.Image = global::Battleship_Grid_Game.Properties.Resources.end_game1;
            this.EndGame.Location = new System.Drawing.Point(861, 919);
            this.EndGame.Name = "EndGame";
            this.EndGame.Size = new System.Drawing.Size(214, 82);
            this.EndGame.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.EndGame.TabIndex = 3;
            this.EndGame.TabStop = false;
            this.EndGame.Click += new System.EventHandler(this.EndGame_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Battleship_Grid_Game.Properties.Resources.new_game;
            this.pictureBox3.Location = new System.Drawing.Point(863, 743);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(214, 82);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            // 
            // Restart
            // 
            this.Restart.Image = global::Battleship_Grid_Game.Properties.Resources.hard_Button__1_;
            this.Restart.Location = new System.Drawing.Point(863, 831);
            this.Restart.Name = "Restart";
            this.Restart.Size = new System.Drawing.Size(214, 82);
            this.Restart.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Restart.TabIndex = 1;
            this.Restart.TabStop = false;
            this.Restart.Click += new System.EventHandler(this.Restart_Click);
            // 
            // playerShipsRemaining
            // 
            this.playerShipsRemaining.AutoSize = true;
            this.playerShipsRemaining.Location = new System.Drawing.Point(651, 238);
            this.playerShipsRemaining.Name = "playerShipsRemaining";
            this.playerShipsRemaining.Size = new System.Drawing.Size(69, 73);
            this.playerShipsRemaining.TabIndex = 5;
            this.playerShipsRemaining.Text = "3";
            // 
            // computerShipsRemaining
            // 
            this.computerShipsRemaining.AutoSize = true;
            this.computerShipsRemaining.Location = new System.Drawing.Point(1690, 247);
            this.computerShipsRemaining.Name = "computerShipsRemaining";
            this.computerShipsRemaining.Size = new System.Drawing.Size(69, 73);
            this.computerShipsRemaining.TabIndex = 6;
            this.computerShipsRemaining.Text = "3";
            // 
            // game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackColor = System.Drawing.Color.RoyalBlue;
            this.BackgroundImage = global::Battleship_Grid_Game.Properties.Resources.Battleship_Game_Background;
            this.ClientSize = new System.Drawing.Size(2424, 1098);
            this.Controls.Add(this.game_panel);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "game";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "game";
            this.Load += new System.EventHandler(this.game_Load);
            this.game_panel.ResumeLayout(false);
            this.game_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EndGame)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Restart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel game_panel;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox Restart;
        private System.Windows.Forms.PictureBox EndGame;
        private System.Windows.Forms.Label roundCounter;
        private System.Windows.Forms.Label computerShipsRemaining;
        private System.Windows.Forms.Label playerShipsRemaining;
    }
}