using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningByDoing
{
    public class OutKeyWord
    {
        //Recalling the execution of the Out Keyword example from the lecture.
        
        public List<int> GetOnlyPositiveNumbers(
            int[] numbers, out List<int> numberOfNonPositiveNumbers)
        {
           numberOfNonPositiveNumbers = new List<int>();

            List<int> result = new List<int>();

            foreach (int number in numbers)
            {
                if (number > 0)
                {
                    result.Add(number);
                }
                else
                {
                    numberOfNonPositiveNumbers.Add(number);
                }
            }

            return result;
        }
    }
}
