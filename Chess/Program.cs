using System;
using System.Linq;
using System.Collections.Generic;

namespace Chess
{
    class Program
    {
        public static Piece value = null;
        public static Piece Selected;
        public static void SelectPiece(Square s, IDictionary<string, Piece> dict) 
        {
            Console.WriteLine(s.Occupied);
            if (!s.Occupied)
            {
                Console.WriteLine("Empty Square");
            } else {
                Console.WriteLine(s.Location);
                //var myKey = dict.FirstOrDefault(x => x.Value.Coords == s).Key;
                //Console.WriteLine($"myKey: {myKey}", myKey);
                //if (myKey)
                //{
                //    Selected = dict[myKey];
                //}
                //Console.WriteLine(Selected);
            }
        }

        static void Main(string[] args)
        {
            Board board = new Board();
            IDictionary <string, Piece> pieces = new Dictionary<string, Piece>();
            //pieces.Add("piece", new Piece());
            Generator pawns = new Generator();
            pawns.SetPieces("Pawn", pieces, board, 8);
            SelectPiece(board.BoardLayout[1, 1], pieces);
            //Console.WriteLine($"color:{wp1.Color} x{wp1.Coords.X}, y{wp1.Coords.Y}", wp1.Color, wp1.Coords.X, wp1.Coords.Y);
            
            //pieces.TryGetValue("wp1", out value);

            //Console.WriteLine(value.Coords.X);
            //test print populated board
            //for (int i = 0; i < 8; i++) {
            //    for (int j = 0; j < 8; j++) {
            //      //Console.WriteLine(board.BoardLayout[i, j]);
            //        if (board.BoardLayout[i ,j] == pawns["wp1"]) {
            //            Console.WriteLine($"found wp1 {board.BoardLayout[i, j].X} {board.BoardLayout[i, j].Y}", board.BoardLayout[i, j].X, board.BoardLayout[i, j].Y);
            //        }
            //        if (board.BoardLayout[i, j] == pawns["bp8"].Coords)
            //        {
            //            Console.WriteLine($"found bp1 {board.BoardLayout[i, j].X} {board.BoardLayout[i, j].Y}", board.BoardLayout[i, j].X, board.BoardLayout[i, j].Y);
            //        }
            //    }
            //}

        }
    }
}
