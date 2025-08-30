namespace DiceRollGame
{
    public class  Dice
    {
        private readonly Random _generateRandomNumber;
        private int _diceSides = 6;
        public Dice(Random generateRandomNumber, int diceSides)
        {
            _generateRandomNumber = generateRandomNumber;
            _diceSides = diceSides;
        }
        public int Roll() => _generateRandomNumber.Next(1, _diceSides + 1);
    }
}
