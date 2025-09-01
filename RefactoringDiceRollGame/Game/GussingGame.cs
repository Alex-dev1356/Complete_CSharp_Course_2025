namespace RefactoringDiceRollGame.Game;
using RefactoringDiceRollGame.UserCommunication;
public class GussingGame(Dice dice)
{
    private readonly Dice _dice = dice;
    private int _maxAttempts = 3;

    public GameResult Play()
    {
        var diceRollResult = _dice.Roll();

        Console.WriteLine($"Dice rolled. Guess what number it shows in {_maxAttempts} tries.");

        while (_maxAttempts > 0)
        {
            var guess = ConsoleReader.ReadIntiger("Enter a number:");
            if (guess == diceRollResult)
            {
                return GameResult.Victory;
            }

            Console.WriteLine("Wrong number.");
            --_maxAttempts;

        }

        return GameResult.Defeat;
    }

    public static void PrintResult(GameResult result)
    {
        var message = result == GameResult.Victory
        ? "You won!"
        : "You lost. :(";
        Console.WriteLine(message);
    }
}
