namespace ObjectInitializers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Using Constructor to initialize the properties
            #region
            //var person = new Person("Alexa", 2000);
            //Console.WriteLine(person.Name);
            //Console.WriteLine(person.YearOfBirth);
            #endregion

            //Using Object Initializer
            #region
            //var person = new Person()
            //{
            //    Name = "Alexa",
            //    YearOfBirth = 2000
            //};
            //Console.WriteLine(person.Name);
            //Console.WriteLine(person.YearOfBirth);
            #endregion

            //NOTE: IF THE SETTER OF THOSE PROPERTIES IS PRIVATE OR IF IT IS REMOVED,
            //THE OBJECT INITIALIZER WON'T WORK.

            //Using Object Initializer
            #region
            var person2 = new Person()
            {
                Name = "Alexa",
                YearOfBirth = 2000
            };

            //person2.YearOfBirth = 2001; // This will cause a compile-time error because YearOfBirth is already set to 2000.
            Console.WriteLine(person2.Name);
            Console.WriteLine(person2.YearOfBirth);
            #endregion

            //WHICH IS BETTER USING THE CONSTRUCTOR OR THE OBJECT INITIALIZER?: When using a CONSTRUCTOR
            //we MUST provide the values for all the properties, but when using the OBJECT INITIALIZER 
            //we can provide the values for only the properties that we want to initialize, and the rest
            //of the properties will be initialized with their default values.
        }
    }

    class Person
    {
        //public string Name { get; set; }
        //public int YearOfBirth { get; set; }

        // Constructor to initialize the properties
        //public Person(string name, int yearOfBirth)
        //{
        //    Name = name;
        //    YearOfBirth = yearOfBirth;
        //}


        //Using the init instead of public setter, if we use init it will work like a 
        //read only property after the object is initialized or created and we assigned the value
        //to the init we WONT BE ABLE TO CHANGE IT AFTERWARDS.

        public string Name { get; set; }
        public int YearOfBirth { get; init; }
    }
}
