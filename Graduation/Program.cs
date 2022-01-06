using System;

namespace Graduation
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int counter = 0;
            int repeatCounter = 0;
            double totalGrade = 0;
            double averageGrade = 0;

            while (counter < 12)
            {
                double grade = double.Parse(Console.ReadLine());

                if (grade < 4)
                {
                    repeatCounter++;
                }

                if (repeatCounter >= 2)
                {
                    Console.WriteLine($"{name} has been excluded at {counter} grade");
                    break;
                }

                counter++;

                totalGrade += grade;
            }

            if (counter == 12)
            {
                averageGrade = totalGrade / 12;
                Console.WriteLine($"{name} graduated. Average grade: {averageGrade:f2}");
            }
            
        }
    }
}
