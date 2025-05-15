using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coding_Exercises
{
    public class Arrays_BuildHelloString
    {
        /*
        Arrays (1) - BuildHelloString
        The purpose of the BuildHelloString is to iterate an array of chars consisting of all letters of the word "hello"
        and add those letters to the result string variable, so at the end of this method, this variable is equal to "hello".
        */
        public static string BuildHelloString()
        {
            char[] letters = new[] { 'h', 'e', 'l', 'l', 'o' };
            var result = "";
            for (int i = 0; i < letters.Length; ++i)
            {
                result += letters[i];
            }
            return result;
        }
    }
}
