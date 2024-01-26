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
            this.SuspendLayout();
            // 
            // rules_menu
            // 
            this.rules_menu.BackgroundImage = global::Battleship_Grid_Game.Properties.Resources.rulesMenu;
            this.rules_menu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.rules_menu.Location = new System.Drawing.Point(193, 207);
            this.rules_menu.Name = "rules_menu";
            this.rules_menu.Size = new System.Drawing.Size(394, 564);
            this.rules_menu.TabIndex = 0;
            // 
            // rules_page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Goldenrod;
            this.ClientSize = new System.Drawing.Size(820, 938);
            this.Controls.Add(this.rules_menu);
            this.Name = "rules_page";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "rules_page";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel rules_menu;
    }
}