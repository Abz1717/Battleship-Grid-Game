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
        private int currentRound = 1;

        int timeLeft = 15;

        private Random random = new Random();
        private bool hintUsed = false;

        private bool GameFinished = false;




        public game()
        {


            InitializeComponent();
            InitializeGrid(playerGrid, 102, 210);
            InitializeGrid(computerGrid, 596, 210);
            StopTimer();



            UpdateRoundCounter();




        }



        private void UpdateRoundCounter()
        {
            roundCounter.Text = "" + currentRound;
            roundCounter.Refresh();
        }

        private void UpdateShipCounter()
        {
            int playerShipsRemainingCount = 3 - CountSunkShips(playerBoard);
            playerShipsRemaining.Text = "" + playerShipsRemainingCount;
            playerShipsRemaining.Refresh();

            int computerShipsRemainingCount = 3 - CountSunkShips(computerBoard);
            computerShipsRemaining.Text = "" + computerShipsRemainingCount;
            computerShipsRemaining.Refresh();

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
                TimerLabel.Text = "Time is up! Computers turn";
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

            timeLeft = 15;
            TimerLabel.Text = timeLeft + " seconds";

        }
        private void StopTimer()
        {
            GridButtonTimer.Stop();
        }




        // had problems using these methods
        /*
        private async Task Countdown(int durationInSeconds)
        {

            int remainingSeconds = durationInSeconds;

              while (remainingSeconds > 0 && !shipPlacementPhase)
                {
                    UpdateLabel($"Time left: {remainingSeconds} seconds");
                    await Task.Delay(1000);
                    remainingSeconds--;
                }

            if (!shipPlacementPhase)
            {
                UpdateLabel("Time's up! It's the computer's turn.");
                isPlayerTurn = false;
                ComputerMove(null, null);
            }


        }
       

        private void UpdateLabel(string text)
        {
            if (TimerLabel.InvokeRequired)
            {
                TimerLabel.Invoke(new Action(() => TimerLabel.Text = text));
            }
            else
            {
                TimerLabel.Text = text;
            }

            Console.WriteLine(text);
        }
         */

        private void InitializeGrid(Button[,] grid, int startX, int startY)
        {
            int buttonWidth = 67;
            int buttonHeight = 67;
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

            InstructionsLabel.Text = "Place your \n3 ships";

        }




        private void UpdateEventHandlers(Button[,] grid, EventHandler newHandler)
        {
            for (int x = 0; x < 4; x++)
            {
                for (int y = 0; y < 4; y++)
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

            Console.WriteLine("ShipPlacement_Click method called."); // adding a logging statement



            if (!isPlayerTurn || !shipPlacementPhase)
                return;


            if (shipsPlacedCount >= 3)
            {
                MessageBox.Show("You can only place 3 ships. Click the onto the enemy's grid to attack and start the game. ");
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
                    playerBoard[x, y] = 1;
                    clickedButton.BackColor = Color.Green;

                    shipsPlacedCount++;

                    if (shipsPlacedCount == 3)
                    {
                        MessageBox.Show("All Battleships Placed. Click the onto the enemy's grid to attack and start the game. ");
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

            TimerLabel.Visible = false;
            Console.WriteLine("GridButton_Click method called."); // adding a logging statement


            if (!isPlayerTurn)
                return;

            if (GameFinished)
            {
                MessageBox.Show("The game has already finished");
                InstructionsLabel.Text = "Game Over";

                return;

            }
           
            

            Button clickedButton = (Button)sender;
            int x = GetXCoordinate(clickedButton);
            int y = GetYCoordinate(clickedButton);

            Console.WriteLine($"Clicked on computerBoard[{x}, {y}]"); // debuging output


            if (x >= 0 && x < 4 && y >= 0 && y < 4)
            {
                if (computerBoard[x, y] == 1)
                {
                    computerBoard[x, y] = -1;
                    clickedButton.BackColor = Color.Red;
                    MessageBox.Show("BOOM! You sunk a battleship");
                    UpdateShipCounter();

                    if (CountSunkShips(computerBoard) == 3)
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


            await Task.Delay(3000); // 3 seconds

            if (isPlayerTurn)
            {
                return;
            }


            if (GameFinished)
            {
               MessageBox.Show("The game has already finished");
               return;

            }

            Random random = new Random();
            int x = random.Next(4);
            int y = random.Next(4);

            if (playerBoard[x, y] == 1)
            {
                playerBoard[x, y] = -1;
                playerGrid[x, y].BackColor = Color.Red;
                MessageBox.Show("BOOM! The enemy sunk one of your battleships");
                UpdateShipCounter();
                isPlayerTurn = true;


                if (CountSunkShips(playerBoard) == 3)
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








        private void game_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Welcome to battleships. Place you ships onto your grid.");

            game_panel.Location = new Point(                            // these 4 lines of code to postion the panel were taken from Overstackflow posted by Fredrik Mörk
            this.ClientSize.Width / 2 - game_panel.Size.Width / 2,
            this.ClientSize.Height / 2 - game_panel.Size.Height / 2);
            game_panel.Anchor = AnchorStyles.None;

            

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


        private void pictureBox1_Click(object sender, EventArgs e)
        {
            game start = new game();
            start.ShowDialog();
            this.Close();
        }

        private void rulesBtn_Click(object sender, EventArgs e)
        {
            rules_page rulesForm = new rules_page();
            rulesForm.Show();
        }


        private void HintButton_Click(object sender, EventArgs e)
        {
            if (!hintUsed)
            {
                HintButton.Text = "0 Hints Left";
                ShowComputerShipHint();
                hintUsed = true;

            }
        }

        private void ShowComputerShipHint()
        {
            int x, y;

            do
            {
                x = random.Next(4);
                y = random.Next(4);
            } while (computerBoard[x, y] == 0);

            computerGrid[x, y].BackColor = Color.Yellow;
        }
    }
}
