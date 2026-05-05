using System;
using System.IO;

class Program
{
    static void Main()
    {
        string[] files = Directory.GetFiles(".");

        foreach(string f in files)
        {
            if(f.EndsWith(".txt"))
                File.Move(f, "text_" + Path.GetFileName(f));
        }
    }
}