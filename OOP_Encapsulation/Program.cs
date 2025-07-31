namespace OOP_Encapsulation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Encapsulation is the bundling of data and methods that operate on that data within one unit, such as a class.
            //It restricts direct access to some of an object's components, which can prevent the accidental modification of data.

            //Creating an object of Circle class with radius 10
            var circle1 = new Circle(10);

            //Creating an instance of MeasurementOfShapesCalculator class to calculate area and circumference of the circle
            var calculator = new MeasurementOfShapesCalculator();

            //Using the methods defined in MeasurementOfShapesCalculator class to calculate area and circumference
            Console.WriteLine("The area of a circle with a radius of " + circle1._radius + " is " + calculator.CalculateCircleArea(circle1));
            Console.WriteLine("The circumference of a circle with a radius of " + circle1._radius + " is "  + calculator.CalculateCircleCircumference(circle1));

            //Creating another object of Circle class with radius 5
            var circle2 = new Circle(5);
            //Using the methods defined in MeasurementOfShapesCalculator class to calculate area and circumference
            Console.WriteLine("The area of a circle with a radius of " + circle2._radius + " is " + calculator.CalculateCircleArea(circle2));
            Console.WriteLine("The circumference of a circle with a radius of " + circle2._radius + " is " + calculator.CalculateCircleCircumference(circle2));
        }
    }
}
