using System;
using System.Collections.Generic;
using System.Text;

namespace Gamble
{
    class Resign
    {
        public const int Cash = 100;
        public const int BET = 1;
        public void Gambler(int Goal)
        {
            const int win = 0;
            const int Lose = 1;
            int loseMax = ((Cash / 100) * Goal) - Cash ;
            int winGoal = ((Cash / 100) * Goal) + Cash;
            int gamblerStake = Cash;
            Random random = new Random();
            int game;
            while (gamblerStake <= winGoal || gamblerStake == loseMax)
            {
                game = random.Next(0, 2);
                if (game == win)
                {
                    gamblerStake += BET;
                    Console.WriteLine("gambler wins and resign from the game");
                }
                else if (game == Lose)
                {
                    gamblerStake -= BET;
                    Console.WriteLine("Gambler Lost and will now resign ");
                }
                Console.WriteLine($"Cash left with gambler: {gamblerStake}");
            }
        }
    }
}
