using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coding_Exercises
{
    public class ExtensionMethods_ListExtensions
    {
        /*
        Extension methods - List extensions

        Create an extension method for the List<int> type called TakeEverySecond.

        This method should return a new List of ints with every second element from the input list.
        For example:
        for input  { 1, 5, 10, 8, 12, 4, 5 }, the result shall be { 1, 10, 12, 5 }
        for input  { 1, 5, 10, 8, 12, 4, 5, 6 }, the result shall be { 1, 10, 12, 5 }
        for input  { 1 } , the result shall be { 1 }
        for empty input, the result shall be empty
        don't handle the null input in any way (let it throw an exception)
         */
    }

    public static class ListExtenstionMethod
    {
        public static List<int> TakeEverySecond(this List<int> inputList)
        {
            var returnedList = new List<int>();

            for (int i = 0; i < inputList.Count; i += 2)
            {
                returnedList.Add(inputList[i]);
            }

            return returnedList;
        }

    }

}
