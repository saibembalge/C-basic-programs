using System;

class Demo
{
    public static void Show()
    {
        Console.WriteLine("Static Method");
    }
}

class Program
{
    static void Main()
    {
        Demo.Show();
    }
}