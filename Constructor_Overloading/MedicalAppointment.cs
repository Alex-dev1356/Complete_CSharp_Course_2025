using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public MedicalAppointment(string patientName, int daysFormNow)
        {
            _patientName = patientName;
            _date = DateTime.Now.AddDays(daysFormNow);
        }

        //public MedicalAppointment(string patientName)
        //{
        //    _patientName = patientName;
        //    _date = DateTime.Now.AddDays(7);
        //}

        //Using the 'this' keyword to call one constructor from another constructor.
        public MedicalAppointment(string patientName) : 
            this(patientName, 7)
        {
        }

        public void Rechedule(DateTime date)
        {
            _date = date;
        }


    }
}
