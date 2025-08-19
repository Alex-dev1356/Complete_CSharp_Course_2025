﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coding_Exercises
{
    public class String_Split_And_String_Join_Methods
    {
        /*  Introduction:
            In the next lecture, we will see string.Split and string.Join methods in action. 
            It will be easier to understand them if we first write some code that uses them.
            string.Split takes a string and a separator as parameters. It splits the string 
            into pieces by the separator. The separator can either be a string or a char.
        
            For example, for the string "this,is,some,string" and separator ',', it will return 
            a 4-element array with "this" "is" "some" "string" strings inside.
            string.Join does the opposite: it takes a collection of strings and joins them with 
            a given separator. Please notice that this method is a static method in the string class. 
            The separator can be a char or a string.

            In this case, the result will be the following string:
            "one--two--three"
        
            Exercise:
            Implement the TransformSeparators method. Its purpose is to take a string with some 
            separators and replace them with the target separators.

            For example, for:
            input equal to "this,is,some,string"
            originalSeparator equal to ","
            targetSeparator equal to "+"
            The result should be "this+is+some+string"
        */

        public static string TransformSeparators(
            string input,
            string originalSeparator,
            string targetSeparator)
        {
            //your code goes here
            var separatedInput = input.Split(originalSeparator);

            return string.Join(targetSeparator, separatedInput);
        }
    }
}
