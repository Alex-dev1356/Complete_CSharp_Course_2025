﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coding_Exercises
{
    public class ForeachLoop_IsAnyWordLongerThan
    {
        /*

        Foreach loop - IsAnyWordLongerThan
        Using the foreach loop, implement the IsAnyWordLongerThan method, which given a length and an array of words, returns 
        true if any of those words is longer than the given length, and false otherwise.

        For example:

        for length 4 and words {"aaa", "bbbb", "ccccc"} the result shall be true, because "ccccc" is longer than 4 letters

        for length 5 and words {"aaa", "bbbb", "ccccc"} the result shall be false because no word is longer than 5 letters

        for length 5 and an empty array, the result shall be false because no word is longer than 5 letters

        */

        public static bool IsAnyWordLongerThan(int length, string[] words)
        {
            if (words.Length == 0)
            {
                return false;
            }
            foreach (string word in words)
            {
                if (word.Length > length)
                {
                    return true;
                }
            }

            return false;
        }
    }
}
