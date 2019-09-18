using System;

namespace Console_Chess
{
    class Program
    {
        static void Main(string[] args)
        {
            Board game = new Board();
            game.CreatePieces();
            game.UpdateDraw();
            Console.ReadKey();
        }
    }
}
