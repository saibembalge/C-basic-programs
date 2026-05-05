using System;
using System.IO;

class Program
{
    static void Main()
    {
        File.WriteAllText("test.txt", "Hello CSharp");
    }
}