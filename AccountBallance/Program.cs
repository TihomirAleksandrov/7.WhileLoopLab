using System;

namespace AccountBallance
{
    class Program
    {
        static void Main(string[] args)
        {
            double sum = 0;

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "NoMoreMoney")
                {
                    break;
                }

                double num = double.Parse(input);

                if (num < 0)
                {
                    Console.WriteLine("Invalid operation!");
                    break;
                }
                else
                {
                    sum += num;
                    Console.WriteLine($"Increase: {num:f2}");
                }
            }

            Console.WriteLine($"Total: {sum:f2}");
        }
    }
}
