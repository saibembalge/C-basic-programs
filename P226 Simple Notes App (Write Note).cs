using System;
using System.IO;

class Program
{
    static void Main()
    {
        Console.Write("Enter note: ");
        string note = Console.ReadLine();

        File.AppendAllText("notes.txt", note + "\n");
    }
}