using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Interfaces.AnimalsInterface
{
    //The Bird, Kite and Plane have a common behavior they all can fly.
    //So we can define an interface IFlyable to represent that behavior.
    public interface IFlyable
    {
        //Interface defines a contract that any type that implements it must follow or obligated to implement the methods 
        //declared in the interface.
        //All methods defined in an interface are ALWAYS implicitly virtual, simillar to abstract methods in abstract classes.
        //Interafaces cannot be instantiated, they must be implemented by a class.
        //Interfaces create a "has-a" or "behaves-like" kind of relationship between Bird, Kite and Plane.
        //For Interfaces, we can inherit multiple interfaces in a single class unlike classes.
        //Inheritance creates an "is-a" relationship between Bird, Kite and Plane.

        //In interfaces, we only declare methods, and each type implementing this interface will be obligated to
        //implement the method.
        void Fly();

        //NOTE: A new feature of C# is that interfaces can have default implementations.
        public void DefaultMethod() =>
            Console.WriteLine("This is a default method.");

    }
    public class Bird : IFlyable
    {
        public void Tweet() =>
            Console.WriteLine("Tweet, tweet!");

        public void Fly() =>
            Console.WriteLine("Fly using its wings.");

        //Modifying the DefaultMethod implementation
        public void DefaultMethod() =>
            Console.WriteLine("Modified default method.");
    }

    public class Kite : IFlyable
    {
        public void Fly() =>
            Console.WriteLine("Flying carried by the wind.");
    }

    public class Plane : IFlyable
    {
        public void Fly() =>
            Console.WriteLine("Fly using its wings.");
    }

    public class Animals
    {

    }

    //Extending one interface with another
    public interface IAnimal
    {
        void MakeSound();
    }

    public interface IHousePet : IAnimal
    {
        void TaketoVet();
    }

    public interface IFeline : IAnimal
    {
        void HideInCardboardBox();
    }

    public class DomesticCatImplementingInterfaces : IHousePet, IFeline
    {
        //Since the IAnimal interface is extended by both IHousePet and IFeline, and this class implemented both IHousePet and IFeline,
        //it must implement all the methods declared in both interfaces.
        public void MakeSound() =>
            Console.WriteLine("Meow");

        //Since this class inherited from IFeline and IHousePet, it must implement all the method declared in all the interfaces.
        public void HideInCardboardBox() =>
            Console.WriteLine("Hiding in cardboard box.");

        public void TaketoVet() =>
            Console.WriteLine("Taking to vet.");

    }
}
