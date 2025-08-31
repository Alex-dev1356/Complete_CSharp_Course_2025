namespace EnumsAndCasting
{
    public class Program
    {
        static void Main(string[] args)
        {
            Days days = Days.Monday;
            Console.WriteLine(days);

            //Casting - converting one type to another
            int day = (int)days;
            Console.WriteLine(day);

            Days day1 = (Days)2;
            Console.WriteLine(day1);

            var day2 = (Days)8;
            Console.WriteLine(day2);
        }
    }

    public enum Days
    {
        Monday, //0
        Tuesday, //1
        Wednesday, //2
        Thursday, //3
        Friday, //4
        Saturday, //5
        Sunday //6
    }
}
