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
                    runGame();
                    break;
            }
        }

        static int getCorrespondingNumber(String ch)
        {
            if (ch.Equals("A", StringComparison.InvariantCultureIgnoreCase))
            {
                return 1;
            }
            else if (ch.Equals("B", StringComparison.InvariantCultureIgnoreCase))
            {
                return 2;
            }
            else if (ch.Equals("C", StringComparison.InvariantCultureIgnoreCase))
            {
                return 3;
            }
            else if (ch.Equals("D", StringComparison.InvariantCultureIgnoreCase))
            {
                return 4;
            }
            else if (ch.Equals("E", StringComparison.InvariantCultureIgnoreCase))
            {
                return 5;
            }
            else if (ch.Equals("F", StringComparison.InvariantCultureIgnoreCase))
            {
                return 6;
            }
            else if (ch.Equals("G", StringComparison.InvariantCultureIgnoreCase))
            {
                return 7;
            }
            else
            {
                return 8;
            }
        }

        static void movePiece(string originString, string destinationString, Board game)
        {
            int originX = getCorrespondingNumber(originString.Substring(0, 1));
            int originY;
            int destinationX = getCorrespondingNumber(destinationString.Substring(0, 1)); ;
            int destinationY;

            int.TryParse(destinationString.Substring(1, 1), out destinationY);
            int.TryParse(originString.Substring(1, 1), out originY);
            Point origin = new Point(originX,originY);
            Point destination = new Point(destinationX, destinationY);

            bool killed = false;
            foreach (Piece piece in game.pieces)
            {
                if (piece.pos.Equals(origin))
                {
                    if (piece.isValidPath(destination, game.pieces))
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
