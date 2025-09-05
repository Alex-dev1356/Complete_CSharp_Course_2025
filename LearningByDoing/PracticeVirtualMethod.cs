using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningByDoing
{
    public class PracticeVirtualMethod
    {

    }

    //public class NumbersSumCalculator
    //{
    //    public int Calculate(List<int> numbers)
    //    {
    //        int sum = 0;
    //        foreach (int number in numbers)
    //        {
    //            sum += number;
    //        }
    //        return sum;

    //    }
    //}

    //Implementing a class that only adds positive numbers
    //public class  PositiveNumbersSumCalculator
    //{
    //    public int Calculate(List<int> numbers)
    //    {
    //        int sum = 0;
    //        foreach (int number in numbers)
    //        {
    //            if (number > 0)
    //            {
    //                sum += number;
    //            }
    //        }
    //        return sum;

    //    }
    //}

    //Modified Base Class for NumbersSumCalculator to make it dynamic for the derived classes
    public class NumbersSumCalculator
    {
        public int Calculate(List<int> numbers)
        {
            int sum = 0;
            foreach (int number in numbers)
            {
                if (ShallBeAdded(number))
                {
                    sum += number;
                }
            }
            return sum;

        }

        //Making a Virtual Method that can be overridden in the derived classes.
        //We make it protected since we don't intend to use it outside those two classes.
        protected virtual bool ShallBeAdded(int number) => true;
    }


    //Refactoring the PositiveNumbersSumCalculator
    public class PositiveNumbersSumCalculator
        : NumbersSumCalculator
    {
        //Overriding the Virtual Method Implementation so it will only add positive numbers
        protected override bool ShallBeAdded(int number) => number > 0;
    }
}
