using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Constructor_Overloading
{
    public class MedicalAppointment
    {
        private string _patientName;
        private DateTime _date;

        public MedicalAppointment(string patientName, DateTime date)
        {
            _patientName = patientName;
            _date = date;
        }

        //Using the Optional Parameter feature to allow a default value for days from now.
        //Firstly, we can call it providing two parameters with any number of days we want here.
        //So it will behave the same as this constructor did.
        //Alternatively, we can skip the second parameter and in this case, the default value of 7 will
        //be used. This will give us the same behavior as this old constructor.
        //We can use optional parameters with any method, not only the constructor.
        public MedicalAppointment(string patientName, int daysFormNow = 7)
        {
            _patientName = patientName;
            _date = DateTime.Now.AddDays(daysFormNow);
        }

        public void Rechedule(DateTime date)
        {
            _date = date;
        }


    }
}
