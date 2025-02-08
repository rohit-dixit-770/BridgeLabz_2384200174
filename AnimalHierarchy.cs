using System;
// Base class Animal
class Animal
{
    public string Name { get; set; } 
    public int Age { get; set; } 

    // Constructor 
    public Animal(string name, int age)
    {
        Name = name;
        Age = age;
    }

    // Virtual method 
    public virtual string MakeSound()
    {
        return "Animal makes a sound";
    }
}

// Derived class Dog
class Dog : Animal
{
    public Dog(string name, int age) : base(name, age) { }

    // Overriding MakeSound method
    public override string MakeSound()
    {
        return "Dog barks";
    }
}

// Derived class Cat
class Cat : Animal
{
    public Cat(string name, int age) : base(name, age) { }

    // Overriding MakeSound method
    public override string MakeSound()
    {
        return "Cat meows";
    }
}

// Derived class Bird
class Bird : Animal
{
    public Bird(string name, int age) : base(name, age) { }

    // Overriding MakeSound method
    public override string MakeSound()
    {
        return "Bird chirps";
    }
}

// Main program
class Program
{
    static void Main()
    {
        // Creating instances of Dog, Cat, and Bird
        Animal dog = new Dog("Tom", 3);
        Animal cat = new Cat("Sony", 2);
        Animal bird = new Bird("Methu", 1);

        // Storing instances in an array
        Animal[] animals = { dog, cat, bird };
        
        // Iterating through the array and calling MakeSound method
        foreach (var animal in animals)
        {
            Console.WriteLine(animal.Name+" ("+animal.Age+" years old): "+animal.MakeSound());
        }
    }
}

