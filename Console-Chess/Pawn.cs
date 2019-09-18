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

        public override bool isValidPath(Point endPos)
        {
            throw new NotImplementedException();
        }
    }
}
