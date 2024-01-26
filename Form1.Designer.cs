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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_start = new System.Windows.Forms.PictureBox();
            this.btn_options = new System.Windows.Forms.PictureBox();
            this.btn_rules = new System.Windows.Forms.PictureBox();
            this.btn_exit = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_start)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_options)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_rules)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_exit)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::Battleship_Grid_Game.Properties.Resources.Copy_of_Copy_of_Copy_of_Copy_of_Copy_of_Copy_of_Lessons_First_slide___4_;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Location = new System.Drawing.Point(193, -31);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(394, 224);
            this.panel2.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::Battleship_Grid_Game.Properties.Resources.menu;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.btn_start);
            this.panel1.Controls.Add(this.btn_options);
            this.panel1.Controls.Add(this.btn_rules);
            this.panel1.Controls.Add(this.btn_exit);
            this.panel1.Location = new System.Drawing.Point(193, 207);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(394, 564);
            this.panel1.TabIndex = 0;
            // 
            // btn_start
            // 
            this.btn_start.Image = ((System.Drawing.Image)(resources.GetObject("btn_start.Image")));
            this.btn_start.Location = new System.Drawing.Point(105, 110);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(184, 67);
            this.btn_start.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn_start.TabIndex = 3;
            this.btn_start.TabStop = false;
            // 
            // btn_options
            // 
            this.btn_options.Image = ((System.Drawing.Image)(resources.GetObject("btn_options.Image")));
            this.btn_options.Location = new System.Drawing.Point(105, 209);
            this.btn_options.Name = "btn_options";
            this.btn_options.Size = new System.Drawing.Size(184, 67);
            this.btn_options.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn_options.TabIndex = 2;
            this.btn_options.TabStop = false;
            // 
            // btn_rules
            // 
            this.btn_rules.Image = ((System.Drawing.Image)(resources.GetObject("btn_rules.Image")));
            this.btn_rules.Location = new System.Drawing.Point(105, 306);
            this.btn_rules.Name = "btn_rules";
            this.btn_rules.Size = new System.Drawing.Size(184, 67);
            this.btn_rules.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn_rules.TabIndex = 1;
            this.btn_rules.TabStop = false;
            // 
            // btn_exit
            // 
            this.btn_exit.Image = ((System.Drawing.Image)(resources.GetObject("btn_exit.Image")));
            this.btn_exit.Location = new System.Drawing.Point(105, 408);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(184, 67);
            this.btn_exit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn_exit.TabIndex = 0;
            this.btn_exit.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Goldenrod;
            this.ClientSize = new System.Drawing.Size(820, 792);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainMenu";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btn_start)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_options)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_rules)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_exit)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox btn_exit;
        private System.Windows.Forms.PictureBox btn_rules;
        private System.Windows.Forms.PictureBox btn_options;
        private System.Windows.Forms.PictureBox btn_start;
        private System.Windows.Forms.Panel panel2;
    }
}

