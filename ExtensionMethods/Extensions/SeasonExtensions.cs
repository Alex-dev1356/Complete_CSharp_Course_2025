namespace ExtensionMethods.Extensions
{
    public static class SeasonExtensions
    {
        /*
         In this method, I add one to the numeric representation of the enum value.
        Then I calculate the modulo of four of the result.
        So we stay within valid values of the enum.
        For winter its numeric representation is 3, so after one is added it gives 4.
        4 is not a valid value for this enum, so we calculate its modulo of 4, which gives zero.
        Zero maps to spring in the enum, which is indeed the next season after winter.

        Extension methods are static methods, but we can use them as if they were instance methods on the extended
        type.
         */


        public static Season Next(this Season season)
        {
            int seasonAsInt = (int)season;
            int nextSeason = (seasonAsInt + 1) % 4;
            return (Season)nextSeason;
        }

    }
}
