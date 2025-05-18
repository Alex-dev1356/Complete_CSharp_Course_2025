using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coding_Exercises
{
    public class MultiDimentionalArrays_FindMax
    {
        /*
        Multi-dimensional arrays - FindMax
        Implement the FindMax method, which given a two-dimensional array of integers, returns the maximal value from this array.

        If any of the array's dimensions is zero, it means the array is empty, and the method should return -1.

        For example:

        for an empty array of size [0,3] the result should be -1

        for an array like this, the result should be 12
        */
        public static int FindMax(int[,] numbers)
        {
            int height = numbers.GetLength(0);
            int width = numbers.GetLength(1);

            if (height == 0 || width == 0)
            {
                return -1;
            }

            int MaxNumber = numbers[0, 0];

            for (int i = 0; i < height; ++i)
            {
                for (int j = 0; j < width; ++j)
                {
                    if (numbers[i, j] > MaxNumber)
                    {
                        MaxNumber = numbers[i, j];
                    }
                }
            }

            return MaxNumber;
        }
    }
}
