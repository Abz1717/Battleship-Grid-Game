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
    public partial class game : Form
    {

        Button[,] btnGrid1 = new Button[4, 4];
        Button[,] btnGrid2 = new Button[4, 4];

        public game()
        {


            InitializeComponent();

            // placing the grid in the right place

            int buttonWidth = 70;
            int buttonHeight = 70;
            int horizontalSpacing = 2;
            int verticalSpacing = 2;
            int gridX = 4;
            int gridY = 4;

            int grid1PostionX = 121;
            int grid1PostionY = 223;

            int grid2PostionX = 640;
            int grid2PositionY = 223;


            // first grid 
            for (int x = 0; x < gridX; x++)
            {

                for (int y = 0; y < gridY; y++)
                {
                    btnGrid1[x, y] = new Button();
                    btnGrid1[x, y].SetBounds(grid1PostionX + (buttonWidth + horizontalSpacing) * x, grid1PostionY + (buttonHeight + verticalSpacing) * y, buttonWidth, buttonHeight);
                    btnGrid1[x, y].BackColor = Color.PowderBlue;

                    Controls.Add(btnGrid1[x, y]);
                }
            }

            // second grid

            for (int x = 0; x < gridX; x++)
            {
                for (int y = 0; y < gridY; y++)
                {
                    btnGrid2[x, y] = new Button();
                    btnGrid2[x, y].SetBounds(grid2PostionX + (buttonWidth + horizontalSpacing) * x, grid2PositionY + (buttonHeight + verticalSpacing) * y, buttonWidth, buttonHeight);
                    btnGrid2[x, y].BackColor = Color.PowderBlue;
                    Controls.Add(btnGrid2[x, y]);
                }
            }



        }

        private void game_Load(object sender, EventArgs e)
        {

        }

        private void game_panel_Paint(object sender, PaintEventArgs e)
        {
            game_panel.SendToBack();

        }
    }
}
