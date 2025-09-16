using ExtensionMethods.Extensions;

namespace ExtensionMethods
{
    public class Program
    {
        static void Main(string[] args)
        {
            string inputString = "Hello Extension Methods";
            int wordCount = ExtensionMethodBeforeCSharp14.WordCount(inputString);
            Console.WriteLine("The number of words is " + inputString.WordCount());


            //Declaring a multi line literal string
            var multiLineText = @"aaaa
                                bbbb
                                cccc
                                dddd";

            //Using the Extension method we created in the ExtensionMethods project
            Console.WriteLine("Count of lines is " + multiLineText.CountLines());

            //Another way of calling the extension method that we created
            Console.WriteLine("Count of lines is " + StringExtensions.CountLines(multiLineText));


            //For Enums, we wish that it should have a method like Next() so we will create another extension method for the enum type.
            Console.WriteLine("Next after spring is " + Season.Spring.Next());
            Console.WriteLine("Next after winter is " + Season.Winter.Next());


            //NOTE: It just allows us to use the same syntax as it belonged to the extended type.
            //We can actually call it like any other static method.
            //This line really shows that this method does not belong to the string class.
            //It belongs to the static StringExtension class.
            //But because it is an extension method, it allows us to use syntax like this.
            //Extension methods are very useful and allow us to add functionality to types that we don't have access to.
            //Extension methods have another great benefit.
            //They allow us to seemingly add methods to types that cannot have methods defined like enums.

        }
    }

    //Declaring Enums
    public enum Season
    {
        Spring, //0
        Summer, //1
        Autumn, //2
        Winter //3
    }

    //Declaring an extension Method before C# 14
    public static class ExtensionMethodBeforeCSharp14
    {
        public static int WordCount(this string str) =>
            str.Split([' ', '.', '?'], StringSplitOptions.RemoveEmptyEntries).Length;
    }

    //public static class MyExtensions
    //{
    //    extension(string str)
    //    {
    //        public int WordCount() =>
    //            str.Split([' ', '.', '?'], StringSplitOptions.RemoveEmptyEntries).Length;
    //    }
    //}

    //
}
