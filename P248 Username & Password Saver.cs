using System;
using System.IO;

class Program
{
    static void Main()
    {
        string data = Console.ReadLine();
        File.WriteAllText("user.txt", data);
    }
}