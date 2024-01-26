namespace Battleship_Grid_Game
{
    partial class options_page
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
            this.option_menu = new System.Windows.Forms.Panel();
            this.Sound = new System.Windows.Forms.Panel();
            this.sound_trackbar = new System.Windows.Forms.TrackBar();
            this.option_menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sound_trackbar)).BeginInit();
            this.SuspendLayout();
            // 
            // option_menu
            // 
            this.option_menu.BackgroundImage = global::Battleship_Grid_Game.Properties.Resources.optionsMenu;
            this.option_menu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.option_menu.Controls.Add(this.Sound);
            this.option_menu.Controls.Add(this.sound_trackbar);
            this.option_menu.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.option_menu.Location = new System.Drawing.Point(193, 207);
            this.option_menu.Name = "option_menu";
            this.option_menu.Size = new System.Drawing.Size(394, 564);
            this.option_menu.TabIndex = 0;
            this.option_menu.UseWaitCursor = true;
            // 
            // Sound
            // 
            this.Sound.BackgroundImage = global::Battleship_Grid_Game.Properties.Resources.Sound;
            this.Sound.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Sound.Location = new System.Drawing.Point(94, 107);
            this.Sound.Name = "Sound";
            this.Sound.Size = new System.Drawing.Size(181, 42);
            this.Sound.TabIndex = 1;
            this.Sound.UseWaitCursor = true;
            // 
            // sound_trackbar
            // 
            this.sound_trackbar.Location = new System.Drawing.Point(94, 155);
            this.sound_trackbar.Name = "sound_trackbar";
            this.sound_trackbar.Size = new System.Drawing.Size(195, 90);
            this.sound_trackbar.TabIndex = 0;
            this.sound_trackbar.UseWaitCursor = true;
            // 
            // options_page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Goldenrod;
            this.ClientSize = new System.Drawing.Size(820, 938);
            this.Controls.Add(this.option_menu);
            this.Name = "options_page";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "options_page";
            this.option_menu.ResumeLayout(false);
            this.option_menu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sound_trackbar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel option_menu;
        private System.Windows.Forms.TrackBar sound_trackbar;
        private System.Windows.Forms.Panel Sound;
    }
}