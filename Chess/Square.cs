using System;

namespace Chess
{
    public class Square
    {
        private int _x;
        private int _y;
        public bool Occupied { get; set; }
        public string Location { get; set; }

        public Square(int i, int j)
        {
            _x = i;
            _y = j;
        }

        public int X {
            get { return _x; }
            set { _x = value; }
        }

        public int Y {
            get { return _y; }
            set { _y = value; }
        }

        public void SetCoords(int i, int j)
        {
            _x = i;
            _y = j;
        }
    }
}
