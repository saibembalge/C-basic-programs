using System;
using System.IO;

class Program
{
    static void Main()
    {
        string json = "{\"name\":\"Nikhil\"}";
        File.WriteAllText("data.json", json);
    }
}