namespace AbstractClasses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Abstract Class - a class that cannot be instantiated. They only serve as a base class for other, more conrete types.

            //Abstract classes can also define Abstract methods and properties. 
        }
    }

    //Declaring an abstract class
    public abstract class Ingredient
    {
        protected Ingredient(int priceIfExtraTopping)
        {
            Console.WriteLine(
                "Constructor from the Ingredient class.");
            PriceIfExtraTopping = priceIfExtraTopping;
        }

        public int PriceIfExtraTopping { get; }

        public override string ToString() => Name;

        public virtual string Name { get; } = "Sone ingredient";
    }


}
