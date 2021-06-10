using System;

namespace Gamble
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Gambler Simulation");
            Resign game = new Resign();
            game.Gambler(50);
        }
           

    }
}

