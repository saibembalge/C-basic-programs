using System;

class Demo
{
    public Demo() { Console.WriteLine("Default"); }
    public Demo(int x) { Console.WriteLine(x); }
}

class Program
{
    static void Main()
    {
        Demo d1 = new Demo();
        Demo d2 = new Demo(10);
    }
}