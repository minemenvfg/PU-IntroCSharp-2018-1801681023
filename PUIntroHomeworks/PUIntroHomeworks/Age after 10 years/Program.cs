using System;

namespace Age_after_10_years
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How old are you ? ");
            int AgeAfterTen = int.Parse(Console.ReadLine());
            Console.WriteLine("You will be {0} after 10 years",AgeAfterTen + 10 );
        }
    }
}
