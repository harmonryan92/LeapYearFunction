using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpClass
{
    class LeapYear
    {
        static void Main(string[] args)
        {
            do                  //put entire formula into a do-while so you can prompt the user if they want to check another year and keep going
            {

                int year;
                bool isDiv4, isDiv100, isDiv400;

                do
                {
                    Console.WriteLine("Enter a year to see if it was or will be a leap year:");
                } while (!int.TryParse(Console.ReadLine(), out year));

                isDiv4 = year % 4 == 0 ? true : false;
                isDiv100 = year % 100 == 0 ? true : false;
                isDiv400 = year % 400 == 0 ? true : false;

                if ((isDiv4 && isDiv100 && isDiv400) || (isDiv4 && !isDiv100 && !isDiv400))
                {
                    Console.WriteLine("\n{0} is a leap year.", year);
                }
                else
                {
                    Console.WriteLine("\n{0} is not a leap year.", year);
                }

                Console.WriteLine("\nWould you like to test another year? Type Y for yes or any other key to quit");

            } while (Console.ReadLine() == "Y");        //while set to check if Y was entered or not
        }
    }
}
