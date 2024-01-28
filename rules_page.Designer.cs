namespace Battleship_Grid_Game
{
    partial class rules_page
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
            this.rules_menu = new System.Windows.Forms.Panel();
            this.logo = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // rules_menu
            // 
            this.rules_menu.BackgroundImage = global::Battleship_Grid_Game.Properties.Resources.rulesMenu;
            this.rules_menu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.rules_menu.Location = new System.Drawing.Point(457, 274);
            this.rules_menu.Name = "rules_menu";
            this.rules_menu.Size = new System.Drawing.Size(484, 708);
            this.rules_menu.TabIndex = 0;
            this.rules_menu.Paint += new System.Windows.Forms.PaintEventHandler(this.rules_menu_Paint);
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
            this.logo.TabIndex = 2;
            // 
            // rules_page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RoyalBlue;
            this.BackgroundImage = global::Battleship_Grid_Game.Properties.Resources.Battleship_Game_Background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1374, 1029);
            this.Controls.Add(this.logo);
            this.Controls.Add(this.rules_menu);
            this.DoubleBuffered = true;
            this.Name = "rules_page";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "rules_page";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel rules_menu;
        private System.Windows.Forms.Panel logo;
    }
}