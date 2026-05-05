using System;

class Program
{
    static void Main()
    {
        string binary = "1010";
        int decimalValue = Convert.ToInt32(binary, 2);

        Console.WriteLine(decimalValue);
    }
}