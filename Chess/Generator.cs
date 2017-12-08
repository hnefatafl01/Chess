using System;
using System.Collections.Generic;

namespace Chess
{
    public class Generator : IPieceFactory
    {
        public void SetPieces(String pieceName, Dictionary<string, Piece> p, Board b, int N)
        {
            for (int i = 0; i < N; i++)
            {
                string wpk = "wp" + i;
                string bpk = "bp" + i;
                Pawn wpv = new Pawn { Color = "white", Coords = b.BoardLayout[1, i] };
                wpv.GenerateMoves();
                p.Add(wpk, wpv);

                Pawn bpv = new Pawn { Color = "black", Coords = b.BoardLayout[6, i] };
                p.Add(bpk, bpv);
                bpv.GenerateMoves();
            }
            foreach (KeyValuePair<string, Piece> kvp in p)
            {
                Console.WriteLine("Key = {0}, Value = {1}",
                kvp.Key, kvp.Value);
            }
        }
    }
}
