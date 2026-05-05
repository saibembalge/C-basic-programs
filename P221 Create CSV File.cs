using System;
using System.IO;

class Program
{
    static void Main()
    {
        File.WriteAllText("data.csv", "Name,Age\nNikhil,20");
    }
}