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

        private (int x, int y)? lastHitPosition = null;
        private (int dx, int dy)? hitDirection = null;

        /*
         * This is a flag to check if the ship is sunk, if the ship is sunk the computer will use the stored move options to make a move. 
         * It is also a List to store the sunk ship move options so that the computer can access them, important as player plays inbetween the computer's moves
         */
        private bool isShipSunk = false;
        private List<(int, int)> sunkShipMoveOptions = new List<(int, int)>();

        bool shipPlacementPhase = true;
        int shipsPlacedCount = 0;
        int computerShipsPlacedCount = 0;

        private bool isPlayerTurn = true;
        private int currentRound = 1;
        private bool GameFinished = false;

        int timeLeft = 5;

        /*
         * This is the constructor for the game, it initializes the grid for the player and the computer and places the computer's ships on the grid
         */
        public game3()
        {
            InitializeComponent();

            InitializeGrid(playerGrid, 91, 200);
            InitializeGrid(computerGrid, 583, 200);
            StopTimer();



            UpdateRoundCounter();

            PlaceComputerShips();
        }

        /*
         * This method updates the round counter for the game
         */
        private void UpdateRoundCounter()
        {
            roundCounter.Text = "" + currentRound;
            roundCounter.Refresh();
        }

        /*
         * This method updates the ship counter for the player and the computer
         */
        private void UpdateShipCounter()
        {
            int playerShipsRemainingCount = 5 - CountSunkShips(playerBoard);
            playerShipsRemaining.Text = "" + playerShipsRemainingCount;
            playerShipsRemaining.Refresh();

            int computerShipsRemainingCount = 5 - CountSunkShips(computerBoard);
            computerShipsRemaining.Text = "" + computerShipsRemainingCount;
            computerShipsRemaining.Refresh();

        }

        /*
         * This List is used to store the computer's moves, so that the computer doesn't make the same move twice. Improves the computer's gameplay and increaes the difficulty of the game
         */
        private List<(int x, int y)> computerMoves = new List<(int x, int y)>();

        //start the timer
        private void StartTimer()
        {
            GridButtonTimer.Start();
        }

        //reset the timer
        private void ResetTimer()
        {

            timeLeft = 5;
            TimerLabel.Text = timeLeft + " seconds";

        }

        //stop the timer
        private void StopTimer()
        {
            GridButtonTimer.Stop();
        }


        /*
         * This method initializes the grid for the game and sets the button size, colour, event handlers 
         */
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



        /*
         * This method updates the event handlers for the grid buttons
         */
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
            Console.WriteLine("ShipPlacement_Click method called."); //debugging

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
                        // Prompt the user for ship orientation (horizontal or vertical), this approach is good and simple and is functional
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
                            // User canceled ship placement will wait for them to click on another tile to place the ship
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

        /*
         * This method combines the horizontal and vertical validation of the player's ship placement and returns true if the ship placement is valid
         */
        private bool IsValidShipPlacement(int x, int y, bool isHorizontal, int length)
        {
            return isHorizontal ? IsValidHorizontalShip(x, y, length) : IsValidVerticalShip(x, y, length);
        }

        /*
         * Mehtod to check if the ship placement is valid horizontally for the player's ships
         */
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

        /*
         * Mehtod to check if the ship placement is valid vertically for the player's ships
         */
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

        /*
         * method to place the player's ships on the grid
         */
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

        /*
         * This method combined the veritcal and horizontal validation of the computer's ship placement and returns true if the ship placement is valid 
         * True will allow the PlaceComputerShip method to place the ship on the grid
         */
        private bool IsValidComputerShipPlacement(int x, int y, bool isHorizontal, int length)
        {
            return isHorizontal ? IsValidHorizontalComputerShip(x, y, length) : IsValidVerticalComputerShip(x, y, length);
        }

        /*
        * Random placement of the computer's ships requies validation of the position of the ship since there are multiple possible positions for the ship which could be invalid
        */
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

        /*
         * Random placement of the computer's ships requies validation of the position of the ship since there are multiple possible positions for the ship which could be invalid
         */
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

        /**
         * This function places the computer's ships randomly and calls the PlaceComputerShipRandomly method to place the ships in a vertical or horizontal manner in 
         * the chosen coordinates
         */
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

        // Place the computer's ships randomly
        private void PlaceComputerShipRandomly(Random random, int shipLength)
        {
            while (true)
            {
                int x = random.Next(8);
                int y = random.Next(8);

                bool isHorizontal = random.Next(2) == 0; // Randomly choose horizontal or vertical placement this is done for hard mode of the game

                if (IsValidComputerShipPlacement(x, y, isHorizontal, shipLength))
                {
                    PlaceComputerShip(x, y, isHorizontal, shipLength);
                    computerShipsPlacedCount++;
                    break;
                }
            }
        }

        /* Place the computer's ships has to be used in addition to the PlaceComputerShipRandomly method could be combined but for the sake of clarity I kept them separate
         * Improvement could be made where computer ships are placed in a more strategic way, but for the sake of simplicity I kept it random in that case splitting it would be more useful
         * This function handles if the ship is placed horizontally or vertically and then places the ship on the grid
         */

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

        //get the X coordinate of the button
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

        // Get the Y coordinate of the button
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

        /*
         * This method is used to handle the player's move, it is the main logic for the player's gameplay
         * It even has a partial win message for the player to let them know they've sunk half the fleet
         */
        private void GridButton_Click(object sender, EventArgs e)
        {
            TimerLabel.Visible = false;
            Console.WriteLine("GridButton_Click method called."); //debugging

            // Check if the game is over
            if (GameFinished)
            {
                MessageBox.Show("The game has already finished");
                InstructionsLabel.Text = "Game Over";

                return;

            }

            Button clickedButton = (Button)sender;
            int x = GetXCoordinate(clickedButton);
            int y = GetYCoordinate(clickedButton);

            Console.WriteLine($"Clicked on computerBoard[{x}, {y}]"); //debugging

            if (x >= 0 && x < 8 && y >= 0 && y < 8)
            {
                if (computerBoard[x, y] == 1)
                {
                    computerBoard[x, y] = -1;
                    clickedButton.BackColor = Color.Red;
                    MessageBox.Show("BOOM! You sunk a battleship");
                    UpdateShipCounter();

                    if (CountSunkShips(computerBoard) == 11)
                    {
                        MessageBox.Show("You are too good! You sank all the Enemy's battleships. You win!");
                        InstructionsLabel.Text = "You are victorious";
                        GameFinished = true;
                        DisableGridButtons();

                        return;
                    }
                    if (CountSunkShips(computerBoard) == 6)
                    {
                        MessageBox.Show("You have sunk half the enemy's fleet!!");
                        InstructionsLabel.Text = "You have sunk half the enemy's fleet!!";
                        GameFinished = false;
                        
                    }
                    else
                    {
                        isPlayerTurn = false;
                        ComputerMove(null, null);
                    }
                }
                else
                {
                    clickedButton.BackColor = Color.Gray;
                    MessageBox.Show("MISS! The Enemy's turn");
                    UpdateShipCounter();
                    isPlayerTurn = false;
                    ComputerMove(null, null);
                }
            }
        }

        //disable the grid buttons when the game is over
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

        /*
         * This method is used to handle the computer's move, it is the main logic for the computer's gameplay, the logic is not too complex and can be improved 
         * ways to improve mentioned in the comments of the method of MoveOptions 
         * It takes into account the sunk ship move options and then chooses a random position if no move options are available which is a decent approach
         * It also has partial win message for the player to let them know they've sunk half the fleet
         */
        private async void ComputerMove(object sender, EventArgs e)
        {
            StopTimer(); // Disable the timer while the computer is making a move

            InstructionsLabel.Text = "Waiting for Enemy's move";
            await Task.Delay(1000); // 1 second

            if (isPlayerTurn || GameFinished)
            {
                StartTimer(); // Re-enable the timer
                return;
            }

            Random random = new Random(); // Random number generator

            int x, y;

            List<(int, int)> moveOptions; // Store the move options

            // If a ship is sunk, use the stored move options
            if (isShipSunk == true)
            {
                moveOptions = sunkShipMoveOptions;
                isShipSunk = false; // Reset the flag after using the move options
            }
            else
            {
                moveOptions = MoveOptions(0, 0, computerBoard);
            }

            // If move options are available, choose one of them
            if (moveOptions.Count > 0)
            {
                int randomIndex = random.Next(moveOptions.Count);
                (x, y) = moveOptions[randomIndex];


                computerMoves.Add((x, y)); // Remember the chosen position

                Console.WriteLine($"Computer chose coordinates: ({x}, {y})");

                if (playerBoard[x, y] == 1)
                {
                    playerBoard[x, y] = 0;
                    playerGrid[x, y].BackColor = Color.Red;
                    MessageBox.Show("BOOM! The enemy sunk one of your battleships");
                    UpdateShipCounter();
                    isPlayerTurn = true;

                    SunkLog(x, y); // Log ship sinking 

                    // partial win condition
                    if (CountSunkShips(playerBoard) == 6)
                    {
                        MessageBox.Show("The enemy has sunk half your fleet!!");
                        InstructionsLabel.Text = "The enemy has sunk half your fleet!!";
                        GameFinished = false;
                    }
                    else if (CountSunkShips(playerBoard) == 11)
                    {
                        MessageBox.Show("You are awful! The enemy sank all the of your battleships. You lose!");
                        InstructionsLabel.Text = "The enemy won";
                        GameFinished = true;
                        DisableGridButtons();
                        currentRound++;
                        UpdateRoundCounter();
                    }

                    SunkLog(x, y); // Log ship sinking 
                }
                else
                {
                    playerGrid[x, y].BackColor = Color.Yellow;
                    MessageBox.Show("Enemy MISSED! Your turn");
                    isPlayerTurn = true;
                }

                currentRound++;
                UpdateRoundCounter();
                CountSunkShips(playerBoard);
            }
            else // If no move options available choose a random position
            {
                (x, y) = GetRandomPosition(random);
                computerMoves.Add((x, y)); // Remember the chosen position (Done so that computer remembers the position it has already chosen)

                Console.WriteLine($"Computer chose coordinates: ({x}, {y})");

                // Update last hit position only if it's a hit
                if (playerBoard[x, y] == 1)
                {
                    playerBoard[x, y] = 0;
                    playerGrid[x, y].BackColor = Color.Red;
                    MessageBox.Show("BOOM! The enemy sunk one of your battleships");
                    UpdateShipCounter();
                    isPlayerTurn = true;

                    lastHitPosition = null; // Reset last hit position after sinking a ship
                    hitDirection = null;    // Reset hit direction
                    SunkLog(x, y); // Log ship sinking 

                    if (CountSunkShips(playerBoard) == 6)
                    {
                        MessageBox.Show("The enemy has sunk half your fleet!!");
                        InstructionsLabel.Text = "The enemy has sunk half your fleet!!";
                        GameFinished = false;
                        return;
                    }
                    if (CountSunkShips(playerBoard) == 11)
                    {
                        MessageBox.Show("You are awful! The enemy sank all the of your battleships. You lose!");
                        InstructionsLabel.Text = "The enemy won";
                        GameFinished = true;
                        DisableGridButtons();
                        currentRound++;
                        UpdateRoundCounter();
                        return;
                    }

                    SunkLog(x, y); // Log ship sinking 
                }
                else
                {
                    playerGrid[x, y].BackColor = Color.Yellow;
                    MessageBox.Show("Enemy MISSED! Your turn");
                    isPlayerTurn = true;
                }

                currentRound++;
                UpdateRoundCounter();
                CountSunkShips(playerBoard);
            }

            ResetTimer(); // Reset the timer after the computer's move
            StartTimer(); // Re-enable the timer
            InstructionsLabel.Text = "Attack the enemy";
        }

        /*
         * This method is used to calculate the possible move options for the computer , it checks if the ship is sunk and then calculates the move options
         * If a ship was sunk the computer fetches the coordinates of the sunk ship and then calculated the move options in 4 directions since there is no diagonal placement 
         * This grealtly improves the computer's gameplay and makes it more challenging for the player as now it is not just random moves but the computer is aware of the 
         * surroiunding of the sunk ship and can make a more strategic move. This can defineltey be improved by adding more sophisticated logic to the computer's gameplay
         * 
         * One such example could be that the computer could calculate different paths from the sunk ship, it calculates more than one move option in each direction 
         * and then it could choose a path from the 4 available paths, if the option it chose is not a hit it could then choose another path and so on 
         * That would gurantee the computer will sink the ship and is almost human like in its gameplay
         * Could not implement this due to a lack of time but it is a good idea to improve the computer's gameplay
         */
        private List<(int, int)> MoveOptions(int sunkX, int sunkY, int[,] board)
        {
            Console.WriteLine($"Checking board value at ({sunkX}, {sunkY}): {board[sunkX, sunkY]}"); //debugging

            if (board[sunkX, sunkY] == 0)
            {
                Console.WriteLine("Ship sunk! Calculating move options..."); //debugging

                List<(int, int)> options = new List<(int, int)>();

                // Use sunk ship coordinates
                int x = sunkX;
                int y = sunkY;

                // Check left of the sunk ship
                if (x - 1 >= 0 && !computerMoves.Contains((x - 1, y)))
                {
                    options.Add((x - 1, y));
                    Console.WriteLine($"Left option: ({x - 1}, {y}) added"); //debugging
                }

                // Check right of the sunk ship
                if (x + 1 < 8 && !computerMoves.Contains((x + 1, y)))
                {
                    options.Add((x + 1, y));
                    Console.WriteLine($"Right option: ({x + 1}, {y}) added"); //debugging
                }

                // Check up the sunk ship 
                if (y - 1 >= 0 && !computerMoves.Contains((x, y - 1)))
                {
                    options.Add((x, y - 1));
                    Console.WriteLine($"Up option: ({x}, {y - 1}) added"); //debugging
                }

                // Check down the sunk ship
                if (y + 1 < 8 && !computerMoves.Contains((x, y + 1)))
                {
                    options.Add((x, y + 1));
                    Console.WriteLine($"Down option: ({x}, {y + 1}) added"); //debugging
                }

                if (options.Count == 0)
                {
                    Console.WriteLine("No valid move options found"); //debugging
                }
                else
                {
                    Console.WriteLine("Move options found:"); //debugging
                    foreach (var option in options)
                    {
                        // debugging Console.WriteLine($"Option: ({option.Item1}, {option.Item2})"); 
                    }
                }

                return options;
            }
            else
            {
                Console.WriteLine("No ship sunk. Choosing a random position..."); //debugging
                return new List<(int, int)> { GetRandomPosition(new Random()) };
            }
        }

        // Get a random position that hasn't been chosen before to avoid repeating moves
        private (int, int) GetRandomPosition(Random random)
        {
            int x, y;
            do
            {
                x = random.Next(8);
                y = random.Next(8);
            } while (computerMoves.Contains((x, y)));

            return (x, y);
        }

        // Log the sunk ship and call the MoveOptions method to get the move options
        private void SunkLog(int x, int y)
        {
            Console.WriteLine($"Computer sunk a ship at coordinates: ({x}, {y})");

            sunkShipMoveOptions = MoveOptions(x, y, computerBoard);

            if (sunkShipMoveOptions.Count > 0)
            {
                isShipSunk = true;
            }
            else
            {
                isShipSunk = false;
            }
        }

        // Count the number of sunk ships
        private int CountSunkShips(int[,] board)
        {
            int count = 0;

            for (int x = 0; x < board.GetLength(0); x++)
            {
                for (int y = 0; y < board.GetLength(1); y++)
                {
                    if (board == playerBoard && playerGrid[x, y].BackColor == Color.Red)
                    {
                        count++;
                    }
                    else if (board == computerBoard && computerGrid[x, y].BackColor == Color.Red)
                    {
                        count++;
                    }
                }
            }

            return count;
        }

       
        /**
         * Possible alternative to the CountSunkShips method, this is more extesnive and checks if the entire ship is sunk for the two different types of ships
         * didn't work as intended, so I commented it out, but if there was more time could be a good alternative to the CountSunkShips method for the hard mode of the game
         * The only problem to this approach is that, it would work better if from the beginning the logic was that ships are longer than one tile and 
         * this would be more sophistated if there were different types of ships with different lengths it could even tell which ship was sunk
        
        private bool IsShipSunk(int x, int y, int[,] board)
        {
            int shipLength = GetShipLength(x, y, board);

            // Check horizontally
            if (x + shipLength <= board.GetLength(0))
            {
                for (int i = x; i < x + shipLength; i++)
                {
                    if (playerGrid[i, y].BackColor != Color.Red)
                    {
                        //Console.WriteLine("Half the ship is not sunk");
                        return false; // Not the entire ship is sunk
                    }
                }
                Console.WriteLine("Ship is sunk");
                return true; // The entire ship is sunk
            }

            // Check vertically
            if (y + shipLength <= board.GetLength(1))
            {
                for (int i = y; i < y + shipLength; i++)
                {
                    if (playerGrid[x, i].BackColor != Color.Red)
                    {
                        Console.WriteLine("Half the ship is not sunk");
                        return false; // Not the entire ship is sunk
                    }
                }
                Console.WriteLine("Ship is sunk");
                return true; // The entire ship is sunk
            }

            return false;
        }



        private int GetShipLength(int x, int y, int[,] board)
        {
            // Check horizontally
            int length = 1;
            for (int i = x + 1; i < board.GetLength(0) && board[i, y] == 1; i++)
            {
                length++;
            }

            // Check vertically
            for (int i = y + 1; i < board.GetLength(1) && board[x, i] == 1; i++)
            {
                length++;
            }

            return length;
        }

        **/

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

        //timer
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

        // rules button
        private void rulesBtn_Click_1(object sender, EventArgs e)
        {
            rules_page rulesForm = new rules_page();
            rulesForm.Show();
        }

        // restart the game
        private void NewGame_Click(object sender, EventArgs e)
        {
            game3 start = new game3();
            start.ShowDialog();
            this.Close();
        }
    }
}

    

