using System;
using System.IO;

class Program
{
    static void Main()
    {
        File.Copy("test.txt", "backup.txt", true);
    }
}