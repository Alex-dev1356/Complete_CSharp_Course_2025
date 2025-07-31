using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coding_Exercises
{
    public class OOP_HotelBooking
    {
        /*
        HotelBooking class
        Define a public HotelBooking class, which will contain the following fields that must be accessible outside of this class:
        GuestName (string)
        StartDate and EndDate (DateTimes)
        The constructor of this class should take the following parameters (please maintain the given order and names):
        guestName (string)
        startDate (DateTime)
        lengthOfStayInDays (int)
        The constructor should set all fields of this class.
        The EndDate should be calculated in the constructor as the StartDate plus the lengthOfStayInDays . You can use the AddDays 
        method from the DateTime type to calculate it. You can do it right in the constructor body.
        */

        public string GuestName = "";
        public DateTime StartDate = new DateTime();
        public DateTime EndtDate = new DateTime();

        public OOP_HotelBooking(string guestName, DateTime startDate, int lengthOfStayInDays)
        {
            GuestName = guestName;
            StartDate = startDate;
            EndtDate = startDate.AddDays(lengthOfStayInDays);
        }
    }
}
