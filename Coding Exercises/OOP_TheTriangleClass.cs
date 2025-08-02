using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coding_Exercises
{
    public class OOP_TheTriangleClass
    {
        public int _base;
        public int _height;

        public OOP_TheTriangleClass(int base1, int height)
        {
            _base = base1;
            _height = height;
        }


        public decimal CalculateArea()
        {
            var result = (_base * _height) / 2;

            return result;
        }

        public string AsString()
        {
            string description = ($"Base is {_base}, height is {_height}");

            return description;
        }
    }
}
