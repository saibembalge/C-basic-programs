using System;
using System.IO;

class Program
{
    static void Main()
    {
        File.Move("file2.txt", "newfile.txt");
    }
}