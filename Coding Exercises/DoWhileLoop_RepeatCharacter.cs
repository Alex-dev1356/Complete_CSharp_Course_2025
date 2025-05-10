using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coding_Exercises
{
    public class DoWhileLoop_RepeatCharacter
    {
        /*
        Do-while loop - RepeatCharacter
        Using the do...while loop, implement the RepeatCharacter method, which given a character and targetLength, should build 
        a string of this character repeated the given number of times.

        The result must contain at least one character, so even if the targetLength is zero, the length of the result should be 1.

        For example:

        for character 'a' and targetLength 4, the result should be "aaaa"

        for character '!' and targetLength 0, the result should be "!"

        for character 'b' and targetLength 1, the result should be "b"

        for character 'c' and targetLength -1, the result should be "c"
        */

        public static string RepeatCharacter(char character, int targetLength)
        {
            string result = "";
            do
            {
                if (targetLength == 0 || targetLength < 0 || targetLength == 1) return result += character;

                result += character;

                targetLength--;
            }
            while (targetLength != 0);

            return result;
        }
    }
}
