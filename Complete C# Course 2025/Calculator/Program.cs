namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello!");

            Console.WriteLine("Input the first number:");
            int firstNumber = int.Parse(Console.ReadLine());

            Console.WriteLine("Input the second number:");
            int secondNumber = int.Parse(Console.ReadLine());

            Console.WriteLine("What do you want to do with the numbers?");
            Console.WriteLine("[A]dd numbers");
            Console.WriteLine("[S]ubtract numbers");
            Console.WriteLine("[M]ultiply numbers");
            string operation = Console.ReadLine().ToLower();

            switch (operation)
            {
                case "a":
                    Console.WriteLine($"{firstNumber} + {secondNumber} = {firstNumber + secondNumber}");
                    break;
                case "s":
                    Console.WriteLine($"{firstNumber} - {secondNumber} = {firstNumber - secondNumber}");
                    break;
                case "m":
                    Console.WriteLine($"{firstNumber} * {secondNumber} = {firstNumber * secondNumber}");
                    break;
                default:
                    Console.WriteLine("Invalid operation");
                    break;
            }

            Console.WriteLine("Press any key to close");
            Console.ReadKey();
        }
    }
}
