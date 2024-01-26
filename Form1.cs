using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Battleship_Grid_Game
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
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
            menu.Hide();
            logo.Hide();
        }
    }
}
