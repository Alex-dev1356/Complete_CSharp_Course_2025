using System.Net.WebSockets;
using System.Runtime.InteropServices;
using System.Security.AccessControl;

namespace DiceRollGame
{
    public class Program
    {
        static void Main(string[] args)
        {
            var randomNum = new Dice(new Random(), 6).Roll();
            var validator = new Validator();
            var player = new Player();
            var playerLifeLine = player.playerLifeLine;

            Console.WriteLine("Dice rolled. Guess what number it shows in 3 tries.");
            do
            {
                Console.WriteLine("Enter a number:");
                var userInput = Console.ReadLine();
                var invalidUserInput = int.TryParse(userInput, out int validUserInput);

                if (validator.isMatched(randomNum, validUserInput))
                {
                    Console.WriteLine("You win!");
                    Console.ReadKey();
                    break;
                }
                else if (invalidUserInput == false)
                {
                    Console.WriteLine("Invalid input. Try again.");
                }
                else
                {
                    Console.WriteLine("Wrong number. Try again.");
                    playerLifeLine--;
                    if (player.checkPlayerLifeLineDropToZero(playerLifeLine))
                    {
                        Console.WriteLine("You Loose!");
                    }
                }

            } while (playerLifeLine != 0);
        }
    }
}
