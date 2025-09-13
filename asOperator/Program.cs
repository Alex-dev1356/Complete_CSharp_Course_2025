using System;

namespace asOperator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var ingredient = new Ingredient();

            //Using explicit cast
            Cheddar cheddar = (Cheddar)ingredient; // This will throw an InvalidCastException at runtime

            //as operator
            Cheddar cheddar2 = ingredient as Cheddar; // If conversion is successful it will store a Cheddar object in cheddar2.
                                                      // This will assign null to cheddar2 if the cast fails

            //Since we cannot store null in a value type like int, we can declare a nullable type Cheddar?
            Cheddar? cheddar3 = ingredient as Cheddar; // This will assign null to cheddar3 if the cast fails

            //NOTE: Conversion with explicit cost expression works with any type but gives a runtime error
            //if it fails.Conversion with the "as" operator will not give a runtime error.
            //Instead, the result will be null if it fails. Because of that, it can only be used to cast to nullable
            //types so those types that can be assigned null.
        }
    }

    public class Ingredient
    {
        
    }

    public class Cheddar: Ingredient    
    {

    }
}
