using System;

class Demo
{
    int[] arr = new int[5];

    public int this[int i]
    {
        get { return arr[i]; }
        set { arr[i] = value; }
    }
}

class Program
{
    static void Main()
    {
        Demo d = new Demo();
        d[0] = 10;

        Console.WriteLine(d[0]);
    }
}