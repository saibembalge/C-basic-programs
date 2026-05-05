using System;

class Animal
{
    public void Eat()
    {
        Console.WriteLine("Eating...");
    }
}

class Dog : Animal
{
}

class Program
{
    static void Main()
    {
        Dog d = new Dog();
        d.Eat();
    }
}