using System;
namespace Chess
{
    public class Piece
    {
        private string StartLocation { get; set; }
        private string CurrentLocation { get; set; }

        public Piece()
        {
            CurrentLocation = StartLocation;
        }
        public void Move(int x, int y) {
            //CurrentLocation = Chess.ChessBoard[x][y];
        }
    }

    //public class Pawn : Piece
    //{
    //    public void Move(int x, int y)
    //    {
    //        CurrentLocation = Chess.ChessBoard[x][y];
    //    }

    //}
}
