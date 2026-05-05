using System;
class Program
{
    static void Main()
    {
        int num = 121;
        int original = num;
        int rev = 0;

        while(num>0)
        {
            int rem = num % 10;
            rev = rev * 10 + rem;
            num /= 10;
        }

        if(original == rev)
            Console.WriteLine("Palindrome");
        else
            Console.WriteLine("Not Palindrome");
    }
}