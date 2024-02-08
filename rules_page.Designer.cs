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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(rules_page));
            this.logo = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.logo.SuspendLayout();
            this.SuspendLayout();
            // 
            // logo
            // 
            this.logo.BackColor = System.Drawing.Color.Transparent;
            this.logo.BackgroundImage = global::Battleship_Grid_Game.Properties.Resources.Copy_of_Copy_of_Copy_of_Copy_of_Copy_of_Copy_of_Lessons_First_slide___4_;
            this.logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.logo.Controls.Add(this.panel1);
            this.logo.Location = new System.Drawing.Point(445, 1);
            this.logo.Margin = new System.Windows.Forms.Padding(4);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(506, 265);
            this.logo.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 100);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.AutoSize = true;
            this.panel2.BackgroundImage = global::Battleship_Grid_Game.Properties.Resources.Rules_and_information;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Location = new System.Drawing.Point(67, 22);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1837, 1020);
            this.panel2.TabIndex = 3;
            // 
            // rules_page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.RoyalBlue;
            this.BackgroundImage = global::Battleship_Grid_Game.Properties.Resources.Battleship_Game_Background;
            this.ClientSize = new System.Drawing.Size(1951, 1055);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.logo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "rules_page";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "rules_page";
            this.Load += new System.EventHandler(this.rules_page_Load);
            this.logo.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel logo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}