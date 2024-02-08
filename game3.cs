using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace Battleship_Grid_Game
{
    public partial class game3 : Form
    {

        Button[,] playerGrid = new Button[8, 8];
        Button[,] computerGrid = new Button[8, 8];

        int[,] playerBoard = new int[8, 8];
        int[,] computerBoard = new int[8, 8];



        bool shipPlacementPhase = true;
        int shipsPlacedCount = 0;
        int computerShipsPlacedCount = 0;

        private bool isPlayerTurn = true;
        private int currentRound = 1;
        private bool GameFinished = false;

        int timeLeft = 5;


        public game3()
        {
            InitializeComponent();

            InitializeGrid(playerGrid, 91, 200);
            InitializeGrid(computerGrid, 583, 200);
            StopTimer();



            UpdateRoundCounter();

            PlaceComputerShips();
        }

        private void UpdateRoundCounter()
        {
            roundCounter.Text = "" + currentRound;
            roundCounter.Refresh();
        }

        private void UpdateShipCounter()
        {
            int playerShipsRemainingCount = 5 - CountSunkShips(playerBoard);
            playerShipsRemaining.Text = "" + playerShipsRemainingCount;
            playerShipsRemaining.Refresh();

            int computerShipsRemainingCount = 5 - CountSunkShips(computerBoard);
            computerShipsRemaining.Text = "" + computerShipsRemainingCount;
            computerShipsRemaining.Refresh();

        }

        private List<(int x, int y)> computerMoves = new List<(int x, int y)>();

        private void StartTimer()
        {
            GridButtonTimer.Start();
        }

        private void ResetTimer()
        {

            timeLeft = 5;
            TimerLabel.Text = timeLeft + " seconds";

        }
        private void StopTimer()
        {
            GridButtonTimer.Stop();
        }



        private void InitializeGrid(Button[,] grid, int startX, int startY)
        {
            int buttonWidth = 40;
            int buttonHeight = 40;
            int horizontalSpacing = 0;
            int verticalSpacing = 0;


            for (int x = 0; x < 8; x++)
            {
                for (int y = 0; y < 8; y++)
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

            InstructionsLabel.Text = "Place your \n5 ships";

        }




        private void UpdateEventHandlers(Button[,] grid, EventHandler newHandler)
        {
            for (int x = 0; x < 8; x++)
            {
                for (int y = 0; y < 8; y++)
                {
                    grid[x, y].Click -= ShipPlacement_Click; //Removing ship placement handler
                    grid[x, y].Click -= GridButton_Click;     //Removing grid button handler
                    grid[x, y].Click -= ComputerMove;         //Removing computer move handler

                    grid[x, y].Click += newHandler;           //Adding a new handler
                }
            }
        }


        //ship placement 
        private void ShipPlacement_Click(object sender, EventArgs e)
        {
            Console.WriteLine("ShipPlacement_Click method called.");

            if (!isPlayerTurn || !shipPlacementPhase)
                return;

            if (shipsPlacedCount >= 3)
            {
                MessageBox.Show("You can only place 3 ships. Click onto the enemy's grid to attack and start the game.");
                shipPlacementPhase = false;
                return;
            }

            Button clickedButton = (Button)sender;
            int x = GetXCoordinate(clickedButton);
            int y = GetYCoordinate(clickedButton);

            if (playerGrid[x, y] == clickedButton)
            {
                if (playerBoard[x, y] == 0)
                {
                    if (shipsPlacedCount < 2)  // Place two 3-tile ships
                    {
                        // Prompt the user for ship orientation
                        DialogResult result = MessageBox.Show("Do you want to place the ship horizontally?", "Ship Placement", MessageBoxButtons.YesNoCancel);

                        if (result == DialogResult.Yes)
                        {
                            // Check if the placement is valid horizontally
                            if (IsValidShipPlacement(x, y, true, 3))
                            {
                                // Place the ship
                                PlaceShip(x, y, true, 3);
                                shipsPlacedCount++;
                            }
                            else
                            {
                                MessageBox.Show("Invalid ship placement. Ships must be placed horizontally in a continuous line and be 3 tiles long.");
                            }
                        }
                        else if (result == DialogResult.No)
                        {
                            // Check if the placement is valid vertically
                            if (IsValidShipPlacement(x, y, false, 3))
                            {
                                // Place the ship
                                PlaceShip(x, y, false, 3);
                                shipsPlacedCount++;
                            }
                            else
                            {
                                MessageBox.Show("Invalid ship placement. Ships must be placed vertically in a continuous line and be 3 tiles long.");
                            }
                        }
                        else
                        {
                            // User canceled ship placement
                            return;
                        }
                    }
                    else if (shipsPlacedCount == 2)  // Place one 5-tile ship
                    {
                        DialogResult result = MessageBox.Show("Do you want to place the ship horizontally?", "Ship Placement", MessageBoxButtons.YesNoCancel);

                        if (result == DialogResult.Yes)
                        {
                            // Check if the placement is valid horizontally
                            if (IsValidShipPlacement(x, y, true, 5))
                            {
                                // Place the ship
                                PlaceShip(x, y, true, 5);
                                shipsPlacedCount++;
                            }
                            else
                            {
                                MessageBox.Show("Invalid ship placement. Ships must be placed horizontally in a continuous line and be 5 tiles long.");
                            }
                        }
                        else if (result == DialogResult.No)
                        {
                            // Check if the placement is valid vertically
                            if (IsValidShipPlacement(x, y, false, 5))
                            {
                                // Place the ship
                                PlaceShip(x, y, false, 5);
                                shipsPlacedCount++;
                            }
                            else
                            {
                                MessageBox.Show("Invalid ship placement. Ships must be placed vertically in a continuous line and be 5 tiles long.");
                            }
                        }
                        else
                        {
                            // User canceled ship placement
                            return;
                        }
                    }

                    if (shipsPlacedCount == 3)
                    {
                        MessageBox.Show("All Battleships Placed. Click onto the enemy's grid to attack and start the game.");
                        shipPlacementPhase = false;
                        UpdateEventHandlers(computerGrid, GridButton_Click);
                        InstructionsLabel.Text = "Attack the enemy";
                        currentRound++;
                        UpdateRoundCounter();
                        StartTimer();
                    }
                }
                else
                {
                    MessageBox.Show("You can't place your Battleship here. Find an empty cell!");
                }
            }
        }

        private bool IsValidShipPlacement(int x, int y, bool isHorizontal, int length)
        {
            return isHorizontal ? IsValidHorizontalShip(x, y, length) : IsValidVerticalShip(x, y, length);
        }

        private bool IsValidHorizontalShip(int x, int y, int length)
        {
            if (x + length > 8)
            {
                return false;
            }

            for (int i = 0; i < length; i++)
            {
                if (playerBoard[x + i, y] == 1)
                {
                    return false;
                }
            }
            return true;
        }

        private bool IsValidVerticalShip(int x, int y, int length)
        {
            if (y + length > 8)
            {
                return false;
            }

            for (int i = 0; i < length; i++)
            {
                if (playerBoard[x, y + i] == 1)
                {
                    return false;
                }
            }
            return true;
        }

        private void PlaceShip(int x, int y, bool isHorizontal, int length)
        {
            if (isHorizontal)
            {
                for (int i = 0; i < length; i++)
                {
                    playerBoard[x + i, y] = 1;
                    playerGrid[x + i, y].BackColor = Color.Green;
                }
            }
            else
            {
                for (int i = 0; i < length; i++)
                {
                    playerBoard[x, y + i] = 1;
                    playerGrid[x, y + i].BackColor = Color.Green;
                }
            }
        }

        private bool IsValidComputerShipPlacement(int x, int y, bool isHorizontal, int length)
        {
            return isHorizontal ? IsValidHorizontalComputerShip(x, y, length) : IsValidVerticalComputerShip(x, y, length);
        }

        private bool IsValidHorizontalComputerShip(int x, int y, int length)
        {
            if (x + length > 8)
            {
                return false;
            }

            for (int i = 0; i < length; i++)
            {
                if (computerBoard[x + i, y] == 1 || playerBoard[x + i, y] == 1)
                {
                    return false;  // To Check if the position is already occupied by a ship
                }
            }

            return true;
        }

        private bool IsValidVerticalComputerShip(int x, int y, int length)
        {
            if (y + length > 8)
            {
                return false;
            }

            for (int i = 0; i < length; i++)
            {
                if (computerBoard[x, y + i] == 1 || playerBoard[x, y + i] == 1)
                {
                    return false;  // To Check if the position is already occupied by a ship
                }
            }

            return true;
        }

        private void PlaceComputerShips()
        {
            Console.WriteLine("PlaceComputerShips method called.");

            Random random = new Random();

            // Place two ships of length 3
            for (int i = 0; i < 2; i++)
            {
                int shipLength = 3;
                PlaceComputerShipRandomly(random, shipLength);
            }

            // Place one ship of length 5
            int shipLength5 = 5;
            PlaceComputerShipRandomly(random, shipLength5);
        }

        private void PlaceComputerShipRandomly(Random random, int shipLength)
        {
            while (true)
            {
                int x = random.Next(8);
                int y = random.Next(8);

                bool isHorizontal = random.Next(2) == 0; // Randomly choose horizontal or vertical placement

                if (IsValidComputerShipPlacement(x, y, isHorizontal, shipLength))
                {
                    PlaceComputerShip(x, y, isHorizontal, shipLength);
                    computerShipsPlacedCount++;
                    break;
                }
            }
        }

        private void PlaceComputerShip(int x, int y, bool isHorizontal, int length)
        {
            if (isHorizontal)
            {
                for (int i = 0; i < length; i++)
                {
                    computerBoard[x + i, y] = 1;
                    computerGrid[x + i, y].BackColor = Color.Green;
                }
            }
            else
            {
                for (int i = 0; i < length; i++)
                {
                    computerBoard[x, y + i] = 1;
                    computerGrid[x, y + i].BackColor = Color.Green;
                }
            }
        }

        private int GetXCoordinate(Button button)
        {
            for (int x = 0; x < 8; x++)
            {
                for (int y = 0; y < 8; y++)
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
            for (int x = 0; x < 8; x++)
            {
                for (int y = 0; y < 8; y++)
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

            TimerLabel.Visible = false;
            Console.WriteLine("GridButton_Click method called."); // adding a logging statement


            if (!isPlayerTurn)
                return;

            Button clickedButton = (Button)sender;
            int x = GetXCoordinate(clickedButton);
            int y = GetYCoordinate(clickedButton);

            Console.WriteLine($"Clicked on computerBoard[{x}, {y}]"); // debuging output


            if (x >= 0 && x < 8 && y >= 0 && y < 8)
            {
                if (computerBoard[x, y] == 1)
                {
                    clickedButton.BackColor = Color.Red;
                    MessageBox.Show("BOOM! You sunk a battleship");
                    UpdateShipCounter();

                    if (CountSunkShips(computerBoard) == 5)
                    {
                        MessageBox.Show("You are too good! You sank all the Enemy's battleships. You win!");
                        InstructionsLabel.Text = "You are victorious";
                        GameFinished = true;
                        DisableGridButtons();
                   

                        return;
                    }

                    isPlayerTurn = false;
                    ComputerMove(null, null);

                }
                else
                {
                    clickedButton.BackColor = Color.Gray;
                    MessageBox.Show("MISS! The Enemy's turn");
                    isPlayerTurn = false;
                    ComputerMove(null, null);

                }
            }

        }





        private void DisableGridButtons()
        {
            for (int x = 0; x < 4; x++)
            {
                for (int y = 0; y < 4; y++)
                {
                    playerGrid[x, y].Enabled = false;
                }
            }

            for (int x = 0; x < 4; x++)
            {
                for (int y = 0; y < 4; y++)
                {
                    computerGrid[x, y].Enabled = false;
                }
            }

        }

            // computer move
            private async void ComputerMove(object sender, EventArgs e)
        {
            StopTimer();
            InstructionsLabel.Text = "Waiting for Enemy's move";

            await Task.Delay(2000); // 2 seconds

            if (isPlayerTurn)
            {
                return;
            }

            Random random = new Random();

            // Keep generating new random coordinates until a unique one is found
            int x, y;
            do
            {
                x = random.Next(8);
                y = random.Next(8);
            } while (computerMoves.Contains((x, y)));

            computerMoves.Add((x, y)); // Remember the chosen position

            Console.WriteLine($"Computer chose coordinates: ({x}, {y})"); // Print coordinates to console (For Testing and Verfication)

            if (playerBoard[x, y] == 1)
            {
                playerGrid[x, y].BackColor = Color.Red;
                MessageBox.Show("BOOM! The enemy sunk one of your battleships");
                UpdateShipCounter();
                isPlayerTurn = true;

                if (CountSunkShips(playerBoard) == 5)
                {
                    MessageBox.Show("You are awful! The enemy sank all the of your battleships. You lose!");
                    InstructionsLabel.Text = "The enemy won";
                    GameFinished = true;
                    DisableGridButtons();
                

                    currentRound++;
                    UpdateRoundCounter();
                    return;
                }
            }
            else
            {
                playerGrid[x, y].BackColor = Color.Yellow;
                MessageBox.Show("Enemy MISSED! Your turn");
                isPlayerTurn = true;
            }

            currentRound++;
            UpdateRoundCounter();

            ResetTimer();
            StartTimer();

            if (!TimerLabel.Visible)
            {
                TimerLabel.Visible = true;
            }

            InstructionsLabel.Text = "Attack the enemy";
        }


        private int CountSunkShips(int[,] board)
        {

            int count = 0;

            for (int x = 0; x < board.GetLength(0); x++)
            {
                for (int y = 0; y < board.GetLength(1); y++)
                {
                    if (board[x, y] == 1 && playerGrid[x, y].BackColor == Color.Red)
                    {
                        count++;
                    }
                    else if (board[x, y] == 1 && computerGrid[x, y].BackColor == Color.Red)
                    {
                        count++;
                    }
                }
            }

            return count;
        }


        private void game_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Welcome to battleships. Place you ships onto your grid.");

            game3panel.Location = new Point(                            // these 4 lines of code to postion the panel were taken from Overstackflow posted by Fredrik Mörk
            this.ClientSize.Width / 2 - game3panel.Size.Width / 2,
            this.ClientSize.Height / 2 - game3panel.Size.Height / 2);
            game3panel.Anchor = AnchorStyles.None;

        }

        private void game_panel_Paint(object sender, PaintEventArgs e)
        {
            game3panel.SendToBack();

        }

        private void EndGame_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void rulesBtn_Click(object sender, EventArgs e)
        {
            rules_page rulesForm = new rules_page();
            rulesForm.Show();
        }


        private void GridButtonTimer_Tick_1(object sender, EventArgs e)
        {
            if (timeLeft > 0)
            {
                timeLeft = timeLeft - 1;
                TimerLabel.Text = timeLeft + " seconds\nto make a move";
            }
            else
            {
                GridButtonTimer.Stop();
                TimerLabel.Text = "Time is up! Computers turn";
                isPlayerTurn = false;
                ComputerMove(null, null);
                return;
            }
        }

        private void game3panel_Paint(object sender, PaintEventArgs e)
        {
            game3panel.SendToBack();

        }

        private void rulesBtn_Click_1(object sender, EventArgs e)
        {
            rules_page rulesForm = new rules_page();
            rulesForm.Show();
        }

        private void NewGame_Click(object sender, EventArgs e)
        {
            game3 start = new game3();
            start.ShowDialog();
            this.Close();
        }

        private void EndGame_Click_1(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}

    

