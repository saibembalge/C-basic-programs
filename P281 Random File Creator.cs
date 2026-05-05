using System;
using System.IO;

class Program
{
    static void Main()
    {
        File.WriteAllText("random.txt", Guid.NewGuid().ToString());
    }
}