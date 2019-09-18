using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace Console_Chess
{
    abstract class Piece
    {
        public enum PieceType { KING, QUEEN, BISHOP, KNIGHT, ROOK, PAWN };
        public enum Color { BLACK, WHITE };

        public Point pos;
        public Color color;
        public PieceType type;


        public abstract bool isValidPath(Point endPos);

        public PieceType getType()
        {
            return this.type;
        }
    }
}
