using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class Program
    {
        // Н на брой числа, за край "енд" 
        // SUM числа > 200 или < -100
        // COunt negatives and count positive
        // SUM SQRT of positives
        static void Main(string[] args)
        {
            double sum = 0;
            int positives = 0;
            int negatives = 0;
            double sqrtSum = 0;
            while (true)
            {
                string input = Console.ReadLine();

                if(input == "end")
                {
                    break;
                }

                double currentNumber = double.Parse(input);

                if(currentNumber > 200 || currentNumber < -100)
                {
                    sum += currentNumber;
                }

                if( currentNumber > 0)
                {
                    positives++;
                }

                if(currentNumber < 0)
                {
                    negatives++;
                }

                if(currentNumber > 0)
                {
                    double sqrt = Math.Sqrt(currentNumber);
                    sqrtSum += sqrt;
                }
                
            }

            Console.WriteLine("SUM: " + sum);
            Console.WriteLine("POS: "  +positives);
            Console.WriteLine("NEG" + negatives);
            Console.WriteLine("SQRT SUM: " + sqrtSum);
        }
    }
}
