using System;

class Program
{
    static void Main()
    {
        string pass = "123";

        for(int i=100;i<=999;i++)
        {
            if(i.ToString() == pass)
                Console.WriteLine("Found: "+i);
        }
    }
}