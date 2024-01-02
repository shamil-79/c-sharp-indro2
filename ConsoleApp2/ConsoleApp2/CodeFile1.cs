using System;

// Base class
public class Animal
{
    public string Name { get; set; }

    public Animal(string name)
    {
        Name = name;
    }

    public virtual void MakeSound()
    {
        Console.WriteLine("Some generic sound");
    }
}

// Derived class inheriting from Animal
public class Dog : Animal
{
    public string Breed { get; set; }

    public Dog(string name, string breed) : base(name)
    {
        Breed = breed;
    }

    public override void MakeSound()
    {
        Console.WriteLine("Woof!");
    }
}

// Interface
public interface IRun
{
    void Run();
}

// Another class implementing the interface
public class Cheetah : Animal, IRun
{
    public Cheetah(string name) : base(name) { }

    public override void MakeSound()
    {
        Console.WriteLine("Roar!");
    }

    public void Run()
    {
        Console.WriteLine($"{Name} the cheetah is running.");
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Using different data types
        int num = 10;
        double pi = 3.14;
        string greeting = "Hello, World!";
        bool isTrue = true;
        char symbol = 'A';

        Console.WriteLine($"Integer: {num}, Double: {pi}, String: {greeting}, Boolean: {isTrue}, Char: {symbol}");

        // Creating objects and demonstrating OOP concepts
        Dog myDog = new Dog("Buddy", "Golden Retriever");
        Cheetah myCheetah = new Cheetah("Speedy");

        myDog.MakeSound(); // Override example
        myCheetah.MakeSound(); // Override example
        myCheetah.Run(); // Interface example
    }
}
