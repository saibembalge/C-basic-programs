using System;

class Demo
{
    static Demo()
    {
        Console.WriteLine("Static Constructor");
    }
}

class Program
{
    static void Main()
    {
        Demo d = new Demo();
    }
}