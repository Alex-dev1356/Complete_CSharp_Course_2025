namespace ReadOnly_And_Const
{
    public class Program
    {
        static void Main(string[] args)
        {
            //ReadOnly fields - can only be assigned at the declaration or in the constructor. After
            //the object is constructed, it will not be possible to change the value of the read-only field.
            //Making all the fields of an object read-only makes the whole object immutable.
            //We use readonly fields when we want a field never to change after it has been set in the constructor.

            //Immutability- means that once an object is created, it will never be modified.

            //Const modifier - can be applied to both variables and fields. Those variables and fields must
            //be assigned at declaration and can never be modified afterward. They must be given a compile-time
            //constant value, so a value that can be evaluated during the compilation, before the application run.
            //We use const fields for things with a constant value, known at compilation time.

            //NOTE: It's generally a good idea to make readonly all those fields that we don't ever intend
            //to modify after they are first set in the constructor. 

            var square = new Square(10, 10);
            Console.WriteLine($"The area of the square is {square.GetArea()}");
            Console.WriteLine($"The max area of the square is {square.GetMaxArea()}");
        }
    }

    public class Square
    {
        private readonly int _height;
        private readonly int _width;

        //Adding constant fields
        const int MaxSide = 100;

        public Square(int width, int height)
        {
            _width = width;
            _height = height;
        }

        public int GetArea() => _width * _height;

        public int GetMaxArea() => MaxSide * MaxSide;
    }
}
