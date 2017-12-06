using System;
namespace Chess
{
    public class Game
    {
        Chess.Player Player1 { get; set; }
        Chess.Player Player2 { get; set; }
        public Game()
        {
            Player1.Id = 1;
            Player1.Color = "Black";
            Player2.Id = 2;
            Player2.Color = "White";
        }
    }
}
