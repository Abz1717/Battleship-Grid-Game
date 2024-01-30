using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.AxHost;

namespace Battleship_Grid_Game
{
    public partial class game : Form
    {

        Button[,] playerGrid = new Button[4, 4];
        Button[,] computerGrid = new Button[4, 4];


        bool shipPlacementPhase = true; 

        public game()
        {


            InitializeComponent();
            InitializeGrid(playerGrid, 121, 223);
            InitializeGrid(computerGrid, 640, 223);



        }

        private void InitializeGrid(Button[,] grid, int startX, int startY)
        {
            int buttonWidth = 70;
            int buttonHeight = 70;
            int horizontalSpacing = 2;
            int verticalSpacing = 2;


            for (int x = 0; x < 4; x++)
            {
                for (int y = 0; y < 4; y++)
                {
                    grid[x, y] = new Button();
                    grid[x, y].SetBounds(startX + (buttonWidth + horizontalSpacing) * x, startY + (buttonHeight + verticalSpacing) * y, buttonWidth, buttonHeight);
                    grid[x, y].BackColor = Color.PowderBlue;

                    if (shipPlacementPhase)
                        grid[x, y].Click += ShipPlacement_Click; // Attach a different click event handler during ship placement phase
                    else
                        grid[x, y].Click += GridButton_Click;

                    Controls.Add(grid[x, y]);
                }
            }

        }

        private void ShipPlacement_Click(object sender, EventArgs e)
        {

           
        }

        private void GridButton_Click(object sender, EventArgs e)
        {
         

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
