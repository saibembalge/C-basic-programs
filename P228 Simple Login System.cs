using System;

class Program
{
    static void Main()
    {
        string user = "admin";
        string pass = "1234";

        Console.Write("Username: ");
        string u = Console.ReadLine();

        Console.Write("Password: ");
        string p = Console.ReadLine();

        if(u == user && p == pass)
            Console.WriteLine("Login Success");
        else
            Console.WriteLine("Login Failed");
    }
}