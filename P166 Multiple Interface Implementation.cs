using System;

interface A { void A1(); }
interface B { void B1(); }

class Demo : A, B
{
    public void A1(){ Console.WriteLine("A1"); }
    public void B1(){ Console.WriteLine("B1"); }
}

class Program
{
    static void Main()
    {
        Demo d = new Demo();
        d.A1();
        d.B1();
    }
}