using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Abstraction
{
    public class Rectangle
    {
        public int Width;
        public int Height;

        //Adding validation to constructor parameters
        public Rectangle(int width, int height)
        {
            //_width = width;
            //_height = height;

            ////Using the validation method
            //_width = GetLengthOrDefault(width, "Width");
            //_height = GetLengthOrDefault(height, "Height");

            //Using the nameof expression to change the parameter nameto avoid hard coding the parameter name.
            Width = GetLengthOrDefault(width, nameof(Width));
            Height = GetLengthOrDefault(height, nameof(Height));

        }

        //Adding validation method for width and height
        private int GetLengthOrDefault(int length, string name)
        {
            int defaultValueIfNonPositive = 1;
            if (length <= 0)
            {
                Console.WriteLine($"{name} must be a positive number");
                return defaultValueIfNonPositive;
            }
            return length;
        }

        public int CalculateCircumference()
        {
            return 2 * (Width + Height);
        }

        public int CalculateArea()
        {
            return Width * Height;
        }
        
    }
}
