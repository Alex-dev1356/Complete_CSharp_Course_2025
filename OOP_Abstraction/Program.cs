namespace OOP_Abstraction
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Abstraction means that classes expose only essential data and methods and hide
            //the underlying details.

            var rectangle1 = new Rectangle(5,10);

            //Accessing the width and height of rectangle
            Console.WriteLine("Width: {0} Height: {1}", rectangle1._width, rectangle1._height);
        }
    }
}
