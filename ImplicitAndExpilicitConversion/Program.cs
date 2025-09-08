namespace ImplicitAndExpilicitConversion
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Implicit Conversion - converting from smaller type to a bigger type and not cuasing
            //any loss of data, the conversion is safe and lossless.
            int a = 10;
            decimal b = a;

            Console.WriteLine(a);
            Console.WriteLine(b);

            //Explicit Conversion - converting from a bigger type to a smaller type and may cause
            //loss of data
            decimal c = 10.5m;
            //Here we use the Explicit Casting expression (int) to convert from decimal to int,
            //which is a lossy conversion because the decimal is bigger than the int
            int d = (int)c;

            Console.WriteLine(c);
            Console.WriteLine(d);

            //NOTE: When using explcit casting always think about the circumstances under which it will 
            //not work as expected.Do Explicit Casting when you are sure it will succeed.
        }
    }
}
