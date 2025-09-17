using Interfaces.AnimalsInterface;

namespace Interfaces
{
    public class Program
    {
        //Interfaces - are used to define a base type for types exposing methods with the same signature

        static void Main(string[] args)
        {
            var bird = new Bird();

            bird.DefaultMethod();

            var bakeableDishes = new List<IBakeable?> ()
            {
                new Pizza(),
                new Panettone()
            };

            //for each bakeable dish in our offer we want to print the baking instructions to the console
            foreach (var bakeableDish in bakeableDishes)
            {
                Console.WriteLine(bakeableDish.GetInstructions());
            }
        }

        public abstract class Dessert
        {
        }

        //The Pizza and Panettone should have a common base type so that we can add them to the same list. They are both bakeable but have
        //different baking instructions
        public interface IBakeable
        {
            string GetInstructions();
        }

        public class Panettone : Dessert, IBakeable
        {
            public string GetInstructions() =>
                "Bake at 180 degrees Celsius for 35 minutes.";
        }

        public class Pizza : Dessert, IBakeable
        {
            public string GetInstructions() =>
                "Bake at 250 degrees Celsius for 10 minutes, " +
                "ideally on a stone.";
        }
    } 
}
