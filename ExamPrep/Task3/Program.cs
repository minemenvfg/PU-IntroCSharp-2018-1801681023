using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        // 321 случайни числа [-100, 100]'-- gg easy again
        // min и max число -- wp
        // SUM числата, делящи се на 3 без остатък
        // * на всички нечетни числа
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int min = 100;
            int max = -100;
            int sum = 0;
            int product = 1;
            for (int i = 0; i < 321; i++)
            {
                int currentNumber = rnd.Next(-100, 101);

                if(currentNumber < min)
                {
                    min = currentNumber;
                }

                if(currentNumber > max)
                {
                    max = currentNumber;
                }

                if(currentNumber % 3 == 0)
                {
                    sum += currentNumber;
                }

                if(currentNumber % 2 == 1)
                {
                    product *= currentNumber;
                }
            }

            Console.WriteLine("MIN " + min);
            Console.WriteLine("MAX" + max);
            Console.WriteLine("SUM of 3's " + sum);
            Console.WriteLine("PROD " + product);

            Console.ReadKey(true);
        }
    }
}
