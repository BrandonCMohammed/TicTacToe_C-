using System;

namespace TikTacToe

{

    class Program

    {

        static void Main(string[] args)

        {


            gameLoop();

            // game.Start();
            // Console.WriteLine("Welcome to Tic Tac Toe!");




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
            }
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
            for (int i = 0; i < 3; i++)
            {
                // Check rows
                if (grid[i, 0] == grid[i, 1] && grid[i, 1] == grid[i, 2] && grid[i, 0] != ' ')
                {
                    drawGrid(ref grid);
                    Console.WriteLine("Player " + grid[i, 0] + " wins!");
                    gameOver = true;
                }
                // Check columns
                if (grid[0, i] == grid[1, i] && grid[1, i] == grid[2, i] && grid[0, i] != ' ')
                {
                    drawGrid(ref grid);
                    Console.WriteLine("Player " + grid[0, i] + " wins!");
                    gameOver = true;

                }

                if (grid[0, 0] == grid[1, 1] && grid[1, 1] == grid[2, 2] && grid[0, 0] != ' ')
                {
                    drawGrid(ref grid);
                    Console.WriteLine("Player " + grid[0, 0] + " wins!");
                    gameOver = true;

                }

                if (grid[0, 2] == grid[1, 1] && grid[1, 1] == grid[2, 0] && grid[0, 2] != ' ')
                {
                    drawGrid(ref grid);
                    Console.WriteLine("Player " + grid[0, 2] + " wins!");
                    gameOver = true;

                }
            }

        }
    }
}