namespace Battleship_Grid_Game
{
    partial class Form1
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
            this.logo = new System.Windows.Forms.Panel();
            this.menu = new System.Windows.Forms.Panel();
            this.btn_start = new System.Windows.Forms.PictureBox();
            this.btn_options = new System.Windows.Forms.PictureBox();
            this.btn_rules = new System.Windows.Forms.PictureBox();
            this.btn_exit = new System.Windows.Forms.PictureBox();
            this.menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_start)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_options)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_rules)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_exit)).BeginInit();
            this.SuspendLayout();
            // 
            // logo
            // 
            this.logo.BackgroundImage = global::Battleship_Grid_Game.Properties.Resources.Copy_of_Copy_of_Copy_of_Copy_of_Copy_of_Copy_of_Lessons_First_slide___4_;
            this.logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.logo.Location = new System.Drawing.Point(193, -31);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(394, 224);
            this.logo.TabIndex = 1;
            // 
            // menu
            // 
            this.menu.BackgroundImage = global::Battleship_Grid_Game.Properties.Resources.Battlemenu;
            this.menu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.menu.Controls.Add(this.btn_start);
            this.menu.Controls.Add(this.btn_options);
            this.menu.Controls.Add(this.btn_rules);
            this.menu.Controls.Add(this.btn_exit);
            this.menu.Location = new System.Drawing.Point(193, 207);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(394, 564);
            this.menu.TabIndex = 0;
            // 
            // btn_start
            // 
            this.btn_start.Image = global::Battleship_Grid_Game.Properties.Resources.starttbn;
            this.btn_start.Location = new System.Drawing.Point(105, 110);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(184, 67);
            this.btn_start.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn_start.TabIndex = 3;
            this.btn_start.TabStop = false;
            this.btn_start.Click += new System.EventHandler(this.btn_start_Click);
            this.btn_start.MouseLeave += new System.EventHandler(this.btn_start_MouseLeave);
            this.btn_start.MouseHover += new System.EventHandler(this.btn_start_MouseHover);
            // 
            // btn_options
            // 
            this.btn_options.Image = global::Battleship_Grid_Game.Properties.Resources.optionsbtn;
            this.btn_options.Location = new System.Drawing.Point(105, 209);
            this.btn_options.Name = "btn_options";
            this.btn_options.Size = new System.Drawing.Size(184, 67);
            this.btn_options.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn_options.TabIndex = 2;
            this.btn_options.TabStop = false;
            this.btn_options.Click += new System.EventHandler(this.btn_options_Click);
            this.btn_options.MouseLeave += new System.EventHandler(this.btn_options_MouseLeave);
            this.btn_options.MouseHover += new System.EventHandler(this.btn_options_MouseHover);
            // 
            // btn_rules
            // 
            this.btn_rules.Image = global::Battleship_Grid_Game.Properties.Resources.rulesbtn;
            this.btn_rules.Location = new System.Drawing.Point(105, 306);
            this.btn_rules.Name = "btn_rules";
            this.btn_rules.Size = new System.Drawing.Size(184, 67);
            this.btn_rules.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn_rules.TabIndex = 1;
            this.btn_rules.TabStop = false;
            this.btn_rules.Click += new System.EventHandler(this.btn_rules_Click);
            this.btn_rules.MouseLeave += new System.EventHandler(this.btn_rules_MouseLeave);
            this.btn_rules.MouseHover += new System.EventHandler(this.btn_rules_MouseHover);
            // 
            // btn_exit
            // 
            this.btn_exit.Image = global::Battleship_Grid_Game.Properties.Resources.exitbtn;
            this.btn_exit.Location = new System.Drawing.Point(105, 408);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(184, 67);
            this.btn_exit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn_exit.TabIndex = 0;
            this.btn_exit.TabStop = false;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            this.btn_exit.MouseLeave += new System.EventHandler(this.btn_exit_MouseLeave);
            this.btn_exit.MouseHover += new System.EventHandler(this.btn_exit_MouseHover);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Goldenrod;
            this.ClientSize = new System.Drawing.Size(830, 984);
            this.Controls.Add(this.logo);
            this.Controls.Add(this.menu);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainMenu";
            this.menu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btn_start)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_options)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_rules)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_exit)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel menu;
        private System.Windows.Forms.PictureBox btn_exit;
        private System.Windows.Forms.PictureBox btn_rules;
        private System.Windows.Forms.PictureBox btn_options;
        private System.Windows.Forms.PictureBox btn_start;
        private System.Windows.Forms.Panel logo;
    }
}

