namespace InterfacesVsAbstractClasses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             Interfaces
             - An interface defines what set of operations will be provided by any class implementing it.
               It does not provide any implementation on its own and it doesn't contain any data.
             - An interface is an abstraction over behavior.
               It defines what an object can do. When you have a group of types that share similar behavior, they might
               have a common interface.
               For example, a bird, a kite, and a plane fly. So it makes sense for all of them to implement the IFlyable interface.
               When you are given an object implementing IFlyable interface, you may not be sure what it is, but
               you will know it is able to fly. When you try to find what some objects have in common and a verb comes
               to mind, it means you probably want to use an interface.
             - An interface is a set of definitions of methods. It does not provide any implementation, at least in the 99% of the cases.
             - It specifies a contract that an implementing method will have to fulfill .When you implement an interface in your class,
               it means you declare that this class will provide all the methods from this interface.
             - Interface are always implicitly virtual.
             - An interface can only contain methods and properties definitions. It cannot have fields or constructors while an abstract 
               class can.
             */





            /*
             Abstract Classes
             - An abstract class is like a general blueprint for derived classes.
               It represents some general category of things. It may provide implementations of methods, contain fields,etc.              
               It can also contain abstract methods, so methods with no implementations that have to be implemented
               in the derived types.
             - An abstract class is an abstraction over alikeness.
               It defines what an object is. When you have a group of types and they all belong to some general category of 
               things, they might inherit from the same abstract class.
               For example, a bird, a snake and a dog are all animals, so it makes sense for them to inherit from
               the Animal abstract class.
               When you are given an object that inherits from the Animal abstract class, you may not be sure how
               it behaves, but you know that it is some kind of animal.
               When you try to find what some objects have in common and a noun comes to mind, it means you probably
               want to use an abstract class.
             - An abstract class is a type existing ONLY TO DERIVED FROM.
             - On the other hand, abstract classes can provide method implementations. All interface methods are by
               default public and they can't have any other access modifier specified. They cannot be sealed or static.
               That wouldn't make sense because sealed or static methods can't be virtual and the methods from the
             */


            //NOTE: A class can implement multiple interfaces, but it can only inherit from one base class.
        }
    }
}
