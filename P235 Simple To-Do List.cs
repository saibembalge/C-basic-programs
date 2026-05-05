using System;
using System.IO;

class Program
{
    static void Main()
    {
        Console.Write("Task: ");
        string task = Console.ReadLine();

        File.AppendAllText("todo.txt", task + "\n");
    }
}