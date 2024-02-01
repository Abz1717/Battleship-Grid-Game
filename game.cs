using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
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
        int computerShipsPlacedCount = 0;

        private bool isPlayerTurn = true;





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



                    if (isPlayerTurn)
                    {
                        if (shipPlacementPhase)
                        {
                            grid[x, y].Click += ShipPlacement_Click;
                        }
                        else
                        {
                            grid[x, y].Click += GridButton_Click;
                        }
                    }
                    else
                    {
                        grid[x, y].Click += ComputerMove;
                    }




                    Controls.Add(grid[x, y]);
                }
            }


        }



        
    private void UpdateEventHandlers(Button[,] grid, EventHandler newHandler)
        {
            for (int x = 0; x < 4; x++)
            {
                for (int y = 0; y < 4; y++)
                {
                    grid[x, y].Click -= ShipPlacement_Click; //Remove ship placement handler
                    grid[x, y].Click -= GridButton_Click;     //Remove grid button handler
                    grid[x, y].Click -= ComputerMove;         //Remove computer move handler

                    grid[x, y].Click += newHandler;           //Adding a new handler
                }
            }
        }


        //ship placement 
        private void ShipPlacement_Click(object sender, EventArgs e)
        {

            Console.WriteLine("ShipPlacement_Click method called."); // adding a logging statement


            if (shipsPlacedCount >= 3)
            {
                MessageBox.Show("You can only place 3 ships. Click the onto the enemy's grid to attack and start the game. ");
                shipPlacementPhase = false;

           

                return;
            }


            Button clickedButton = (Button)sender;
         
            int x = GetXCoordinate(clickedButton);
            int y = GetYCoordinate(clickedButton);


            if (playerBoard[x, y] == 0)
            {
                playerBoard[x, y] = 1;
                clickedButton.BackColor = Color.Green;

                shipsPlacedCount++;

                if (shipsPlacedCount == 3)
                {
                    MessageBox.Show("All ships Placed. Click the onto the enemy's grid to attack and start the game. ");
                    shipPlacementPhase = false;

                    UpdateEventHandlers(computerGrid, GridButton_Click);




                }
            } 
            else
            {
                MessageBox.Show("You can't place your ship here. Find an empty cell!");

            }

        }


       

        private void PlaceComputerShips()
        {
            Random random = new Random();



            while (computerShipsPlacedCount < 3)
            {
                int x = random.Next(4);
                int y = random.Next(4);

                if (computerBoard[x, y] == 0)
                {
                    computerBoard[x, y] = 1;
                    computerShipsPlacedCount++;

                    computerGrid[x, y].BackColor = Color.Green;

                }
            }
        }

        private int GetXCoordinate(Button button)
        {
            for (int x = 0; x < 4; x++)
            {
                for (int y = 0; y < 4; y++)
                {
                    if (playerGrid[x, y] == button || computerGrid[x, y] == button)
                    {
                        return x;
                    }
                }
            }
            Console.WriteLine("GetXCoordinate: Button not found");

            return -1; 
        }


        private int GetYCoordinate(Button button)
        {
            for (int x = 0; x < 4; x++)
            {
                for (int y = 0; y < 4; y++)
                {
                    if (playerGrid[x, y] == button || computerGrid[x, y] == button)
                    {
                        return y;
                    }
                }
            }
            Console.WriteLine("GetYCoordinate: Button not found");

            return -1; 
        }


     

        //players move

        private void GridButton_Click(object sender, EventArgs e)
        {

            Console.WriteLine("GridButton_Click method called."); // adding a logging statement

            if (!isPlayerTurn)
                return;

            Button clickedButton = (Button)sender;
            int x = GetXCoordinate(clickedButton);
            int y = GetYCoordinate(clickedButton);

            Console.WriteLine($"Clicked on computerBoard[{x}, {y}]"); // debuging output


            if (x >= 0 && x < 4 && y >= 0 && y < 4)
            {
                if (computerBoard[x, y] == 1)
                {
                    clickedButton.BackColor = Color.Red;
                    MessageBox.Show("BOOM! You sunk a battleship");
                    isPlayerTurn = false;
                    ComputerMove(null, null);



                }
                else
                {
                    clickedButton.BackColor = Color.Gray;
                    MessageBox.Show("MISS! The computer's turn");
                    isPlayerTurn = false;
                    ComputerMove(null, null);

                }
            }
           
        }


        // computer move
        private void ComputerMove(object sender, EventArgs e)
        {



            if (isPlayerTurn)
            {
                return;
            }



            Random random = new Random();
            int x = random.Next(4);
            int y = random.Next(4);

            if (playerBoard[x, y] == 1) 
            {
                playerGrid[x, y].BackColor = Color.Red;
                MessageBox.Show("BOOM! The Computer sunk one of your battleships");

            }
            else
            {
                playerGrid[x, y].BackColor = Color.Yellow;
                MessageBox.Show("MISS! Your turn");
                isPlayerTurn = true;

            }
        }

        


        private void game_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Welcome to battleships. Place you ships onto your grid.");
            PlaceComputerShips();
        }

        private void game_panel_Paint(object sender, PaintEventArgs e)
        {
            game_panel.SendToBack();

        }

        private void EndGame_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Restart_Click(object sender, EventArgs e)
        {

            RestartGame();


        }

        private void RestartGame()
        {

            game gameForm = new game();
            gameForm.Show();

            this.Close();




        }
    }
}
