namespace DiceRollGame
{
    public class Player
    {
        public readonly int playerLifeLine = 3;
        public bool checkPlayerLifeLineDropToZero(int playerLifeLine)
        {
            return playerLifeLine == 0;
        }
    }
}
