using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        // N на брой числа, "end" за край -- gg easy
        // брой на числа, делящи се на 5 без остатък
        // AVG на всички четни числа
        // SUM ^2 на всички числа < 0
        static void Main(string[] args)
        {
            double counter = 0;
            double evenCounter = 0;
            double evenSum = 0;
            double lastSum = 0;
            while (true)
            {
                string input = Console.ReadLine();

                if (input == "end")
                {
                    break;
                }

                double currentNumber = double.Parse(input);

                if (currentNumber % 5 == 0)
                {
                    counter++;
                }

                if(currentNumber % 2 == 0)
                {
                    evenCounter++;
                    evenSum += currentNumber;
                }

                if(currentNumber < 0)
                {
                    double q = Math.Pow(currentNumber, 2);
                    lastSum += q;
                }
            }

            Console.WriteLine("Num of divisions: " + counter);
            if (evenCounter > 0)
            {
                double avg = evenSum / evenCounter;
                Console.WriteLine("AVG " + avg);
            }

            Console.WriteLine("Sum of n<0 " + lastSum);

            Console.ReadKey(true);
            
        }
    }
}
