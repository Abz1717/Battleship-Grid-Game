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
    public partial class levels_page : Form
    {
        public levels_page()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            game start = new game();
            start.ShowDialog();
            this.Close();
        }
    }
}
