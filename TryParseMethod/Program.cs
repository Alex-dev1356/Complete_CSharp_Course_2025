namespace TryParseMethod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //We use TryParse to check if a string can be converted to a number and assign it to a variable if true.
            //We use this to avoid run time errors when parsing strings to numbers that the user populate in the input field
            //for example a string value instead of a number value. Last time we use the int.Parse method but with this method
            //we'll encounter a runtime error if the expected is a number and the actual is a string.
            Console.WriteLine("Enter a number: ");
            var userInput = Console.ReadLine();
            bool isParsingSuccessful = int.TryParse(userInput, out int number);

            if (isParsingSuccessful)
            {
                Console.WriteLine($"Parsing worked and the number is {number}");
            }
            else
            {
                Console.WriteLine("Parsing was not successful");
            }
        }
    }
}
