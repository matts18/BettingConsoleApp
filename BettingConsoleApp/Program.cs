using System;

namespace BettingConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            double odds = 0.75;
            Guy player = new Guy() { Name = "The Player", Cash = 100 };

            Console.WriteLine($"Welcome to the casino. The odds are {odds}");
            player.WriteMyInfo();

            while (player.Cash > 0)
            {
            Console.Write("How much do you want to bet? ");
            string howMuch = Console.ReadLine();

            if(int.TryParse(howMuch,out int amount))
            {
                var pot = player.GiveCash(amount) * 2;

                if(pot > 0)
                    {

                if(random.NextDouble() > odds)
                {
                        Console.WriteLine($"You win: ${pot}");
                    player.ReceiveCash(pot);
                }
                else
                {
                        Console.WriteLine("Bad luck, you lose.");
                }
                    }
                    pot = 0;
                
            }

            }
        }
    }
}
