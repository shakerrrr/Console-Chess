using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace Console_Chess
{
    class Board
    {
        public List<Piece> pieces = new List<Piece>();
        public List<Piece> outPiecses = new List<Piece>();

        public void CreatePieces()
        {
            for (int i = 0; i < 8; i++)
            {
                pieces.Add(new Pawn(new Point(i + 1, 2), Piece.Color.WHITE));
                pieces.Add(new Pawn(new Point(i + 1, 7), Piece.Color.BLACK));
            }

            pieces.Add(new Rook(new Point(1, 1), Piece.Color.WHITE));
            pieces.Add(new Rook(new Point(8, 1), Piece.Color.WHITE));
            pieces.Add(new Rook(new Point(1, 8), Piece.Color.BLACK));
            pieces.Add(new Rook(new Point(8, 8), Piece.Color.BLACK));

            pieces.Add(new Knight(new Point(2, 1), Piece.Color.WHITE));
            pieces.Add(new Knight(new Point(7, 1), Piece.Color.WHITE));
            pieces.Add(new Knight(new Point(2, 8), Piece.Color.BLACK));
            pieces.Add(new Knight(new Point(7, 8), Piece.Color.BLACK));

            pieces.Add(new Bishop(new Point(3, 1), Piece.Color.WHITE));
            pieces.Add(new Bishop(new Point(6, 1), Piece.Color.WHITE));
            pieces.Add(new Bishop(new Point(3, 8), Piece.Color.BLACK));
            pieces.Add(new Bishop(new Point(6, 8), Piece.Color.BLACK));

            pieces.Add(new Queen(new Point(4, 1), Piece.Color.WHITE));
            pieces.Add(new King(new Point(5, 1), Piece.Color.WHITE));
            pieces.Add(new Queen(new Point(4, 8), Piece.Color.BLACK));
            pieces.Add(new King(new Point(5, 8), Piece.Color.BLACK));
        }

        public void UpdateDraw()
        {
            for (int x = 0; x < 9; x++){
                for(int y = 0; y < 9; y++)
                {
                    if (x == 0)
                    {
                        switch (y)
                        {
                            case 0:
                                Console.Out.Write(" |");
                                break;
                            case 1:
                                Console.Out.Write("A|");
                                break;
                            case 2:
                                Console.Out.Write("B|");
                                break;
                            case 3:
                                Console.Out.Write("C|");
                                break;
                            case 4:
                                Console.Out.Write("D|");
                                break;
                            case 5:
                                Console.Out.Write("E|");
                                break;
                            case 6:
                                Console.Out.Write("F|");
                                break;
                            case 7:
                                Console.Out.Write("G|");
                                break;
                            case 8:
                                Console.Out.Write("H|");
                                break;
                        }
                    }
                    else if(y == 0)
                    {
                        switch (x)
                        {
                            case 1:
                                Console.Out.Write("1|");
                                break;
                            case 2:
                                Console.Out.Write("2|");
                                break;
                            case 3:
                                Console.Out.Write("3|");
                                break;
                            case 4:
                                Console.Out.Write("4|");
                                break;
                            case 5:
                                Console.Out.Write("5|");
                                break;
                            case 6:
                                Console.Out.Write("6|");
                                break;
                            case 7:
                                Console.Out.Write("7|");
                                break;
                            case 8:
                                Console.Out.Write("8|");
                                break;
                        }
                    }
                    else
                    {
                        bool occupied = false;
                        foreach(Piece piece in pieces)
                        {
                            if(piece.pos.X == y && piece.pos.Y == x)
                            {
                                if (piece.color.Equals(Piece.Color.BLACK))
                                {
                                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                                }
                                else if (piece.color.Equals(Piece.Color.WHITE))
                                {
                                    Console.ForegroundColor = ConsoleColor.White;
                                }
                                switch (piece.type)
                                {
                                    case Piece.PieceType.PAWN:
                                        Console.Out.Write("p");
                                        break;
                                    case Piece.PieceType.KNIGHT:
                                        Console.Out.Write("k");
                                        break;
                                    case Piece.PieceType.BISHOP:
                                        Console.Out.Write("b");
                                        break;
                                    case Piece.PieceType.ROOK:
                                        Console.Out.Write("r");
                                        break;
                                    case Piece.PieceType.QUEEN:
                                        Console.Out.Write("Q");
                                        break;
                                    case Piece.PieceType.KING:
                                        Console.Out.Write("K");
                                        break;
                                }
                                Console.ResetColor();
                                Console.Out.Write("|");
                                occupied = true;
                            }
                        }
                        if(!occupied)
                        {
                            Console.Out.Write(" |");
                        }
                    }
                    if(y == 8)
                    {
                        switch (x)
                        {
                            case 0:
                                Console.Write("          CONTROLS:");
                                break;
                            case 1:
                                Console.Write("          move [piece X][piece Y] [to X][to Y] (example : move a2 a4)");
                                break;
                            case 2:
                                Console.Write("          ff (quit the game and back to main menu)");
                                break;
                            default:
                                break;
                        }
                        Console.Write('\n');
                    }
                }
            }
        }
    }
}
