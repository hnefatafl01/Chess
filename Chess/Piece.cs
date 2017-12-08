using System;
using System.Collections.Generic;

namespace Chess
{
    public abstract class Piece 
    {
        protected Square Coords { get; set; }
        protected string Color { get; set; }
        public int direction; // -1 || 1
        public Square[] Moves;
        //protected Piece(string color, Square coords) 
        //{
        //    Color = color;
        //    Coords = coords;
        //}

        //public Square GetCoords() {
        //    return Coords;
        //}

        //public void SetCoords(Square s)
        //{
        //    Coords = s;
        //}

        //public void SetCoords(int x, int y) {
        //    Coords.X = x;
        //    Coords.Y = y;
        //}
    }

    public class Pawn : Piece
    {
        public new Square Coords { get; set; }
        public new string Color { get; set; }
		public new int direction;
        public new Square[] Moves = new Square[3];

        public void GenerateMoves() {
            //available moves for a pawn
            Square m1, m2, m3;
            if (this.Color == "white") {
                m1 = new Square(this.Coords.X + 1, this.Coords.Y - 1);
                m2 = new Square(this.Coords.X + 1, this.Coords.Y);
                m3 = new Square(this.Coords.X + 1, this.Coords.Y + 1);    
            } else {
                m1 = new Square(this.Coords.X - 1, this.Coords.Y - 1);
                m2 = new Square(this.Coords.X - 1, this.Coords.Y);
                m3 = new Square(this.Coords.X - 1, this.Coords.Y + 1);
            }

            Moves[0] = m1;
            Moves[1] = m2;
            Moves[2] = m3;

            foreach (Square m in Moves)
            {
                Console.WriteLine($"x: {m.X}, y: {m.Y}", m.X, m.Y);
            }
        }
    }
}
