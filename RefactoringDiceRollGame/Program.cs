using RefactoringDiceRollGame.Game;

namespace RefactoringDiceRollGame
{
    public class Program
    {
        static void Main(string[] args)
        {
            var randomNumberGenerator = new Dice(new Random());
            var game = new GussingGame(randomNumberGenerator).Play();
            GussingGame.PrintResult(game);

            Console.ReadKey();
        }
    }
}
