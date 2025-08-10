namespace Properties
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Setting the Width and Height without using the constructor
            #region
            //Properties properties = new Properties();
            //properties.Width = 100;
            //properties.Height = 200;

            ////Printing the values of Width and Height to the console
            //Console.WriteLine($"Width: {properties.Width}, Height: {properties.Height}");
            #endregion

            //Getting the values of Width and Height using the constructor
            #region
            Properties properties = new Properties(100, 200);
            Console.WriteLine($"Width: {properties.Width}, Height: {properties.Height}");
            #endregion


            //Trying to set the values of Width and Height will result in an error due to the 
            #region
            ////declaration of the properties as private.
            //properties.Width = 100; // This will cause a compile-time error
            //properties.Height = 200; // This will cause a compile-time error
            #endregion
        }
    }

    public class Properties
    {
        //Declaring Properties for Width and Height
        //public int Width { get; set; }
        //public int Height { get; set; }


        ///Making properties public for getting the value but private for setting the value
        public int Width { get; private set; }
        public int Height { get; private set; }


        //To make the properties like a readonly property, we can remove the setter and with this
        //the only way to set the value is through the constructor or through declaration.
        //public int Width { get; } = 12; // This will set the value of Width to 12
        //public int Height { get; }

        public Properties(int width, int height)
        {
            Width = width;
            Height = height;
        }

        //public int SettingTheWidthAndHeightWithoutSetter()
        //{
        //    return Width = 100; //This will cause a compile-time error because there are no setter.
        //}
    }
}
