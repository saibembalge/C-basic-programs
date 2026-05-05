using System;
using System.IO;

class Program
{
    static void Main()
    {
        File.Move("test.txt", "renamed.txt");
    }
}