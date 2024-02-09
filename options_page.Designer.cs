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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(options_page));
            this.option_menu = new System.Windows.Forms.Panel();
            this.Sound = new System.Windows.Forms.Panel();
            this.sound_trackbar = new System.Windows.Forms.TrackBar();
            this.logo = new System.Windows.Forms.Panel();
            this.MenuBtn = new System.Windows.Forms.PictureBox();
            this.option_menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sound_trackbar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MenuBtn)).BeginInit();
            this.SuspendLayout();
            // 
            // option_menu
            // 
            this.option_menu.BackColor = System.Drawing.Color.Navy;
            this.option_menu.BackgroundImage = global::Battleship_Grid_Game.Properties.Resources.optionsMenu;
            this.option_menu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.option_menu.Controls.Add(this.MenuBtn);
            this.option_menu.Controls.Add(this.Sound);
            this.option_menu.Controls.Add(this.sound_trackbar);
            this.option_menu.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.option_menu.Location = new System.Drawing.Point(457, 274);
            this.option_menu.Name = "option_menu";
            this.option_menu.Size = new System.Drawing.Size(484, 708);
            this.option_menu.TabIndex = 0;
            this.option_menu.UseWaitCursor = true;
            // 
            // Sound
            // 
            this.Sound.AutoSize = true;
            this.Sound.BackgroundImage = global::Battleship_Grid_Game.Properties.Resources.Sound;
            this.Sound.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Sound.Location = new System.Drawing.Point(125, 150);
            this.Sound.Name = "Sound";
            this.Sound.Size = new System.Drawing.Size(218, 57);
            this.Sound.TabIndex = 1;
            this.Sound.UseWaitCursor = true;
            // 
            // sound_trackbar
            // 
            this.sound_trackbar.Location = new System.Drawing.Point(135, 224);
            this.sound_trackbar.Name = "sound_trackbar";
            this.sound_trackbar.Size = new System.Drawing.Size(195, 90);
            this.sound_trackbar.TabIndex = 0;
            this.sound_trackbar.UseWaitCursor = true;
            // 
            // logo
            // 
            this.logo.BackColor = System.Drawing.Color.Transparent;
            this.logo.BackgroundImage = global::Battleship_Grid_Game.Properties.Resources.Copy_of_Copy_of_Copy_of_Copy_of_Copy_of_Copy_of_Lessons_First_slide___4_;
            this.logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.logo.Location = new System.Drawing.Point(445, 1);
            this.logo.Margin = new System.Windows.Forms.Padding(4);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(506, 265);
            this.logo.TabIndex = 4;
            // 
            // MenuBtn
            // 
            this.MenuBtn.BackColor = System.Drawing.Color.Transparent;
            this.MenuBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.MenuBtn.Image = global::Battleship_Grid_Game.Properties.Resources.Back_to_MainMenu;
            this.MenuBtn.Location = new System.Drawing.Point(138, 525);
            this.MenuBtn.Name = "MenuBtn";
            this.MenuBtn.Size = new System.Drawing.Size(205, 80);
            this.MenuBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.MenuBtn.TabIndex = 4;
            this.MenuBtn.TabStop = false;
            this.MenuBtn.Click += new System.EventHandler(this.MenuBtn_Click);
            // 
            // options_page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.RoyalBlue;
            this.BackgroundImage = global::Battleship_Grid_Game.Properties.Resources.Battleship_Game_Background;
            this.ClientSize = new System.Drawing.Size(1374, 1029);
            this.Controls.Add(this.logo);
            this.Controls.Add(this.option_menu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "options_page";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "options_page";
            this.Load += new System.EventHandler(this.options_page_Load);
            this.option_menu.ResumeLayout(false);
            this.option_menu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sound_trackbar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MenuBtn)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel option_menu;
        private System.Windows.Forms.TrackBar sound_trackbar;
        private System.Windows.Forms.Panel Sound;
        private System.Windows.Forms.Panel logo;
        private System.Windows.Forms.PictureBox MenuBtn;
    }
}