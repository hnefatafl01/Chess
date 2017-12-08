using System;

namespace Chess
{
    class Program
    {
        static void Main(string[] args)
        {
            Board board = new Board();

            // set peices manually
            // white //
            //pawns
            Pawn wp1 = new Pawn
            {
                Color = "white",
                Coords = board.BoardLayout[1, 0]
            };
            Pawn wp2 = new Pawn
            {
                Color = "white",
                Coords = board.BoardLayout[1, 1]
            };
            Pawn wp3 = new Pawn
            {
                Color = "white",
                Coords = board.BoardLayout[1, 2]
            };
            Pawn wp4 = new Pawn
            {
                Color = "white",
                Coords = board.BoardLayout[1, 3]
            };
            Pawn wp5 = new Pawn
            {
                Color = "white",
                Coords = board.BoardLayout[1, 4]
            };
            Pawn wp6 = new Pawn
            {
                Color = "white",
                Coords = board.BoardLayout[1, 5]
            };
            Pawn wp7 = new Pawn
            {
                Color = "white",
                Coords = board.BoardLayout[1, 6]
            };
            Pawn wp8 = new Pawn
            {
                Color = "white",
                Coords = board.BoardLayout[1, 7]
            };

            //Console.WriteLine($"color:{wp1.Color} x{wp1.Coords.X}, y{wp1.Coords.Y}", wp1.Color, wp1.Coords.X, wp1.Coords.Y);
            // black
            //pawns
            Pawn bp1 = new Pawn();
            bp1.Color = "black";
            bp1.Coords = board.BoardLayout[6, 0];

            Pawn bp2 = new Pawn();
            bp2.Color = "black";
            bp2.Coords = board.BoardLayout[6, 1];

            Pawn bp3 = new Pawn();
            bp3.Color = "black";
            bp3.Coords = board.BoardLayout[6, 2];

            Pawn bp4 = new Pawn();
            bp4.Color = "black";
            bp4.Coords = board.BoardLayout[6, 3];

            Pawn bp5 = new Pawn();
            bp5.Color = "black";
            bp5.Coords = board.BoardLayout[6, 4];

            Pawn bp6 = new Pawn();
            bp6.Color = "black";
            bp6.Coords = board.BoardLayout[6, 5];

            Pawn bp7 = new Pawn();
            bp7.Color = "black";
            bp7.Coords = board.BoardLayout[6, 6];

            Pawn bp8 = new Pawn();
            bp8.Color = "black";
            bp8.Coords = board.BoardLayout[6, 7];

            bp4.GenerateMoves();

            // print populated board
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
