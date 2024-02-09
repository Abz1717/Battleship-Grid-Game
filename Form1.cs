
// Group 14 Abz Mohamed, Tanush, Hannah




using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Battleship_Grid_Game
{
    public partial class Form1 : Form
    {

        private System.Media.SoundPlayer backgroundPlayer;

        public Form1()
        {
           
            InitializeComponent();
            
            PlaySound("the_mole_hans_zimmer.wav", isBackgroundMusic: true);


        }

         public static WMPLib.WindowsMediaPlayer wplayer = new WMPLib.WindowsMediaPlayer();

        private void PlaySound(string soundFileName, bool isBackgroundMusic)
        {
            string executablePath = AppDomain.CurrentDomain.BaseDirectory;
            string soundFilePath = Path.Combine(executablePath, "Resources", soundFileName);

            try
            {

                if (isBackgroundMusic)
                {

                    // Background music is unable to work with a relative path enough though soundpath location was correct. 
                    wplayer.URL = soundFilePath;
                    wplayer.controls.play();
                    Console.WriteLine("Sound File Path: " + soundFilePath);

                }
                else
                {

                    using (System.Media.SoundPlayer sound = new System.Media.SoundPlayer(soundFilePath))
                    {
                        sound.Play();
                        Console.WriteLine("Sound File Path: " + soundFilePath);

                    }


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


        private void btn_start_MouseHover(object sender, EventArgs e)
        {
            btn_start.Image = Properties.Resources.startbtn_hover;
        }
        private void btn_options_MouseHover(object sender, EventArgs e)
        {
            btn_options.Image = Properties.Resources.optionsbtn_hover;
        }

        private void btn_rules_MouseHover(object sender, EventArgs e)
        {
            btn_rules.Image = Properties.Resources.rulesbtn_hover;
        }

        private void btn_exit_MouseHover(object sender, EventArgs e)
        {
            btn_exit.Image= Properties.Resources.exitbtn_hover;
        }

        private void btn_start_MouseLeave(object sender, EventArgs e)
        {
            btn_start.Image = Properties.Resources.starttbn;
        }

        private void btn_options_MouseLeave(object sender, EventArgs e)
        {
            btn_options.Image = Properties.Resources.optionsbtn;
        }

        private void btn_rules_MouseLeave(object sender, EventArgs e)
        {
            btn_rules.Image= Properties.Resources.rulesbtn;
        }

        private void btn_exit_MouseLeave(object sender, EventArgs e)
        {
            btn_exit.Image = Properties.Resources.exitbtn;
        }

        private void btn_start_Click(object sender, EventArgs e)
        {
            PlaySound("button_press.wav", isBackgroundMusic: false);
            levels_page start = new levels_page();
            start.ShowDialog();
            this.Close();

        }

        private void btn_options_Click(object sender, EventArgs e)
        {
            PlaySound("button_press.wav", isBackgroundMusic: false);
            options_page options = new options_page();
            options.ShowDialog();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            PlaySound("button_press.wav", isBackgroundMusic: false);
            Application.Exit();
        }

        private void btn_rules_Click(object sender, EventArgs e)
        {
            PlaySound("button_press.wav", isBackgroundMusic: false);
            rules_page rules = new rules_page();
            rules.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point((Screen.PrimaryScreen.WorkingArea.Width - this.Width) / 2,
                                      (Screen.PrimaryScreen.WorkingArea.Height - this.Height) / 2);


        }

        private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {

        }
    }
}
