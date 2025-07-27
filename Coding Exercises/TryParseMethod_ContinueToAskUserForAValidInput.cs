using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coding_Exercises
{
    public class TryParseMethod_ContinueToAskUserForAValidInput
    {
        private int Result { get; set; }
        public int ContinueToAskUserForAValidInput()
        {

            do
            {
                Console.WriteLine("Enter a number: ");
                var userInput = Console.ReadLine();
                bool isParsingSuccessful = int.TryParse(userInput, out int result);

                if (isParsingSuccessful)
                {
                    Result =  result;
                }
                else
                {
                    Console.WriteLine("Invalid input. Please try again.");
                }
            }
            while (Result == 0);

            return Result;
        }
    }
}
