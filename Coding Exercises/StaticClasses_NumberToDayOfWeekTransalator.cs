using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coding_Exercises
{
    public static class StaticClasses_NumberToDayOfWeekTransalator
    {
        /*
            Implement the static NumberToDayOfWeekTranslator class that can be used like this:
            The Translate method should take a number and return a string with the name of the 
            day of the week, according to the following:

            for 1, "Monday" is returned

            for 2, "Tuesday" is returned

            ...

            for 7, "Sunday" is returned

            for any other number, "Invalid day of the week" is returned
        */


        public static string Translate(int number) => number switch
        {
            1 => "Monday",
            2 => "Tuesday",
            3 => "Wednesday",
            4 => "Thursday",
            5 => "Friday",
            6 => "Saturday",
            7 => "Sunday",
            _ => "Invalid day of the week"
        };
    }
}
