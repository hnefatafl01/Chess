using System;
using System.Collections.Generic;

namespace Chess
{
    public interface IPieceFactory
    {
        void SetPieces(String pieceName, IDictionary<string, Piece> p, Board b, int N);
    }

}