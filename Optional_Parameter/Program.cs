using Constructor_Overloading;

namespace Optional_Parameter
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Not Using the Optional Parameter
            var person1 = new MedicalAppointment("Alexander Soliven", 5);

            //Using the Optional Parameter
            var person2 = new MedicalAppointment("Alexander Soliven");
        }
    }
}
