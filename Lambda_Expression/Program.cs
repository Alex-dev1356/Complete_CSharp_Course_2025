namespace Lambda_Expression
{
    public class Program
    {
        int Width;
        int Height;
        static void Main(string[] args)
        {
            //Expression-Bodied Methods or Lambda Expressions
            //If your method only contains a single statement or expression, you can write it with a special syntax
            //that makes it one line long.

            //NOTE: WE CAN ONLY USE EXPRESSION-BODIED METHODS WHEN ONLY ONE STATEMENT OR EXPRESSION IS PRESENT
        }


        //We'll convert it these two methods to expression-bodied methods

        //public int CalculateCircumference()
        //{
        //    return 2 * Width + 2 * Height;
        //}

        //public int CalculateArea()
        //{
        //    return Width * Height;
        //}

        //Converted to Expression-Bodied Methods
        public int CalculateCircumference() => 2 * Width + 2 * Height;
        public int CalculateArea() => Width * Height;
    }
}
