using System;

namespace Gamble
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Gambling Game");
            int Stake = 100;
            int bet = 1;
            int Noofdays = 100;

            Console.Write("The gambler has " + Stake + "with him and he is ready to bet " + bet + "EveryDay for " + Noofdays + "days");
            Console.ReadLine();
        }
            
    }
}

