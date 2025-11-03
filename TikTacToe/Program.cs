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
            InitGrid(ref grid);


            while (true)
            {
                drawGrid(ref grid);
                playerAlternater(turnCounter, ref player);
                Console.Write("Player " + player + ", select a box (1-9): ");
                boxPositionChecker(ref box);

                Console.WriteLine("You selected box: " + box);
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

        static void boxPositionChecker(ref int box)
        {
            box = Convert.ToInt32(Console.ReadLine());
            while (true)
            {
                if (box >= 1 && box <= 9)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid box. Please select a box (1-9): ");
                    box = Convert.ToInt32(Console.ReadLine());
                }
            }



        }
    }
}