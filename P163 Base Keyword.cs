using System;

class A
{
    public A()
    {
        Console.WriteLine("Base Constructor");
    }
}

class B : A
{
    public B() : base()
    {
        Console.WriteLine("Child Constructor");
    }
}

class Program
{
    static void Main()
    {
        B obj = new B();
    }
}