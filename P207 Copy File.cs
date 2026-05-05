using System;
using System.IO;

class Program
{
    static void Main()
    {
        File.Copy("file1.txt", "file2.txt", true);
    }
}