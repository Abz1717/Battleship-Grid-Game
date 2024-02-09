

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
    public partial class levels_page : Form
    {
        public levels_page()
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


        private void pictureBox1_Click(object sender, EventArgs e)
        {
            PlaySound("button_press.wav");

            game start = new game();
            start.ShowDialog();
            this.Close();
        }

        private void MediumBtn_Click(object sender, EventArgs e)
        {
            PlaySound("button_press.wav");

            game2 start = new game2();
            start.ShowDialog();
            this.Close();
        }

        private void HardBtn_Click(object sender, EventArgs e)
        {
            PlaySound("button_press.wav");

            game3 start = new game3();
            start.ShowDialog();
            this.Close();
        }
    }
}
