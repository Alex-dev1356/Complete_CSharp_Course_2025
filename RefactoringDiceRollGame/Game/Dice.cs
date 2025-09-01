namespace RefactoringDiceRollGame.Game;

public class Dice
{
    private readonly Random _random;
    private int _sides = 6;
    public Dice(Random random)
    {
        _random = random;
    }

    public int Roll() => _random.Next(1 , _sides + 1);
}
