using System;

class Program
{
    static void Main()
    {
        string chars = "abcdefghijklmnopqrstuvwxyz123456789";
        Random r = new Random();
        string password = "";

        for(int i=0;i<8;i++)
        {
            int index = r.Next(chars.Length);
            password += chars[index];
        }

        Console.WriteLine(password);
    }
}