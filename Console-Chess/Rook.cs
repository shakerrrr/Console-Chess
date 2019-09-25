using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace Console_Chess
{
    class Rook : Piece
    {
        public Rook(Point pos, Color color)
        {
            this.pos = pos;
            this.color = color;
            this.type = PieceType.ROOK;
        }

        public override bool isValidPath(Point endPos, List<Piece> pieces)
        {
            if (pos.X == endPos.X || pos.Y == endPos.Y)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
