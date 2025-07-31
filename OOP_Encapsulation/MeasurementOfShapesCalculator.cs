using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Encapsulation
{
    public class MeasurementOfShapesCalculator
    {
        //Encapsilating methods from a class we could create a separate class for measuring different shapes.
        public double CalculateCircleArea(Circle circle)
        {
            //Calculaate the area of a circle
            return (circle._radius * circle._radius) * Math.PI;
        }

        public double CalculateCircleCircumference(Circle circle)
        {
            //Calculate the circumference of a circle
            return 2 * Math.PI * circle._radius;
        }
    }
}
