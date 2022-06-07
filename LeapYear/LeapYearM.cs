using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeapYear
{
    internal class LeapYearM
    {
        public static int Year;
        public static void checkYearInput()
        {
            Console.WriteLine("Enter any Yaer");
            Year = Convert.ToInt32(Console.ReadLine());
            if (Year / 1000 != 0 && Year / 1000 < 10)
            {
                Console.WriteLine("Entered number is 4 digit number");
            }
            else
            {
                Console.WriteLine("Enterd number is not 4 digit number");
            }
        }
        public static void YearMethod()
        {
            Console.WriteLine();
            Console.WriteLine("Leap Year Program");
            checkYearInput();
           if (Year / 1000 !=0 && Year / 1000 < 10)
           {
                if (((Year % 4 == 0) && (Year % 100 != 0)) || (Year % 400 == 0))
                {
                    Console.WriteLine("{0} leap year", Year);
                }
           }
           else
           {
                Console.WriteLine(("{0} is not a leap year", Year));
           }
            Console.WriteLine("Leap year endass");

        }
    }
}
