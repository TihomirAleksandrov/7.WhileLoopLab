using System;

namespace MinNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int minNum = int.MaxValue;

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "Stop")
                {
                    break;
                }

                int num = int.Parse(input);

                if (num < minNum)
                {
                    minNum = num;
                }
            }

            Console.WriteLine(minNum);
        }
    }
}
