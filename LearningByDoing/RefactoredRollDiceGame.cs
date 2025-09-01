using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningByDoing
{
    public class RefactoredRollDiceGame
    {

    }

    public class Dice(Random random)
    {
        public readonly Random _random = random;
        private readonly int _diceSides = 6;

        public int Roll() => _random.Next(1, _diceSides + 1);
    }

    public enum GameResult 
    { 
        Victory,
        Defeat
    }

    public static class ConsoleReader
    {
        public static int ReadIntiger(string message)
        {
            int validInput;

            do
            {
                Console.WriteLine(message);
                //Console.WriteLine("Wrong number.");

            }
            while(!int.TryParse(Console.ReadLine(), out validInput));

            return validInput;
        }
    }

    public class GuessingGame
    {
        private int _maxAttempts = 3;
        private Dice _dice;
        public GuessingGame(Dice dice)
        {
            _dice = dice;
        }

        public GameResult Play()
        {
            Console.WriteLine($"Dice rolled. Guess what number it shows in {_maxAttempts} tries.");

            var diceRollNumber = _dice.Roll();

            while (_maxAttempts > 0)
            {
                var guess = ConsoleReader.ReadIntiger("Enter a number: ");
                if (diceRollNumber == guess)
                {
                    return GameResult.Victory;
                }

                Console.WriteLine("Wrong number.");
                --_maxAttempts;
            }

            return GameResult.Defeat;   
        }

        public void PrintResult(GameResult result)
        {
            var gameResult= result == GameResult.Victory 
                ? "You Won!" 
                : "You Lost. :(";
            Console.WriteLine(result);
        }
    }


}
