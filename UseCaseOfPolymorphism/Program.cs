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

    /*
       Protected members can be used in the derived classes, but they can't be
       used outside.
    */

    /*
      NOTE: We should make methods and properties virtual if we intend them to be overridden 
            in the derived classes.
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

            //Calling the public method from the base class
            var ingredient = new Cheddar();
            Console.WriteLine(ingredient.PulicMethod());

            //Using the Public field from the base class, but assigning different values
            //to it in the derived classes
            ingredient.PublicField = 10;
            var cheddar = new Cheddar();
            cheddar.PublicField = 20;

            //Printing the values of the Public field from the base class
            Console.WriteLine($"Ingredient: {ingredient.PublicField}");
            Console.WriteLine($"Cheddar: {cheddar.PublicField}");

            //Finding out what will be printed on Cheddar Name and Ingredient Name properties
            Ingredient someIngredient = new Cheddar();
            Console.WriteLine("Variable of type Ingredient: " + someIngredient.Name);
            Console.WriteLine("Variable of type Cheddar: " + cheddar.Name);

            //Storing of Type Ingredient into a List
            List<Ingredient> ingredients = new List<Ingredient>()
            {
                new Cheddar(),
                new TomatoSauce(),
                new Mozzarella()
            };

            //Printing the Name property of each Ingredient in the List
            foreach (var ingredientItem in ingredients)
            {
                Console.WriteLine(ingredientItem.Name);
            }

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
        //Declaring Name Property to be used for the derived classes and making it virtual so that
        //the derived classes can override it and implement their own logic for the Name Property.
        public virtual string Name { get; } = "Some ingredient";

        //Declaring a public field
        //Note:Objects of classes derived from this base class will also have such fields,
        //but the values will be independent. The value stored in this field is not shared in any way.
        public int PublicField;

        //This method can be called from any class that inherits from the "Ingredient" class
        public string PulicMethod() =>
            "This method is PUBLIC in the Ingredient class";

        //Protected Modifier - The method can be used in the derived classes, but not outside
        protected string ProtectedMethod() =>
            "This method is PROTECTED in the Ingredient class";
    }

    public class Cheddar : Ingredient
    {
        //Overriding the virtual Name Property from the base class using the Virtual keyword to
        //implement our own logic for the Cheddar class
        public override string Name => "Cheddar cheese";
        public int AgedForMonths { get; }

        //We can call the public method from the base class. Unlike public methods, private methods
        //are NOT INHERITED
        public void UseMethodsFromTheBaseClass()
        {
            Console.WriteLine(PulicMethod());
        }

        //We can call the protected method from the base class.
        public void UseMethodsFromTheBaseClass2()
        {
            Console.WriteLine(ProtectedMethod());
        }

    }

    public class TomatoSauce : Ingredient
    {
        public override string Name => "Tomato sauce";
        public int TomatosIn100Grams{ get; }
    }

    public class Mozzarella : Ingredient
    {
        //We eill not override the Name Property from the base class, for example purposes
        //It will use the Name Property from the base class
        public string Name => "Mozarella";
        public bool IsLight { get; }   
    }
}
