using System;

class Program
{
    static void Main()
    {
        Random r = new Random();
        string chars = "abc123";

        for(int i=0;i<5;i++)
        {
            string pass = "";
            for(int j=0;j<6;j++)
                pass += chars[r.Next(chars.Length)];

            Console.WriteLine(pass);
        }
    }
}