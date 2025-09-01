namespace ExtensionMethods
{
    public class Program
    {
        static void Main(string[] args)
        {
            string inputString = "Hello Extension Methods";
            int wordCount = ExtensionMethodBeforeCSharp14.WordCount(inputString);
            Console.WriteLine();

        }
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
}
