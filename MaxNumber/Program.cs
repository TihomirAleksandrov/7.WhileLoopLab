using System;

namespace MaxNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int maxNum = int.MinValue;

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "Stop")
                {
                    break;
                }

                int num = int.Parse(input);

                if (num > maxNum)
                {
                    maxNum = num;
                }
            }

            Console.WriteLine(maxNum);
        }
    }
}
