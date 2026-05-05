using System;
using System.IO;

class Program
{
    static void Main()
    {
        for(int i=0;i<3;i++)
        {
            string note = Console.ReadLine();
            File.AppendAllText("notes.txt", note + "\n");
        }
    }
}