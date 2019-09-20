using System;
using System.Drawing;

namespace Console_Chess
{
    class Program
    {
        static Board game;
        static void Main(string[] args)
        {
            mainMenu();
            Console.ReadKey();
        }

        static void runGame()
        {
            Console.Clear();
            game.UpdateDraw();

            string[] input = Console.ReadLine().Split(' ');
            switch (input[0])
            {
                case "move":
                    movePiece(input[1], input[2], game);
                    break;
                case "ff":
                    Console.Clear();
                    mainMenu();
                    break;
                default:
                    break;
            }
        }

        static void movePiece(string originString, string destinationString, Board game)
        {
            int originX = 404;
            int originY = 404;
            int destinationX = 404;
            int destinationY = 404;

            if (originString.Substring(0, 1).Equals("A", StringComparison.InvariantCultureIgnoreCase))
            {
                originX = 1;
            }
            if (originString.Substring(0, 1).Equals("B", StringComparison.InvariantCultureIgnoreCase))
            {
                originX = 2;
            }
            if (originString.Substring(0, 1).Equals("C", StringComparison.InvariantCultureIgnoreCase))
            {
                originX = 3;
            }
            if (originString.Substring(0, 1).Equals("D", StringComparison.InvariantCultureIgnoreCase))
            {
                originX = 4;
            }
            if (originString.Substring(0, 1).Equals("E", StringComparison.InvariantCultureIgnoreCase))
            {
                originX = 5;
            }
            if (originString.Substring(0, 1).Equals("F", StringComparison.InvariantCultureIgnoreCase))
            {
                originX = 6;
            }
            if (originString.Substring(0, 1).Equals("G", StringComparison.InvariantCultureIgnoreCase))
            {
                originX = 7;
            }
            if (originString.Substring(0, 1).Equals("H", StringComparison.InvariantCultureIgnoreCase))
            {
                originX = 8;
            }

            if (destinationString.Substring(0, 1).Equals("A", StringComparison.InvariantCultureIgnoreCase))
            {
                destinationX = 1;
            }
            if (destinationString.Substring(0, 1).Equals("B", StringComparison.InvariantCultureIgnoreCase))
            {
                destinationX = 2;
            }
            if (destinationString.Substring(0, 1).Equals("C", StringComparison.InvariantCultureIgnoreCase))
            {
                destinationX = 3;
            }
            if (destinationString.Substring(0, 1).Equals("D", StringComparison.InvariantCultureIgnoreCase))
            {
                destinationX = 4;
            }
            if (destinationString.Substring(0, 1).Equals("E", StringComparison.InvariantCultureIgnoreCase))
            {
                destinationX = 5;
            }
            if (destinationString.Substring(0, 1).Equals("F", StringComparison.InvariantCultureIgnoreCase))
            {
                destinationX = 6;
            }
            if (destinationString.Substring(0, 1).Equals("G", StringComparison.InvariantCultureIgnoreCase))
            {
                destinationX = 7;
            }
            if (destinationString.Substring(0, 1).Equals("H", StringComparison.InvariantCultureIgnoreCase))
            {
                destinationX = 8;
            }

            int.TryParse(destinationString.Substring(1, 1), out destinationY);
            int.TryParse(originString.Substring(1, 1), out originY);
            Point origin = new Point(originX,originY);
            Point destination = new Point(destinationX, destinationY);

            bool killed = false;
            foreach (Piece piece in game.pieces)
            {
                if (piece.pos.Equals(origin))
                {
                    if (piece.isValidPath(destination))
                    {
                        foreach(Piece piece2 in game.pieces)
                        {
                            if (piece2.pos.Equals(destination))
                            {
                                killed = true;
                                game.outPiecses.Add(piece2);
                            }
                        }

                        piece.moveTo(destination);
                    }
                }
            }
            if (killed)
            {
                game.pieces.Remove(game.outPiecses[game.outPiecses.Count - 1]);
            }
            runGame();
        }

        static void mainMenu()
        {
            Console.Out.WriteLine("Console Chess MAIN MENU\n");
            Console.Out.WriteLine("Please select a menu option:");
            Console.Out.WriteLine("1. Start new game. | 2. Exit.");
            switch (Console.ReadLine())
            {
                case "1":
                    game = new Board();
                    game.CreatePieces();
                    runGame();
                    break;
                case "2":
                    Console.Clear();
                    Console.Out.WriteLine("Good bye...");
                    Environment.Exit(0);
                    break;
                default:
                    Console.Clear();
                    mainMenu();
                    break;
            }
        }
    }
}
