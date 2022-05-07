using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int minValue = 0;
            int maxValue = 101;
            Random random = new Random();
            int targetNumber = random.Next(minValue, maxValue);
            int foundation = 2;
            int degree = 1;

            for (int i = foundation; i < targetNumber; i *= foundation)
            {
                degree++;
            }
            Console.WriteLine($"минимальная степень: {degree}");
        }
    }
}
