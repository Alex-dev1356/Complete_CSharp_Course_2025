using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace ObjectOrientedProgramming
{
    public class OOP_DateTimeType
    {
        //public OOP_DateTimeType()
        //{
        //   
        //    DateTime internationalPizzaDay2023;
        //}

        public DateTime DateTime()
        {
           /*
           Constructor used specifically to create new class instances. We'll learn more about constructors later in the course.
           In this case, the constructor takes three integer parameters: the year, month, and the day of the date
           we want to represent. We could also pass more parameters representing hours, minutes, seconds,etc.
           */
            var internationalPizzaDay2023 = new DateTime(2023, 2, 9); 

            return internationalPizzaDay2023;
        }

        //Add Years Method
        public DateTime AddYears(DateTime date, int years)
        {
            var newDate = date.AddYears(years);
            return newDate;
        }
        
    }
}
