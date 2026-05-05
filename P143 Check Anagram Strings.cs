using System;

class Program
{
    static void Main()
    {
        string a = "listen";
        string b = "silent";

        char[] arr1 = a.ToCharArray();
        char[] arr2 = b.ToCharArray();

        Array.Sort(arr1);
        Array.Sort(arr2);

        if(new string(arr1) == new string(arr2))
            Console.WriteLine("Anagram");
        else
            Console.WriteLine("Not Anagram");
    }
}