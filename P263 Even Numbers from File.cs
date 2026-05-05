using System;
using System.IO;

class Program
{
    static void Main()
    {
        string[] lines = File.ReadAllLines("nums.txt");

        foreach(string l in lines)
        {
            int n = int.Parse(l);
            if(n%2==0)
                Console.WriteLine(n);
        }
    }
}