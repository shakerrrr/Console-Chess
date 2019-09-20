using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace Console_Chess
{
    class Pawn : Piece
    {
        public Pawn(Point pos, Color color)
        {
            this.pos = pos;
            this.color = color;
            this.type = PieceType.PAWN;
        }

        public override bool isValidPath(Point endPos, List<Piece> pieces)
        {
            if(this.color == Piece.Color.WHITE)
            {
                if (this.pos.Y == 2)
                {
                    if (endPos.Y == this.pos.Y + 1 && endPos.X == this.pos.X || endPos.Y == this.pos.Y + 2 && endPos.X == this.pos.X)
                    {
                        return true;
                    }
                }
                if(this.pos.Y + 1 == endPos.Y && this.pos.X + 1 == endPos.X || this.pos.Y + 1 == endPos.Y && this.pos.X - 1 == endPos.X)
                {
                    foreach(Piece piece in pieces)
                    {
                        if (piece.pos.Equals(endPos))
                        {
                            return true;
                        }
                    }
                }
                if(this.pos.Y + 1 == endPos.Y && this.pos.X == endPos.X)
                {
                    bool occupied = false;
                    foreach(Piece piece in pieces)
                    {
                        if (piece.pos.Equals(endPos))
                        {
                            occupied = true;
                        }
                    }
                    if (!occupied)
                    {
                        return true;
                    }
                }
            }
            if (this.color == Piece.Color.BLACK)
            {
                if (this.pos.Y == 7)
                {
                    if (endPos.Y == this.pos.Y - 1 && endPos.X == this.pos.X || endPos.Y == this.pos.Y - 2 && endPos.X == this.pos.X)
                    {
                        return true;
                    }
                }
                if (this.pos.Y - 1 == endPos.Y && this.pos.X - 1 == endPos.X || this.pos.Y - 1 == endPos.Y && this.pos.X + 1 == endPos.X)
                {
                    foreach (Piece piece in pieces)
                    {
                        if (piece.pos.Equals(endPos))
                        {
                            return true;
                        }
                    }
                }
                if (this.pos.Y - 1 == endPos.Y && this.pos.X == endPos.X)
                {
                    bool occupied = false;
                    foreach (Piece piece in pieces)
                    {
                        if (piece.pos.Equals(endPos))
                        {
                            occupied = true;
                        }
                    }
                    if (!occupied)
                    {
                        return true;
                    }
                }
            }

            return false;
        }
    }
}
