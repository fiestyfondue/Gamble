using System;

namespace Gamble
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Gamble Game");
            //const int STAKE = 100;
            //const int BET = 1;
            GambleGame();

        }
        public static void GambleGame()
        {
            const int WIN = 0;
            const int LOSE = 1;
            Random random = new Random();
            int game = random.Next(0, 2);
            if (game == WIN)
            {
                Console.WriteLine("gambler wins!");
            }
            if (game == LOSE)
            {
                Console.WriteLine("gambler lose!");
            }

        }

    }
}

