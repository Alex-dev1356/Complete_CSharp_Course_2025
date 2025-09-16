namespace ExtensionMethods.Extensions
{
    //Declaring a static class to hold extension methods
    public static class StringExtensions
    {
        //Extension methods can only be defined in a static classes and extension method itself should be static
        //The parameter should be prefixed with 'this' keyword, the parameter of the extended type must always be 
        //the first parameter of the method so we can add more parameters if needed
        public static int CountLines(this string input) => 
            input.Split(Environment.NewLine).Length;

    }

    //NOTE: Except for the 'this' keyword, an extension method is a static method like any other but because it is an
    //extension method we can now use it as it belonged to the string class.
}
