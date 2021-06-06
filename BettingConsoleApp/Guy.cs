using System;
namespace BettingConsoleApp
{
    public class Guy
    {
        public string Name;
        public int Cash;

        public Guy()
        {
        }

        /// <summary>
        /// Writes my name and the amount of cash I have to the console.
        /// </summary>
        public void WriteMyInfo()
        {
            Console.WriteLine($"{Name} has {Cash} bucks.");
        }

        /// <summary>
        /// Gives some of my cash and removes it from my wallet (or prints
        ///  a message to the console if I dont have enough cash).
        /// </summary>
        /// <param name="amount">Amount of cash to give.</param>
        /// <returns>The amount of cash removed from my wallet or 0 if I
        ///  dont have enough or the amount is invalid.</returns>
        public int GiveCash(int amount)
        {
            if(amount <= 0)
            {
                Console.WriteLine($"{Name} says: {amount} isn't a valid amount.");
                return 0;
            }
            if(amount > Cash)
            {
                Console.WriteLine($"{Name} says: I dont have enough cash to give you {amount}.");
                return 0;
            }
            Cash -= amount;
            WriteMyInfo();
            return amount;
        }

        /// <summary>
        /// Receive some cash, adding it to my wallet (if amount is invalid
        /// print a message to the console).
        /// </summary>
        /// <param name="amount">Amount of cash to tive.</param>
        public void ReceiveCash(int amount)
        {
            if(amount <=0)
            {
                Console.WriteLine($"{Name} says: {amount} isnt an amount I'll take");
            }
            else
            {
                Cash += amount;
                WriteMyInfo();
            }
        }
    }
}
