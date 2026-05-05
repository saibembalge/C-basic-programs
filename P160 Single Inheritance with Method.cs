using System;

class Parent
{
    public void Show()
    {
        Console.WriteLine("Parent Method");
    }
}

class Child : Parent
{
}

class Program
{
    static void Main()
    {
        Child c = new Child();
        c.Show();
    }
}