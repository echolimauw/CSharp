using System;

namespace puzzles
{
    public class Program
    {
        static void Main(string[] args)
        {
            RandomArray();
            TossCoin();
            TossMultipleCoins(7);
        }
        public static void RandomArray()
        {
            
            Random rand = new Random();
            int [] TheArray = new int[10];
            for (int i = 0; i < TheArray.Length; i++)
            {
                TheArray[i] = rand.Next(5,25);
                Console.WriteLine(TheArray[i]);
                
            }
            int n = TheArray.Length;
            int mx = TheArray[0];
            int min = TheArray[0];
            for (int i = 0; i < n; i++)
            {
                if (TheArray[i]>mx)
                {
                    mx = TheArray[i];
                }
                if (TheArray[i]<min)
                {
                    min = TheArray[i];
                }                
            }
            Console.WriteLine($"Maximum element = {mx}");
            Console.WriteLine($"Minimum element = {min}");
            int sum = 0;
            for (int i = 0; i < n; i++)
            {
                sum = sum + TheArray[i];
            }
            Console.WriteLine($"Sum of all elements = {sum}");
        }
        public static string TossCoin()
        {
            Random rand = new Random();
            Console.WriteLine("Tossing a coin!");
            int toss = rand.Next(1,3);
            string coinface = "";
            if (toss == 1)
            {
                coinface = "Tails";
                Console.WriteLine($"{coinface}");
            }
            if (toss == 2)
            {
                coinface = "Heads";
                Console.WriteLine($"{coinface}");
            }
            return coinface;
        }
        public static double TossMultipleCoins(int num)
        {
            Random rand = new Random();
            Console.WriteLine($"Tossing coins! {num} flips.");
            string coinface = "";
            int heads = 0;
            for (int i = 1; i < num; i++)
            {
                int thistoss = rand.Next(1,3);
                System.Console.WriteLine($"thistoss = {thistoss}");
                if (thistoss == 1)
                {
                    coinface = "Tails";
                    Console.WriteLine($"{coinface}");
                }
                if (thistoss == 2)
                {
                    coinface = "Heads";
                    Console.WriteLine($"{coinface}");
                    heads = heads + 1;
                }
            }
            double doubleHeads = (double) heads;
            double doubleNum = (double) num;
            double ratio = (double) heads/num;
            Console.WriteLine($"Number of heads: {heads}");
            Console.WriteLine($"Ratio of Heads outcomes: {ratio}");
            return ratio;
        }
        
    }
}
