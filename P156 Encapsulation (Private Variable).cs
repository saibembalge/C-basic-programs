using System;

class Bank
{
    private int balance = 1000;

    public int GetBalance()
    {
        return balance;
    }
}

class Program
{
    static void Main()
    {
        Bank b = new Bank();
        Console.WriteLine(b.GetBalance());
    }
}