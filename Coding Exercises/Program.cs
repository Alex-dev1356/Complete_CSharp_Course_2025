using System.Threading;

namespace Coding_Exercises
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //String Interpolation - Format Date
            Console.WriteLine(StringInterpolation_FormatDate.FormatDate(2025, 05, 11));

            //Switch Statement - Describe Day
            Console.WriteLine(SwitchStatement_DescribeDay.DescribeDay(1));

            //While Loop - Calculate Sum of Numbers Between
            Console.WriteLine(WhileLoop_CalculateSumOfNumbersBetween.CalculateSumOfNumbersBetween(5, 10));

            //Do While Loop - Repeat Character
            Console.WriteLine(DoWhileLoop_RepeatCharacter.RepeatCharacter('a', 0));

            //For Loop - Factorial
            Console.WriteLine(ForLoop_Factorial.Factorial(5));

            //Arrays - Build Hello String
            Console.WriteLine(Arrays_BuildHelloString.BuildHelloString());

            //Arrays - Reverse Array
            Console.WriteLine(Arrays_IsWordPresentInCollection.IsWordPresentInCollection(new[] { "hello", "world" }, "helloooo"));

            //Multi-dimensional arrays - Find Max
            Console.WriteLine(MultiDimentionalArrays_FindMax.FindMax(new int[,] { { 1, 2, 3 }, { 4, 5, 6 } }));

            //Foreach loop - Is Any Word Longer Than
            Console.WriteLine(ForeachLoop_IsAnyWordLongerThan.IsAnyWordLongerThan(5, new[] { "hello", "world" }));

            //Lists - Get Only Upper Case Words
            foreach (var uperCaseWords in Lists_GetOlyUpperCaseWords.GetOnlyUpperCaseWords(new List<string> { "one", "TWO", "THREE", "THREE$&@", "TWO", "THREE" }))
            {
                Console.WriteLine(uperCaseWords);
            }
        
            //TryParse Method - Continue To Ask User For A Valid Input
            var tryParseMethod = new TryParseMethod_ContinueToAskUserForAValidInput();
            var result = tryParseMethod.ContinueToAskUserForAValidInput();
            Console.WriteLine($"Parsing successful: {result}");

            //OOP - Hotel Booking
            var hotelBooking = new OOP_HotelBooking("John Doe", new DateTime(2023, 10, 1), 5);
            Console.WriteLine("Hotel Booking: Name: {0}, Start Date: {1}, End Date: {2}", hotelBooking.GuestName, hotelBooking.StartDate, hotelBooking.EndtDate);

            //OOP - The Triangle Class
            var triangle = new OOP_TheTriangleClass(3, 5);
            Console.WriteLine("The Triangle: Base: {0}, Height: {1}, Area: {2}", triangle._base, triangle._height, triangle.CalculateArea());
            Console.WriteLine("Triangle Description: {0}", triangle.AsString());

            //OOP - Dog Class
            var dog = new OOP_DogClass("Rex", "Golden Retriever", 10);
            Console.WriteLine("Dog Description: {0}", dog.Describe());

            //Properties - PropertiesOfTheOrderClass
            var order = new Order("Shoes", DateTime.Now);
            Console.WriteLine("Order: Item: {0}, Date: {1}", order.Item, order.Date);

            //static classes - Number to Day of Week Translator
            Console.WriteLine(StaticClasses_NumberToDayOfWeekTransalator.Translate(1));

            // String_Split_And_String_Join_Methods - Transform Separators
            Console.WriteLine(String_Split_And_String_Join_Methods.TransformSeparators("a,b,c", ",", "-"));
        }
    }
}
