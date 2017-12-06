using System;

namespace Chess
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Chess.Board board = new Board();
            for (int i = 0; i < 8; i++) {
                for (int j = 0; j < 8; j++) {
                    //Console.WriteLine(board.BoardLayout[i, j].Location);
                }
            }
        }
    }
}
