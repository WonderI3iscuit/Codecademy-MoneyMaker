using System;

namespace MoneyMaker
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Money Maker!");

            Console.WriteLine("Enter an ammount you want to convert to coins: ");
    
      string totalAsString = Console.ReadLine();
            Console.WriteLine(totalAsString);

      double total = Convert.ToDouble(totalAsString);

            Console.WriteLine($"{total} is equal to...");


            int goldValue = 10;
            int silverValue = 5;

            double goldCoins = Math.Floor(total / goldValue);
            double remainder = total % goldValue;
            Console.WriteLine(goldCoins);
            Console.WriteLine(remainder);


            double silverCoins = Math.Floor(total / silverValue);
            double silverRemainder = total % silverValue;
            Console.WriteLine(silverCoins);
            Console.WriteLine(silverRemainder );


            Console.WriteLine($"gold coins: {goldCoins}");
            Console.WriteLine($"silver coins: {silverCoins}");
            Console.WriteLine($"bronze coins: {remainder}");
        }
    }
}
