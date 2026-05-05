using System;

class Program
{
    static void Main()
    {
        Random r = new Random();
        int num = r.Next(1,10);

        Console.Write("Guess number: ");
        int guess = int.Parse(Console.ReadLine());

        if(guess == num)
            Console.WriteLine("Correct");
        else
            Console.WriteLine("Wrong: " + num);
    }
}