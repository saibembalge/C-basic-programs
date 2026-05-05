using System;

class Program
{
    static void Main()
    {
        int baseNum = 2;
        int power = 3;
        int result = 2;

        for(int i=1;i<=power;i++)
            result *= baseNum;

        Console.WriteLine(result);
    }
}