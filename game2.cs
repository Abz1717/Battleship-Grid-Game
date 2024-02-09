

// Group 14 Abz Mohamed, Tanush, Hannah


// Medium level


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
using static System.Windows.Forms.LinkLabel;

namespace Battleship_Grid_Game
{
    public partial class game2 : Form
    {

        Button[,] playerGrid = new Button[6, 6];
        Button[,] computerGrid = new Button[6, 6];

        int[,] playerBoard = new int[6, 6];
        int[,] computerBoard = new int[6, 6];



        bool shipPlacementPhase = true;
        int shipsPlacedCount = 0;
        int destroyerPlacedCount = 0;
        int computerShipsPlacedCount = 0;
        int computerDestroyerPlacedCount = 0;



        private bool isPlayerTurn = true;
        private int currentRound = 1;
        private bool GameFinished = false;

        int timeLeft = 10;



        public game2()
        {
            InitializeComponent();
            InitializeGrid(playerGrid, 81, 197);
            InitializeGrid(computerGrid, 576, 197);

            StopTimer();
            UpdateRoundCounter();
        }


        private void HandleError(Exception ex)
        {
            MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            LogException(ex);
        }


        private void LogException(Exception ex)
        {
            Debug.WriteLine("Exception: " + ex.Message);
            Debug.WriteLine("StackTrace: " + ex.StackTrace);
        }


        private void InitializeGrid(Button[,] grid, int startX, int startY)
        {
            try
            {

                int buttonWidth = 51;
                int buttonHeight = 51;
                int horizontalSpacing = 1;
                int verticalSpacing = 1;


                for (int x = 0; x < 6; x++)
                {
                    for (int y = 0; y < 6; y++)
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
            catch  (Exception ex)
            {
                Console.WriteLine($"An error occurred in UpdateEventHandlers: {ex.Message}");
                HandleError(ex);

            }

        }



        private void UpdateEventHandlers(Button[,] grid, EventHandler newHandler)
        {
            try
            {
                for (int x = 0; x < 6; x++)
                {
                    for (int y = 0; y < 6; y++)
                    {
                        grid[x, y].Click -= ShipPlacement_Click; //Removing ship placement handler
                        grid[x, y].Click -= GridButton_Click;     //Removing grid button handler
                        grid[x, y].Click -= ComputerMove;         //Removing computer move handler

                        grid[x, y].Click += newHandler;           //Adding a new handler
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred in UpdateEventHandlers: {ex.Message}");
                HandleError(ex);

            }
        }

        private void ShipPlacement_Click(object sender, EventArgs e)
        {


            try
            {
                Console.WriteLine("ShipPlacement_Click method called."); // adding a logging statement



                if (!isPlayerTurn || !shipPlacementPhase)
                    return;


                if (shipsPlacedCount + destroyerPlacedCount >= 5)
                {
                    MessageBox.Show("You can only place 4 Battleships and 1 Destroyer. Click the onto the enemy's grid to attack and start the game. ");
                    shipPlacementPhase = false;
                    return;
                }


                Button clickedButton = (Button)sender;
                int x = GetXCoordinate(clickedButton);
                int y = GetYCoordinate(clickedButton);

                if (playerGrid[x, y] == clickedButton)
                {

                    if (shipsPlacedCount < 4)
                    {
                        if (playerBoard[x, y] == 0)
                        {
                            playerBoard[x, y] = 1;
                            clickedButton.BackColor = Color.Green;
                            shipsPlacedCount++;

                            if (shipsPlacedCount == 4)
                            {
                                MessageBox.Show("All Battleships Placed. Now place your destroyer \n(Remember destroyers do not count as battleships, they are used as counters/traps)");
                            }
                        }
                        else
                        {
                            MessageBox.Show("You can't place your battleship here. Find an empty cell!");
                        }
                    }

                    else if (destroyerPlacedCount < 1)
                    {
                        if (playerBoard[x, y] == 0)
                        {
                            playerBoard[x, y] = 2;
                            clickedButton.BackColor = Color.Orange;
                            destroyerPlacedCount++;

                            if (destroyerPlacedCount == 1)
                            {
                                MessageBox.Show("All Ships Placed. Click onto the enemy's grid to attack and start the game.");
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
                            MessageBox.Show("You can't place your destroyer here. Find an empty cell!");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
            
                Console.WriteLine($"An error occurred in ShipPlacement_Click: {ex.Message}");
                HandleError(ex);

            }
        
        }

        private void PlaceComputerShips()
        {

            Random random = new Random();



            while (computerShipsPlacedCount < 4)
            {
                int x = random.Next(6);
                int y = random.Next(6);

                if (computerBoard[x, y] == 0)
                {
                    computerBoard[x, y] = 1;
                    computerShipsPlacedCount++;

                    computerGrid[x, y].BackColor = Color.Green;

                }
            }

            while (computerDestroyerPlacedCount < 1)
            {
                    int x = random.Next(6);
                    int y = random.Next(6);

                    if (computerBoard[x, y] == 0)
                    {
                    computerBoard[x, y] = 2;
                    computerDestroyerPlacedCount++;
                    computerGrid[x, y].BackColor = Color.Orange;

                }

            }

        }

        private void GridButton_Click(object sender, EventArgs e)
        {

            try
            {


                if (!isPlayerTurn || GameFinished)
                    return;
                           
                TimerLabel.Visible = false;
                Console.WriteLine("GridButton_Click method called."); // adding a logging statement


                Button clickedButton = (Button)sender;
                int x = GetXCoordinate(clickedButton);
                int y = GetYCoordinate(clickedButton);

                Console.WriteLine($"Clicked on computerBoard[{x}, {y}]"); // debuging output


                if (CountSunkShips(playerBoard) == 4)
                {
                    InstructionsLabel.Text = "The enemy won";
                }
                else if (CountSunkShips(computerBoard) == 4)
                {
                    InstructionsLabel.Text = "You won";
                }

                if (x < 0 || x >= 6 || y < 0 || y >= 6)
                    return;

                if (computerBoard[x, y] == 1)
                {
                    computerBoard[x, y] = -1;
                    clickedButton.BackColor = Color.Red;
                    MessageBox.Show("BOOM! You sunk a battleship");
                    UpdateShipCounter();

                    if (CountSunkShips(computerBoard) == 4)
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
                else if (computerBoard[x, y] == 2)
                {
                    clickedButton.BackColor = Color.DarkRed;
                    MessageBox.Show("BOOM! You hit the enemy's destroyer!");


                    Random random = new Random();

                    do
                    {
                        x = random.Next(6);
                        y = random.Next(6);
                    } while (playerBoard[x, y] != 1);

                    playerBoard[x, y] = -1;
                    playerGrid[x, y].BackColor = Color.Red;
                    MessageBox.Show("The destroyer sank one of your ships!");
                    UpdateShipCounter();

                    isPlayerTurn = false;
                    ComputerMove(null, null);


                }

                else if (computerBoard[x, y] == 0)
                {
                    clickedButton.BackColor = Color.Gray;
                    MessageBox.Show("MISS! The Enemy's turn");
                    isPlayerTurn = false;
                    ComputerMove(null, null);

                }

                isPlayerTurn = false;
            }
            catch (Exception ex)
            {
            
                Console.WriteLine($"An error occurred in GridButton_Click: {ex.Message}");
                HandleError(ex);

            }
        
        }


        private void DisableGridButtons()
        {
            try
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
            catch(Exception ex) 
            {
                Console.WriteLine($"An error occurred in DisableGridButtons: {ex.Message}");
                HandleError(ex);
            }

        }



        private async void ComputerMove(object sender, EventArgs e)
        {

            try
            {
                Console.WriteLine("ComputerMove method called."); // adding a logging statement


                if (CountSunkShips(computerBoard) == 4)
                {
                    InstructionsLabel.Text = "You won";
                }

                if (GameFinished)
                {
                    MessageBox.Show("The game has already finished");
                    return;

                }



                StopTimer();
                InstructionsLabel.Text = "Waiting for Enemy's move";


                await Task.Delay(3000); // 3 seconds

                if (isPlayerTurn)
                {
                    return;
                }


                Random random = new Random();
                int x = random.Next(6);
                int y = random.Next(6);

                if (playerBoard[x, y] == 1)
                {
                    playerBoard[x, y] = -1;
                    playerGrid[x, y].BackColor = Color.Red;

                    MessageBox.Show("BOOM! The enemy sunk one of your battleships");
                    UpdateShipCounter();
                    isPlayerTurn = true;


                    if (CountSunkShips(playerBoard) == 4)
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
                else if (playerBoard[x, y] == 2) // If the computer hits the player's destroyer
                {
                    playerGrid[x, y].BackColor = Color.DarkRed;
                    MessageBox.Show("BOOM! The enemy hit your destroyer!");

                    do
                    {
                        x = random.Next(6);
                        y = random.Next(6);
                    } while (computerBoard[x, y] != 1); // Find a battleship to sink

                    await Task.Delay(1000);

                    computerBoard[x, y] = -1;
                    computerGrid[x, y].BackColor = Color.Red;
                    MessageBox.Show("The destroyer sank one of your ships!");
                    UpdateShipCounter();
                    isPlayerTurn = true;
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



                isPlayerTurn = true;
            }

            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred in ComputerMove: {ex.Message}");
                HandleError(ex);

            }


        }

        private int GetXCoordinate(Button button)
        {
            
                for (int x = 0; x < 6; x++)
                {
                    for (int y = 0; y < 6; y++)
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
            for (int x = 0; x < 6; x++)
            {
                for (int y = 0; y < 6; y++)
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

        private int CountSunkShips(int[,] board)
        {
            try
            {
                int count = 0;

                for (int x = 0; x < board.GetLength(0); x++)
                {
                    for (int y = 0; y < board.GetLength(1); y++)
                    {
                        if (board[x, y] == -1 && board == playerBoard && playerGrid[x, y].BackColor == Color.Red)
                        {
                            count++;
                        }
                        else if (board[x, y] == -1 && board == computerBoard && computerGrid[x, y].BackColor == Color.Red)
                        {
                            count++;
                        }


                    }
                }

                return count;
            }
            catch (Exception ex)
            {
                HandleError(ex);
                Console.WriteLine($"An error occurred in ComputerMove: {ex.Message}");
                return -1;
            }
        }

        private void game2_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Welcome to battleships. Place you ships onto your grid.");

            isPlayerTurn = true;
            InstructionsLabel.Text = "Place your \n4 Battleships + 1 Destroyer";

            game2panel.Location = new Point(                            // these 4 lines of code to postion the panel were taken from Overstackflow posted by Fredrik Mörk
            this.ClientSize.Width / 2 - game2panel.Size.Width / 2,
            this.ClientSize.Height / 2 - game2panel.Size.Height / 2);
            game2panel.Anchor = AnchorStyles.None;



            PlaceComputerShips();
        }

        private void GridButtonTimer_Tick(object sender, EventArgs e)
        {

            if (timeLeft > 0)
            {
                timeLeft = timeLeft - 1;
                TimerLabel.Text = timeLeft + " seconds\nto make a move";
            }
            else
            {
                GridButtonTimer.Stop();
                TimerLabel.Text = "Time is up! Enemys turn";
                isPlayerTurn = false;
                ComputerMove(null, null);
                return;
            }


        }

        private void StartTimer()
        {
            GridButtonTimer.Start();
        }

        private void ResetTimer()
        {

            timeLeft = 10;
            TimerLabel.Text = timeLeft + " seconds";

        }
        private void StopTimer()
        {
            GridButtonTimer.Stop();
        }


        private void UpdateRoundCounter()
        {
            roundCounter.Text = "" + currentRound;
            roundCounter.Refresh();
        }

        private void UpdateShipCounter()
        {
            int playerShipsRemainingCount = 4 - CountSunkShips(playerBoard);
            playerShipsRemaining.Text = "" + playerShipsRemainingCount;
            playerShipsRemaining.Refresh();

            int computerShipsRemainingCount = 4 - CountSunkShips(computerBoard);
            computerShipsRemaining.Text = "" + computerShipsRemainingCount;
            computerShipsRemaining.Refresh();



        }

        private void game2panel_Paint(object sender, PaintEventArgs e)
        {
            game2panel.SendToBack();

        }

        private void EndGame_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void rulesBtn_Click(object sender, EventArgs e)
        {
            rules_page rulesForm = new rules_page();
            rulesForm.Show();
        }

        private void NewGame_Click(object sender, EventArgs e)
        {
            game2 start = new game2();
            start.ShowDialog();
            this.Close();
        }
    }
}
