using System;

namespace TheUniqueNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How old are you?");
            int YourAgeAfter10Years = int.Parse(Console.ReadLine());
            YourAgeAfter10Years = YourAgeAfter10Years + 10;
            Console.WriteLine("Enter the last 4 digits of your faculty number here:");
            int YourFacultyNumberLast4Digits = int.Parse(Console.ReadLine());
            double  uniqueNumber = (YourAgeAfter10Years * YourFacultyNumberLast4Digits )/ Math.PI;
            Console.WriteLine("After 10 years you will be {0} years old. And you unique number is {1}.", YourAgeAfter10Years, uniqueNumber);
        }
    }
}
