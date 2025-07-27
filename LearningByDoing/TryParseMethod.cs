using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningByDoing
{
    public class TryParseMethod
    {
        public static int TryParseMethodExecution()
        {
            Console.WriteLine("Enter a number: ");
            var userInput = Console.ReadLine();
            bool isParsingSuccessful = int.TryParse(userInput, out int result);

            return result;
        }
    }
}
