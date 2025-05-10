using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coding_Exercises
{
    public class StringInterpolation_FormatDate
    {
        /*
        String interpolation - FormatDate

        Using string interpolation, implement the FormatDate method, which given three integers representing the year, 
        month and day shall return a string in the format YEAR/MONTH/DAY.

        For example:

        for the year 2022, month 10, and day 29, it shall return "2022/10/29"
        for the year 1911, month 1, and day 5, it shall return "1911/1/5"
        */

        public static string FormatDate(int year, int month, int day)
        {
            return $"{year}/{month}/{day}";
        }
    }
}
