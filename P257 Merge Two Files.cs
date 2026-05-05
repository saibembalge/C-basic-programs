using System;
using System.IO;

class Program
{
    static void Main()
    {
        string a = File.ReadAllText("text_file1.txt");
        string b = File.ReadAllText("text_file2.txt");

        File.WriteAllText("merge.txt", a + b);
    }
}