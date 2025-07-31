namespace OOP_Abstraction
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Abstraction means that classes expose only essential data and methods and hide
            //the underlying details.

            var rectangle1 = new Rectangle(5,10);

            var reactangle2 = new Rectangle(2, 3);

            //Accessing the width and height of rectangle
            Console.WriteLine("Width: {0} Height: {1}", rectangle1._width, rectangle1._height);

            //Using the method defined in Rectangle class
            //Getting the perimeter of triagle
            Console.WriteLine("Perimeter: {0}", rectangle1.CalculateCircumference());
            //Getting the area of triangle
            Console.WriteLine("Area: {0}", rectangle1.CalculateArea());

            //For second rectangle
            Console.WriteLine("Width: {0} Height: {1}", reactangle2._width, reactangle2._height);
            //Getting the perimeter of triagle
            Console.WriteLine("Perimeter: {0}", reactangle2.CalculateCircumference());
            //Getting the area of triangle
            Console.WriteLine("Area: {0}", reactangle2.CalculateArea());
        }
    }
}
