using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schach.Pieces
{
    public class Dame : Piece
    {

        public Dame(bool isblack): base(isblack, "Dame")
        {
        }

        public override bool IsPatternValid(Tile start, Tile end, Tile[] tiles)
        {
            return true;
        }
    }
}
