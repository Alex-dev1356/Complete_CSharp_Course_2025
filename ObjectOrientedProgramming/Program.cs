namespace ObjectOrientedProgramming
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //OOP_DateTimeType
            var dateTimeType = new OOP_DateTimeType();
            var internationalPizzaDay2023 =  new DateTime(2023, 2, 9);
            var differentCapabilitiesOfDateTimeType = dateTimeType.DateTime();

            Console.WriteLine("year is " + differentCapabilitiesOfDateTimeType.Year);
            Console.WriteLine("month is " + differentCapabilitiesOfDateTimeType.Month);
            Console.WriteLine("day is " + differentCapabilitiesOfDateTimeType.Day);
            //This is where the true power of object comes in. If we dont have this function
            //we would need to compute the day of the week from scratch.
            Console.WriteLine("day of the week is " + differentCapabilitiesOfDateTimeType.DayOfWeek);

            //Add Years Method
            var internationalPizzaDay2024 = dateTimeType.AddYears(internationalPizzaDay2023, 1);
            Console.WriteLine();
            Console.WriteLine("year is " + internationalPizzaDay2024.Year);
            Console.WriteLine("month is " + internationalPizzaDay2024.Month);
            Console.WriteLine("day is " + internationalPizzaDay2024.Day);
            Console.WriteLine("day of the week is " + internationalPizzaDay2024.DayOfWeek);
        }
    }
}
