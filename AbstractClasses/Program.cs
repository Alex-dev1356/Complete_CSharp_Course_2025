using System.Threading.Channels;

namespace AbstractClasses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Abstract Class - a class that cannot be instantiated. They only serve as a base class for other, more conrete types.

            //Abstract classes can also define Abstract methods and properties. 

            //Virtual methods are methods that can be overridden in derived classes. 

            //Abstract methods are methods that must be overridden in derived classes. They can only be defined in abstract classes.
            //and they don't have implementations.

            //NOTE: All Abstract methods are implicitly virtual.They are obligatory to override them in the non-abstract derived classes.


            //Why we need Abstract Methods
            /*
            We should mark methods as abstract
            if the base type should not or cannot provide any default implementation. By marking a method as abstract,
            we say all the derived types must provide their own implementation.
            Abstract methods are quite similar to the virtual methods and actually they are implicitly virtual.
            The difference is that if we mark a method as virtual, we say in the base class there is some default
            implementation.

            If the derived class wants to override it, it is free to do so.
            Abstract methods don't give such a choice.
            There is no implementation at all in the base class and the derived non-abstract classes simply must
            override this method.

            Another difference is that abstract methods can be declared only in abstract classes, while virtual
            methods can belong to both abstract and non abstract types.
             */

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

        //Declaring an abstract method
        public abstract void Prepare();
    }

    //Creating classes that Inherit from an abstract class
    public abstract class Cheese : Ingredient
    {
        public Cheese(int priceIfExtraTopping) : base(priceIfExtraTopping)
        {
        }

        //The only way to skip an abstract method from the base class is if the derived class is abstract itself.
    }

    public class Cheddar : Cheese
    {
        public Cheddar(int priceIfExtraTopping) : base(priceIfExtraTopping)
        {
            
        }
        //Overriding the abstract method from the Ingredient base class
        public override void Prepare() =>
            Console.WriteLine("Grating and sprinkle over the pizza."); ;
        
    }

    public class Mozzarella : Cheese
    {
        public Mozzarella(int priceIfExtraTopping) : base(priceIfExtraTopping)
        {
        }

        //Overriding the abstract method from the Ingredient base class
        public override void Prepare() => 
            Console.WriteLine("Slice thinly and place on top of the pizza.");
    }
}
