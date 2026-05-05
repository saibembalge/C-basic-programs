using System;

class A
{
    public void Show()
    {
        Console.WriteLine("Base");
    }
}

class B : A
{
    public new void Show()
    {
        Console.WriteLine("Child");
    }
}

class Program
{
    static void Main()
    {
        B obj = new B();
        obj.Show();
    }
}