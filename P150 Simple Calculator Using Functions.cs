using System;

class Program
{
    static double Calculate(double a, double b, char op)
    {
        switch(op)
        {
            case '+': return a + b;
            case '-': return a - b;
            case '*': return a * b;
            case '/': return a / b;
            default: return 0;
        }
    }

    static void Main()
    {
        Console.WriteLine(Calculate(10, 5, '+'));
    }
}