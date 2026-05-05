using System;
using System.IO;

class Program
{
    static void Main()
    {
        string name = Console.ReadLine();
        File.AppendAllText("contacts.txt", name+"\n");
    }
}