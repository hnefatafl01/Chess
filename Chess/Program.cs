using System;
using System.Collections.Generic;

namespace Chess
{
    class Program
    {
        static void Main(string[] args)
        {
            Board board = new Board();
            Dictionary <string, Piece> pieces = new Dictionary<string, Piece>();
            Generator pawns = new Generator();
            pawns.SetPieces("Pawn", pieces, board, 8);

            //Console.WriteLine($"color:{wp1.Color} x{wp1.Coords.X}, y{wp1.Coords.Y}", wp1.Color, wp1.Coords.X, wp1.Coords.Y);

            
            //test print populated board
            //for (int i = 0; i < 8; i++) {
            //    for (int j = 0; j < 8; j++) {
            //      //Console.WriteLine(board.BoardLayout[i, j]);
            //        if (board.BoardLayout[i ,j] == wp8.Coords) {
            //            Console.WriteLine($"found wp1 {board.BoardLayout[i, j].X} {board.BoardLayout[i, j].Y}", board.BoardLayout[i, j].X, board.BoardLayout[i, j].Y);
            //        }
            //        if (board.BoardLayout[i, j] == bp8.Coords)
            //        {
            //            Console.WriteLine($"found bp1 {board.BoardLayout[i, j].X} {board.BoardLayout[i, j].Y}", board.BoardLayout[i, j].X, board.BoardLayout[i, j].Y);
            //        }
            //    }
            //}

        }
    }
}
