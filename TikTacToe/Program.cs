using System;

namespace TikTacToe

{

    class Program

    {

        static void Main(string[] args)

        {
            explainGame();
            gameLoop();
        }

        static void gameLoop()
        {
            int turnCounter = 0;
            char player = 'X';
            char[,] grid = new char[3, 3];
            int box = 0;
            bool gameOver = false;


            InitGrid(ref grid);


            while (!gameOver)
            {
                drawGrid(ref grid);
                playerAlternater(turnCounter, ref player);
                Console.Write("Player " + player + ", select a box (1-9): ");
                boxPositionChecker(ref box, ref grid);
                inputIntoTheArray(ref grid, player, box);
                Console.WriteLine("You selected box: " + box);
                checkWinCondition(ref grid, ref gameOver);
                turnCounter++;
                Console.Clear();
            }

            Console.Write("New Game? (y/n): ");
            string response = Console.ReadLine();
            if (response.ToLower() == "y")
            {
                resetGame(ref grid, ref gameOver);
                gameLoop();
            }
            else
            {
                Console.Write("Thanks for playing!");
                Console.ReadKey(); // Wait for user input


            }


            static void drawGrid(ref char[,] grid)
            {
                Console.WriteLine("     |     |     ");
                Console.WriteLine("  " + grid[0, 0] + "  |  " + grid[0, 1] + "  |  " + grid[0, 2] + "  ");
                Console.WriteLine("_____|_____|_____");
                Console.WriteLine("     |     |     ");
                Console.WriteLine("  " + grid[1, 0] + "  |  " + grid[1, 1] + "  |  " + grid[1, 2] + "  ");
                Console.WriteLine("_____|_____|_____");
                Console.WriteLine("     |     |     ");
                Console.WriteLine("  " + grid[2, 0] + "  |  " + grid[2, 1] + "  |  " + grid[2, 2] + "  ");
                Console.WriteLine("     |     |     ");
            }

            static void playerAlternater(int turnCounter, ref char player)
            {
                if (turnCounter % 2 == 0)
                {
                    player = 'X';
                }
                else
                {
                    player = 'O';
                }
            }

            static void InitGrid(ref char[,] grid)
            {
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        grid[i, j] = ' ';
                    }
                }


            }

            static void boxPositionChecker(ref int box, ref char[,] grid)
            {
                box = Convert.ToInt32(Console.ReadLine());
                while (true)
                {
                    if (box >= 1 && box <= 9)
                    {

                        // break;
                        // switch -> if box[] is empty -> box is filled, ask for input again
                        switch (box)
                        {
                            case 1:
                                if (grid[0, 0] != ' ')
                                {
                                    Console.Write("Box is filled. Please select another box (1-9): ");
                                    boxPositionChecker(ref box, ref grid);
                                }
                                break;
                            case 2:
                                if (grid[0, 1] != ' ')
                                {
                                    Console.Write("Box is filled. Please select another box (1-9): ");
                                    boxPositionChecker(ref box, ref grid);
                                }
                                break;
                            case 3:
                                if (grid[0, 2] != ' ')
                                {
                                    Console.Write("Box is filled. Please select another box (1-9): ");
                                    boxPositionChecker(ref box, ref grid);
                                }
                                break;
                            case 4:
                                if (grid[1, 0] != ' ')
                                {
                                    Console.Write("Box is filled. Please select another box (1-9): ");
                                    boxPositionChecker(ref box, ref grid);
                                }
                                break;
                            case 5:
                                if (grid[1, 1] != ' ')
                                {
                                    Console.Write("Box is filled. Please select another box (1-9): ");
                                    boxPositionChecker(ref box, ref grid);
                                }
                                break;
                            case 6:
                                if (grid[1, 2] != ' ')
                                {
                                    Console.Write("Box is filled. Please select another box (1-9): ");
                                    boxPositionChecker(ref box, ref grid);
                                }
                                break;
                            case 7:
                                if (grid[2, 0] != ' ')
                                {
                                    Console.Write("Box is filled. Please select another box (1-9): ");
                                    boxPositionChecker(ref box, ref grid);
                                }
                                break;
                            case 8:
                                if (grid[2, 1] != ' ')
                                {
                                    Console.Write("Box is filled. Please select another box (1-9): ");
                                    boxPositionChecker(ref box, ref grid);
                                }
                                break;
                            case 9:
                                if (grid[2, 2] != ' ')
                                {
                                    Console.Write("Box is filled. Please select another box (1-9): ");
                                    boxPositionChecker(ref box, ref grid);
                                }
                                break;
                        }
                        break;
                    }
                    else
                    {
                        Console.Write("Invalid box. Please select a box (1-9): ");
                        box = Convert.ToInt32(Console.ReadLine());
                    }
                }
            }

            static void inputIntoTheArray(ref char[,] grid, char player, int box)
            {
                switch (box)
                {
                    case 1:
                        grid[0, 0] = player;
                        break;
                    case 2:
                        grid[0, 1] = player;
                        break;
                    case 3:
                        grid[0, 2] = player;
                        break;
                    case 4:
                        grid[1, 0] = player;
                        break;
                    case 5:
                        grid[1, 1] = player;
                        break;
                    case 6:
                        grid[1, 2] = player;
                        break;
                    case 7:
                        grid[2, 0] = player;
                        break;
                    case 8:
                        grid[2, 1] = player;
                        break;
                    case 9:
                        grid[2, 2] = player;
                        break;
                }
            }

            static void checkWinCondition(ref char[,] grid, ref bool gameOver)
            {
                int emptySpaces = 0;
                foreach (char c in grid)
                {
                    if (c == ' ')
                    {
                        emptySpaces++;
                        gameOver = false;
                        break;
                    }
                }

                if (emptySpaces == 0)
                {
                    drawGrid(ref grid);
                    Console.WriteLine("It's a draw!");
                    gameOver = true;
                    Console.ReadKey(); // Wait for user input
                    Console.Clear();
                }

                for (int i = 0; i < 3; i++)
                {
                    // Check rows
                    if (grid[i, 0] == grid[i, 1] && grid[i, 1] == grid[i, 2] && grid[i, 0] != ' ')
                    {
                        Console.Clear();
                        drawGrid(ref grid);
                        Console.WriteLine("Player " + grid[i, 0] + " wins!");
                        Console.Write("Press any key to continue...");
                        Console.ReadKey(); // Wait for user input

                        gameOver = true;
                    }
                    // Check columns
                    if (grid[0, i] == grid[1, i] && grid[1, i] == grid[2, i] && grid[0, i] != ' ')
                    {
                        Console.Clear();
                        drawGrid(ref grid);
                        Console.WriteLine("Player " + grid[0, i] + " wins!");
                        Console.Write("Press any key to continue...");
                        Console.ReadKey(); // Wait for user input

                        gameOver = true;

                    }

                    if (grid[0, 0] == grid[1, 1] && grid[1, 1] == grid[2, 2] && grid[0, 0] != ' ')
                    {
                        Console.Clear();
                        drawGrid(ref grid);
                        Console.WriteLine("Player " + grid[0, 0] + " wins!");
                        Console.Write("Press any key to continue...");
                        Console.ReadKey(); // Wait for user input

                        gameOver = true;

                    }

                    if (grid[0, 2] == grid[1, 1] && grid[1, 1] == grid[2, 0] && grid[0, 2] != ' ')
                    {
                        Console.Clear();
                        drawGrid(ref grid);
                        Console.WriteLine("Player " + grid[0, 2] + " wins!");
                        Console.Write("Press any key to continue...");
                        Console.ReadKey(); // Wait for user input

                        gameOver = true;

                    }
                }

            }

            static void resetGame(ref char[,] grid, ref bool gameOver)
            {
                InitGrid(ref grid);
                gameOver = false;
            }


        }
        static void explainGame()
        {
            Console.WriteLine("Welcome to Tic Tac Toe!");
            Console.WriteLine("Players take turns placing their marks (X or O) on a 3x3 grid.");
            Console.WriteLine("The first player to get three of their marks in a row (horizontally, vertically, or diagonally) wins the game.");
            Console.WriteLine("If all nine boxes are filled and no player has three in a row, the game ends in a draw.");
            Console.WriteLine("To make a move, enter a number between 1 and 9 corresponding to the box you want to fill:");
            Console.WriteLine(" 1 | 2 | 3 ");
            Console.WriteLine("-----------");
            Console.WriteLine(" 4 | 5 | 6 ");
            Console.WriteLine("-----------");
            Console.WriteLine(" 7 | 8 | 9 ");
            Console.Write("Let's start the game! (Press any key to continue...)");
            Console.ReadKey(); // Wait for user input
            Console.Clear();
        }
    }
}