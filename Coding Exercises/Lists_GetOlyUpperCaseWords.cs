using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coding_Exercises
{
    public class Lists_GetOlyUpperCaseWords
    {
        /*
        Lists - GetOnlyUpperCaseWords
        Implement the GetOnlyUpperCaseWords method, which given a collection of strings, returns a List with 
        only those strings which contain only uppercase letters.

        The result collection should not contain duplicates.

        For example:

        for input List {"one", "TWO", "THREE", "four"} the result shall be {"TWO", "THREE"}

        for input List {"one", "TWO", "THREE", "four", "TWO"} the result shall be {"TWO", "THREE"} (the second "TWO" is ignored)

        for input List {"one", "TWO123", "THREE!&^", "four"} the result shall be an empty List because no word in this 
        collection is built from only uppercase letters (digits and special characters are not letters at all).

        Tips:

        Strings are collections of characters. It means we can iterate a string with a foreach loop, and in each iteration, 
        we have access to a specific character from this string.

        To check if a character is an uppercase letter, we can use the char.IsUpper method:

        Please notice that digits and special characters are not letters at all, so words containing them should not be considered 
        uppercase words. Luckily, the char.IsUpper method covers that; it returns false for any non-letter characters.
        */
        public static List<string> GetOnlyUpperCaseWords(List<string> words)
        {
            var upperCaseWords = new List<string>();
            foreach (var word in words)
            {
                bool isNotValid = false;
                bool allUpperCase = true;
                foreach (char character in word)
                {
                    if (!char.IsLetter(character))
                    {
                        isNotValid = true;
                    }

                    if (!char.IsUpper(character))
                    {
                        allUpperCase = false;
                    }

                    continue;
                }

                if (!isNotValid && allUpperCase && !upperCaseWords.Contains(word))
                {
                    upperCaseWords.Add(word);
                }
                else
                {
                    continue;
                }
            }

            return upperCaseWords;
        }
    }
}
