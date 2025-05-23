﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coding_Exercises
{
    public class WhileLoop_CalculateSumOfNumbersBetween
    {
        /*
        While loop - CalculateSumOfNumbersBetween
        Using the while loop, implement the CalculateSumOfNumbersBetween method, which given two integers called firstNumber 
        and lastNumber, should calculate the sum of numbers between them (including the numbers themselves).

        If lastNumber is smaller than firstNumber, the result shall be 0.

        For example:

        for firstNumber equal to 5 and lastNumber equal to 10, the result should be 45 because this is the sum of numbers 5, 6, 7, 8, 9, 10

        for firstNumber equal to -5 and lastNumber equal to 5, the result should be 0 because this is the sum of numbers -5, -4, -3, -2, -1, 0, 1, 2, 3, 4, 5

        for firstNumber equal to 10 and lastNumber also equal to 10, the result should be 10 because, to the sum, we include the only number, which is 10

        for firstNumber equal to 5 and lastNumber equal to 4, the result should be 0 because the lastNumber is smaller than firstNumber
        */

        public static int CalculateSumOfNumbersBetween(int firstNumber, int lastNumber)
        {
            int sum = 0;

            while (firstNumber <= lastNumber)
            {
                if (lastNumber < firstNumber) return 0;

                if (firstNumber == (lastNumber * -1)) return 0;

                if (firstNumber == lastNumber) return firstNumber;

                sum += firstNumber;

                firstNumber++;
            }

            return sum;
        }
    }
}
