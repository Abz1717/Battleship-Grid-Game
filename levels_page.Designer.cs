namespace Battleship_Grid_Game
{
    partial class levels_page
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(levels_page));
            this.panel1 = new System.Windows.Forms.Panel();
            this.HardBtn = new System.Windows.Forms.PictureBox();
            this.MediumBtn = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.logo = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HardBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MediumBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Navy;
            this.panel1.BackgroundImage = global::Battleship_Grid_Game.Properties.Resources.Copy_of_Options;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.HardBtn);
            this.panel1.Controls.Add(this.MediumBtn);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(457, 274);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(484, 708);
            this.panel1.TabIndex = 0;
            // 
            // HardBtn
            // 
            this.HardBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.HardBtn.Image = global::Battleship_Grid_Game.Properties.Resources.hard_Button;
            this.HardBtn.Location = new System.Drawing.Point(108, 506);
            this.HardBtn.Name = "HardBtn";
            this.HardBtn.Size = new System.Drawing.Size(265, 107);
            this.HardBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.HardBtn.TabIndex = 2;
            this.HardBtn.TabStop = false;
            this.HardBtn.Click += new System.EventHandler(this.HardBtn_Click);
            // 
            // MediumBtn
            // 
            this.MediumBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.MediumBtn.Image = global::Battleship_Grid_Game.Properties.Resources.medium_Button;
            this.MediumBtn.Location = new System.Drawing.Point(108, 393);
            this.MediumBtn.Name = "MediumBtn";
            this.MediumBtn.Size = new System.Drawing.Size(265, 107);
            this.MediumBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.MediumBtn.TabIndex = 1;
            this.MediumBtn.TabStop = false;
            this.MediumBtn.Click += new System.EventHandler(this.MediumBtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Image = global::Battleship_Grid_Game.Properties.Resources.easy_Button__1_;
            this.pictureBox1.Location = new System.Drawing.Point(108, 280);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(265, 107);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
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
            this.logo.TabIndex = 3;
            // 
            // levels_page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = global::Battleship_Grid_Game.Properties.Resources.Battleship_Game_Background;
            this.ClientSize = new System.Drawing.Size(1374, 1029);
            this.Controls.Add(this.logo);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "levels_page";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "levels_page";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.HardBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MediumBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel logo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox HardBtn;
        private System.Windows.Forms.PictureBox MediumBtn;
    }
}