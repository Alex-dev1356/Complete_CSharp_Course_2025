namespace this_Keyword_for_Instance_of_Class
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Creating an instance of the MedicalAppointment class using the constructor that takes a patient name and a date.
            var medicalAppointment = new MedicalAppointment("John Doe", new DateTime(2023, 4, 3));

            //Let's say that after the appointment was rescheduled, we want to print the new date to the console.
            medicalAppointment.Rechedule(new DateTime(2023, 4, 10));
        }
    }

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
        //Using the 'this' keyword to call one constructor from another constructor.
        public MedicalAppointment(string patientName) : 
            this(patientName, 7)
        {
        }
        public void Rechedule(DateTime date)
        {
            _date = date;
            //We need to use the the MedicalAppointmentPrinter Class on this method to print the new date to the console.
            //And we use the 'this' keyword to refer to the current instance of the MedicalAppointment class.
            var printer = new MedicalAppointmentPrinter();
            printer.Print(this);
        }

        //Creating a public GetDate Method to access the private _date field.
        public DateTime GetDate() => _date;
    }

    //This class is responsible for printing the dates of the Appointments to the console.
    public class MedicalAppointmentPrinter
    {
        public void Print(MedicalAppointment medicalAppointment)
        {
            Console.WriteLine(
                "Appointment will take place on " + medicalAppointment.GetDate());
        }
    }
}
