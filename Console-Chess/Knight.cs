using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace Console_Chess
{
    class Knight : Piece
    {
        public Knight(Point pos, Color color)
        {
            this.pos = pos;
            this.color = color;
            this.type = PieceType.KNIGHT;
        }

        public override bool isValidPath(Point endPos, List<Piece> pieces)
        {
            throw new NotImplementedException();
        }
    }
}
