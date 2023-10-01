using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__10_Foundamentals_Practice
{
    internal class Utilities
    {
        public static int CalculateYearlyWage(int monthlyWage, int numberOfMonthsWorked)
        {
            if (numberOfMonthsWorked == 12)
                return monthlyWage * (numberOfMonthsWorked + 1);

            return monthlyWage * numberOfMonthsWorked;
        }



        public static int SubtractTwoNumbers(int a, int b)
        {
            return a - b;
        }


        public static int CalculateYearlyWage(int monthlyWage, bool giveBonus = true)
        {
            if (giveBonus)
            {
                return (monthlyWage * 12) + 1000;
            }
            else
            {
                return monthlyWage * 12;
            }

        }
    }

}
