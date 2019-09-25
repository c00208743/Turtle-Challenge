using System;
using Library.GameObj;

namespace TurtleChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            var game = Game.CreateNewGame();
            game.Start();
        }
    }
}
