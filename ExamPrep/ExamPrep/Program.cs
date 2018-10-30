using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamPrep
{
    class Program
    {
        // 123 случайни числа [-100, 100] - gg easy
        // * на V числа в интервал [-20,20]
        // AVG на V числа > 0
        // SUM на V числа < 100
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int product = 1;
            int counter = 0;
            int sum = 0;
            int sum2 = 0;


            for (int i = 0; i < 123; i++)
            {
                int currentNumber = rnd.Next(-100, 101);

                if (currentNumber >= -20 && currentNumber <= 20)
                {
                    product *= currentNumber;
                    // product = product * currentNumber
                }

                if (currentNumber > 0)
                {
                    sum += currentNumber;
                    counter++;
                }

                if(currentNumber < 100)
                {
                    sum2 += currentNumber;
                }
            }

            Console.WriteLine($"Product: {product}");
            // Console.WriteLine("Product: {0}", product);

            if(counter > 0)
            {
                double avg = sum / counter;
                Console.WriteLine($"AVG: {avg}");
            }

            Console.WriteLine($"Sum 2: {sum2}");
            Console.ReadKey(true);
        }
    }
}
