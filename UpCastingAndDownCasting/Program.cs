namespace UpCastingAndDownCasting
{
    public class Program
    {
        static void Main(string[] args)
        {
            var person = new Person() { Name = "Alex" };

            var student = new Student() { StudentId = 1, Name = "Allen" };

            //UpCasting - Casting from a Derived class to a Base class
            Person upCastedPerson = student as Person; // This will assign student to upCastedPerson since Student is a Person


            //DownCasting - Casting from a Base class to a Derived class
            Student? downCastedStudent = person as Student; // Casting the person to a derived class Student
                                                            // This will assign null to downCastedStudent since person is not a Student

        }
    }

    public class Person
    {
        public string Name { get; set; }
    }

    public class Student : Person
    {
        public int StudentId { get; set; }
    }
}
