namespace JSON
{
    public class Program
    {
        static void Main(string[] args)
        {
            //JSON - JavaScript Object Notation
            //Library - is a collection of prewritten code that we can use to make our programming easier. 

            //Creating an instance of the Person class
            var person = new Person()
            {
                FirstName = "John",
                LastName = "Smith",
                YearOfBirth = 1972
            };

            //Serializing the person object to a JSON string, we can use the Serialize method from the JsonSerializer class
            var asJson = System.Text.Json.JsonSerializer.Serialize(person);
            Console.WriteLine("As Json:");
            Console.WriteLine(asJson);
            Console.WriteLine("----------------------------------------------------------------");

            //Deserializing the JSON string back to a C# object, we can use the Deserialize method from the JsonSerializer class
            //VS added backslashes to escape the double quotes in the JSON string
            var personJson = "{\"FirstName\":\"John\",\"LastName\":\"Smith\",\"YearOfBirth\":1972}";
            var personFromJson = System.Text.Json.JsonSerializer.Deserialize<Person>(personJson);
            Console.WriteLine("As Object:");
            Console.WriteLine(personFromJson.FirstName);
            Console.WriteLine(personFromJson.LastName);
            Console.WriteLine(personFromJson.YearOfBirth);

        }
    }


    //Declaring a Person class to demonstrate JSON serialization and deserialization
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int YearOfBirth { get; set; }
    }
}
