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
        }
    }
}
