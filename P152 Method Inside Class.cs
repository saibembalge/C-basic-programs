using System;

class Car
{
    public void Show()
    {
        Console.WriteLine("Car is running");
    }
}

class Program
{
    static void Main()
    {
        Car c = new Car();
        c.Show();
    }
}