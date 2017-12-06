using System;
namespace Chess
{
    public class Player
    {
        public string Color { get; set; }
        public int Id { get; set; }
        public Chess.Piece[] Pieces;
    }
}
