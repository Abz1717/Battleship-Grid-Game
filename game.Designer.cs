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
            this.SuspendLayout();
            // 
            // game_panel
            // 
            this.game_panel.BackColor = System.Drawing.Color.Navy;
            this.game_panel.BackgroundImage = global::Battleship_Grid_Game.Properties.Resources.menu__8_;
            this.game_panel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.game_panel.Location = new System.Drawing.Point(59, 13);
            this.game_panel.Margin = new System.Windows.Forms.Padding(4);
            this.game_panel.Name = "game_panel";
            this.game_panel.Size = new System.Drawing.Size(1934, 1063);
            this.game_panel.TabIndex = 0;
            this.game_panel.Paint += new System.Windows.Forms.PaintEventHandler(this.game_panel_Paint);
            // 
            // game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackColor = System.Drawing.Color.RoyalBlue;
            this.BackgroundImage = global::Battleship_Grid_Game.Properties.Resources.Battleship_Game_Background;
            this.ClientSize = new System.Drawing.Size(2056, 1098);
            this.Controls.Add(this.game_panel);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "game";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "game";
            this.Load += new System.EventHandler(this.game_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel game_panel;
    }
}