namespace UseCaseOfPolymorphism
{
    /*
        Polymorphism - means the provision of a single interface to entities of different
        types.

        There is a generic concept of something (Ingredient), and
        this concept can be made concrete by multiple types
        (Cheddar, Mozzarella). All of them can be used wherever the
        generic concept is needed (in the Ingredients list).

        There are a couple of ways of achieving polymorphism in C#. One is using inheritance
    */


    /*
        Let's say we create an application used for ordering pizzas.
        The user can choose from one of the listed pizza types, and the ingredients of each 
        pizza should be shown on the screen.

        We are very transparent about what ingredients we use so we don't only show their name.
        After hovering over an ingredient, details like the aging time of the cheddar cheese are shown.
        Of course, we create this app in an object-oriented way, so we define classes for each of the 
        ingredients.
    
        Here we see some of the ingredient classes. Each of them has something specific.
        For example, the tomato sauce has an integer telling how many grams of tomatoes are there 
        in 100g of the sauce.

        And the mozzarella cheese has a boolean saying if it is light. On the other hand, they all 
        have something in common. They all have a Name property returning a string describing the 
        ingredient.
    */

    /*
        Inheritance - is an "is-a" kind of relationship. Cheddar "is-a" Ingredient, TomatoSauce "is-a" 
        Ingredient and Mozzarella "is-a" Ingredient.

        Inheritance enables us to create new classes that reuse, extend, and modify the behavior defined
        in other classes.

        The class whose members are inherited is called the base class, and the class that inherits those
        members is called the derived class.
     */

    public class Program
    {
        static void Main(string[] args)
        {
            //After all the classes inherit from the base class "Ingredient", we can create a pizza object
            var pizza = new Pizza();
            pizza.AddIngredient(new Cheddar());
            pizza.AddIngredient(new TomatoSauce());
            pizza.AddIngredient(new Mozzarella());
            Console.WriteLine(pizza.Describe());
        }
    }

    public class Pizza
    {
        private List<Ingredient> _ingredients = new List<Ingredient>();

        public void AddIngredient(Ingredient ingredient) =>
            _ingredients.Add(ingredient);

        public string Describe() =>
            $"This is a pizza with {string.Join(", ", _ingredients)}";
    }

    //We will create a base class called "Ingredient" which will be used as a base class for
    //all the other ingredients which we can use a General type of object the we will declare
    //on the List of the Pizza class.
    public class Ingredient
    {
        //For now let's leave this class empty. It will be used as a base class
    }

    public class Cheddar : Ingredient
    {
        public string Name => "Cheddar cheese";
        public int AgedForMonths { get; }

    }

    public class TomatoSauce : Ingredient
    {
        public string Name => "Tomato sauce";
        public int TomatosIn100Grams{ get; }
    }

    public class Mozzarella : Ingredient
    {
        public string Name => "Mozarella";
        public bool IsLight { get; }   
    }
}
