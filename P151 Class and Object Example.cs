using System;

class Person
{
    public string name = "Nikhil";
}

class Program
{
    static void Main()
    {
        Person p = new Person();
        Console.WriteLine(p.name);
    }
}