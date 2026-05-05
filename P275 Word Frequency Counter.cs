using System;
using System.Linq;

class Program
{
    static void Main()
    {
        string text = "a b a c";
        var words = text.Split(' ');

        foreach(var w in words.Distinct())
            Console.WriteLine(w + ":" + words.Count(x=>x==w));
    }
}