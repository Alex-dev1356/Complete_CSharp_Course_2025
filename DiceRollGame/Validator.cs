namespace DiceRollGame
{
    public class Validator
    {
        public bool isValidInput(int input)
        {
            return 
                input >= 1 && 
                input <= 6 &&
                input.GetType() == typeof(int);
        }

        public bool isMatched(int number, int input)
        {
            return number == input;
        }
    }
}
