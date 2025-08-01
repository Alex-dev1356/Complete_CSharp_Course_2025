﻿using System;
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
        //Declariung fields
        //A field is a variable that belongs to an object of a class.
        ///Each instance of the rectangle class can have different values of those fields.
        //So, for example, we can have one rectangle instance of width ten and height two,
        //and another of width five and height six.
        public int _width;
        public int _height;

        //Declaring a constructor
        public Rectangle(int width, int height)
        {
             _width = width;
             _height = height;
        }

        //Declaring a method - The name of a method should start with a verb, as it describes an action.
        public int CalculateCircumference()
        {
            return 2 * (_width + _height);
        }

        public int CalculateArea()
        {
            return _width * _height;
        }
        
    }
}
