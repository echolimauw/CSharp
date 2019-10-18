using System;

namespace fundamentals_I
{
    class Program
    {
        static void Main(string[] args)
        {
            // for (int i = 1; i <= 255; i++)
            // {
            //     Console.WriteLine(i);
            // }
            // for (int i = 1; i <= 100; i++)
            // {
            //     if (i%3 == 0 && i%5 != 0)
            //     {
            //     Console.WriteLine(i);
            //     }
            //     if (i%3 != 0 && i%5 == 0)
            //     {
            //     Console.WriteLine(i);
            //     }
            for (int i = 1; i <= 100; i++)
            {
                if (i%3 == 0 && i%5 != 0)
                {
                Console.WriteLine("Fizz");
                }
                if (i%3 != 0 && i%5 == 0)
                {
                Console.WriteLine("Buzz");
                }
            }
        }
    }
}
