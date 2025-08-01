﻿namespace LearningByDoing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Out Keyword execution.
            #region
            ////Declaration of an array of integers.
            //int[] numbers = new int[] { 10, -20, 30, -40, 50 };

            ////Calling the method with the OutKeyword Class.
            //var outKeyWord = new OutKeyWord();
            //var result = outKeyWord.GetOnlyPositiveNumbers(numbers, out List<int> nonPositiveNumbers);

            ////Printing the Positive Numbers and the count of Non-Positive Numbers
            //foreach (int number in result)
            //{
            //    Console.WriteLine($"Positive Number: {number}");
            //}

            ////Console.WriteLine($"Number of Non-Positive Numbers: {nonPositiveNumbersCount}");


            ////Printing the Non-Positive Numbers
            //foreach (int nonPositive in nonPositiveNumbers)
            //{
            //    Console.WriteLine($"Non-Positive Number: {nonPositive}");
            //}
            #endregion

            //TryParseMethod execution
            #region
            var tryParse = TryParseMethod.TryParseMethodExecution();
            if (tryParse > 0)
            {
                Console.WriteLine($"Parsing successful. Result: {tryParse}");
            }
            else
            {
                //By Default if the TryParse Method fails the result will be 0
                Console.WriteLine($"tryParse value if failed parsing: {tryParse}");
                Console.WriteLine("Parsing was not successful or the result is zero.");
            }
            #endregion
        }
    }
}
