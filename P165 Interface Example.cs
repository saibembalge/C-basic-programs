using System;

interface ITest
{
    void Show();
}

class Demo : ITest
{
    public void Show()
    {
        Console.WriteLine("Interface Method");
    }
}

class Program
{
    static void Main()
    {
        Demo d = new Demo();
        d.Show();
    }
}