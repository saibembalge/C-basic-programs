using System;

class Program
{
    static void Main()
    {
        string str = "madam";
        char[] arr = str.ToCharArray();

        Array.Reverse(arr);

        string rev = new string(arr);

        if(str == rev)
            Console.WriteLine("Palindrome");
        else
            Console.WriteLine("Not Palindrome");
    }
}