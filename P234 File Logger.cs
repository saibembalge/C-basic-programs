using System;
using System.IO;

class Program
{
    static void Main()
    {
        File.AppendAllText("log.txt", DateTime.Now + "\n");
    }
}