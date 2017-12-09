using System;
namespace Chess
{
    public class Board
    {
        private readonly string[] column = { "a", "b", "c", "d", "e", "f", "g", "h" };
        private readonly string[] row = { "1", "2", "3", "4", "5", "6", "7", "8" };
        public Square[,] BoardLayout = new Square[8, 8];

        public Board()
        {
            for (int i = 0; i < column.Length; i++)
            {
                for (int j = 0; j < row.Length; j++)
                {
                    //Console.WriteLine(BoardLayout[i, j]);
                    BoardLayout[i, j] = new Square(i, j)
                    {
                        Location = column[i] + row[j]
                    };
                }
            }
        }
    }
}
