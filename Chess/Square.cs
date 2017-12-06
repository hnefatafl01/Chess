using System;
namespace Chess
{
    public class Square
    {
        public int X { get; set; }
        public int Y { get; set; }
        public bool Occupied { get; set; }
        public Chess.Piece Piece { get; set; }
        public string Location { get; set; }
    }
}
