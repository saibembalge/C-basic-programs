using System;

class Program
{
    static void Main()
    {
        string chars = "ABCabc123!@#";
        Random r = new Random();
        string pass = "";

        for(int i=0;i<10;i++)
            pass += chars[r.Next(chars.Length)];

        Console.WriteLine(pass);
    }
}