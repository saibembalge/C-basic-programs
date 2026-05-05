using System;

class A { public void A1(){ Console.WriteLine("A"); } }
class B : A { public void B1(){ Console.WriteLine("B"); } }
class C : B { }

class Program
{
    static void Main()
    {
        C obj = new C();
        obj.A1();
        obj.B1();
    }
}