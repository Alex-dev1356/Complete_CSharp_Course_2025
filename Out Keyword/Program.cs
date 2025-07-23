using System.ComponentModel;

namespace Out_Keyword
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Out Keyword is used to produce multiple return values from a method.
            var numbers = new int[] { 10, -8, 2, 12, -17 };

            //Calling the method
            #region
            //var positiveNumbers = GetOnlyPositive(numbers);
            //foreach (int number in positiveNumbers)
            //{
            //    Console.WriteLine(number);
            //}
            #endregion

            //A method that selects the positive numbers from the input and returns them in a list. 
            #region
            //List<int> GetOnlyPositive(int[] numbers)
            //{
            //    var result = new List<int>();

            //    foreach (int number in numbers)
            //    {
            //        if (number > 0 )
            //        {
            //            result.Add(number);
            //        }
            //    }

            //    return result;
            //}
            #endregion


            //Calling the method with the out keyword
            #region
            var positiveNumbers = GetOnlyPositive(numbers, out int nonPositiveCount);
            foreach (int number in positiveNumbers)
            {
                Console.WriteLine(number);
            }
            #endregion

            Console.WriteLine($"Count of non-positive numbers: {nonPositiveCount}");
            Console.ReadKey();

            //Now we want to return an extra piece of info from this method, An integer representing the
            //count of non-positive numbers that had been excluded from the result. We will now use the out
            //Keyword.
            List<int> GetOnlyPositive(
                int[] numbers, out int countOfNonPositiveNumbers)
            //If we use the Out Modifier, we must assign some value to this parameter whithin this method.
            {
                //We will assign a 0 value to this parameter and we'll increment it as we find non-positive
                //numbers.
                countOfNonPositiveNumbers = 0;

                var result = new List<int>();

                foreach (int number in numbers)
                {
                    if (number > 0)
                    {
                        result.Add(number);
                    }
                    else
                    {
                        countOfNonPositiveNumbers++;
                    }
                }

                return result;
            }

        }
    }
}
