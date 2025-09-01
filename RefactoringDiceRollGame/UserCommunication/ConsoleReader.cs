namespace RefactoringDiceRollGame.UserCommunication;

public static class ConsoleReader
{
    public static int ReadIntiger(string message)
    {
        int result;
        do
        {
            Console.WriteLine(message);
        }
        while (!int.TryParse(Console.ReadLine(), out result));

        return result;
    }
        
}

