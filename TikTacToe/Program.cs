using System;

namespace TikTacToe

{

    class Program

    {

        static void Main(string[] args)

        {


            while (true)
            {
                int turnCounter = 0;
                char player = 'X';
                char[,] grid = new char[3, 3];
                int box = 0;
                InitGrid(ref grid);
                playerAlternater(turnCounter, ref player);
                Console.WriteLine("Player " + player + ", select a box (1-9): ");
                boxPositionChecker(ref box);

                Console.WriteLine("You selected box: " + box);
            }
            // Program.drawGrid();
            // Game game = new Game();

            // game.Start();
            // Console.WriteLine("Welcome to Tic Tac Toe!");




        }


        static void drawGrid()
        {
            Console.WriteLine("     |     |     ");
            Console.WriteLine("     |     |     ");
            Console.WriteLine("_____|_____|_____");
            Console.WriteLine("     |     |     ");
            Console.WriteLine("     |     |     ");
            Console.WriteLine("_____|_____|_____");
            Console.WriteLine("     |     |     ");
            Console.WriteLine("     |     |     ");
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
                    grid[i, j] = '_';
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