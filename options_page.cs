

// Group 14 Abz Mohamed, Tanush, Hannah



using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Battleship_Grid_Game
{


    
    public partial class options_page : Form
    {
        public options_page()
        {
            InitializeComponent();
        }

        private void PlaySound(string soundFileName)
        {
            string executablePath = AppDomain.CurrentDomain.BaseDirectory;
            string soundFilePath = Path.Combine(executablePath, "Resources", soundFileName);

            try
            {
                using (System.Media.SoundPlayer sound = new System.Media.SoundPlayer(soundFilePath))
                {
                    sound.Play();
                    Console.WriteLine("Sound File Path: " + soundFilePath);
                }
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine("Error: File not found - " + ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: Playing sound - " + ex.Message);
            }
        }

        private void options_page_Load(object sender, EventArgs e)
        {
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point((Screen.PrimaryScreen.WorkingArea.Width - this.Width) / 2,
                                      (Screen.PrimaryScreen.WorkingArea.Height - this.Height) / 2);

        }

        private void MenuBtn_Click(object sender, EventArgs e)
        {
            PlaySound("button_press.wav");


            Form1 start = new Form1();
            start.ShowDialog();
            this.Close();
        }
    }
}
