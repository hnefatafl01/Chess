using System;
using System.Collections.Generic;

namespace Chess
{
    public class Generator : IPieceFactory
    {
        public void SetPieces(String pieceName, IDictionary<string, Piece> p, Board b, int N)
        {
            switch (pieceName) {
                case "Pawn":
                    for (int i = 0; i < N; i++)
                    {
                        string wpk = "wp" + i;
                        string bpk = "bp" + i;
                        //Console.WriteLine(b.BoardLayout[1, i].Location);
                        //string wpk = b.BoardLayout[1, i].Location;
                        //string bpk = b.BoardLayout[6, i].Location;

                        Pawn wpv = new Pawn { Color = "white", Coords = b.BoardLayout[1, i] };
                        wpv.GenerateMoves();
                        p.Add(wpk, wpv);
                        b.BoardLayout[1, i].Occupied = true;

                        Pawn bpv = new Pawn { Color = "black", Coords = b.BoardLayout[6, i] };
                        bpv.GenerateMoves();
                        p.Add(bpk, bpv);
                        b.BoardLayout[6, i].Occupied = true;
                    }
                    break;
            }

            /* test access to Moves */
            //foreach (KeyValuePair<string, Piece> kvp in p)
            //{
            //    Console.WriteLine(kvp.Key);
            //    for (int j = 0; j < kvp.Value.Moves.Length; j++) 
            //    {
            //        //Console.WriteLine("Key = {0}, Value = {1}, Moves = {2}", kvp.Key, kvp.Value, kvp.Value.Moves);
            //        //Console.WriteLine(kvp.Value.Moves[j].Y);
            //    }
            //}
        }
    }

}
