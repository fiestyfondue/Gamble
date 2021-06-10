using System;

namespace Gamble
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Gambling Game");
            const int Stake = 100;
            const int bet = 1;

            Console.Write("The gambler has " + Stake + "with him and he is ready to bet " + bet + "EveryDay ");
            Console.ReadLine();
        }
            
    }
}

