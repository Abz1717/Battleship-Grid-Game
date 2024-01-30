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

        int[,] playerBoard = new int[4, 4];
        int[,] computerBoard = new int[4, 4];



        bool shipPlacementPhase = true; 
        int shipsPlacedCount = 0;

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


        //ship placement 
        private void ShipPlacement_Click(object sender, EventArgs e)
        {


            if (shipsPlacedCount >= 3)
            {
                shipPlacementPhase = false;
                MessageBox.Show("All ships Placed. Click the onto the enemy's grid to attack and start the game. ");
                return;

            }

            Button clickedButton = (Button)sender;
            // finding the index of the clicked button in the playerGrid array, the divided by 4 converts linear index to coordinates of button in 2d array
            // '/' division helps determine row index
            // '%' modulus helps determine column index
            int x = GetXCoordinate(clickedButton);
            int y = GetYCoordinate(clickedButton);


            if (playerBoard[x, y] == 0)
            {
                playerBoard[x, y] = 1;
                clickedButton.BackColor = Color.Green;

                shipsPlacedCount++;

                if (shipsPlacedCount == 3)
                {
                    shipPlacementPhase = false;
                    MessageBox.Show("All ships Placed. Click the onto the enemy's grid to attack and start the game. ");

                }
            } 
            else
            {
                MessageBox.Show("You can't place your ship here. Find an empty cell!");
            }

        }


        private int GetXCoordinate(Button button)
        {
            for (int x = 0; x < 4; x++)
            {
                for (int y = 0; y < 4; y++)
                {
                    if (playerGrid[x, y] == button)
                    {
                        return x;
                    }
                }
            }
            return -1; 
        }


        private int GetYCoordinate(Button button)
        {
            for (int x = 0; x < 4; x++)
            {
                for (int y = 0; y < 4; y++)
                {
                    if (playerGrid[x, y] == button)
                    {
                        return y;
                    }
                }
            }
            return -1; 
        }


     

        //players move

        private void GridButton_Click(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;
            int x = GetXCoordinate(clickedButton);
            int y = GetYCoordinate(clickedButton);

            if (computerBoard[x, y] == 1)
            {
                clickedButton.BackColor = Color.Red;
                MessageBox.Show("BOOM! You sunk a battleship");
            }
            else
            {
                clickedButton.BackColor = Color.Gray;
                MessageBox.Show("MISS! The computer's turn");
                ComputerMove();
            }

        }


        // computer move
        private void ComputerMove()
        {

        }




        private void game_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Welcome to battleships. Place you ships onto your grid.");
        }

        private void game_panel_Paint(object sender, PaintEventArgs e)
        {
            game_panel.SendToBack();

        }
    }
}
