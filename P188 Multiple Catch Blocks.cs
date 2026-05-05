using System;

class Program
{
    static void Main()
    {
        try
        {
            int[] arr = new int[2];
            Console.WriteLine(arr[5]);
        }
        catch(IndexOutOfRangeException)
        {
            Console.WriteLine("Index error");
        }
        catch(Exception)
        {
            Console.WriteLine("General error");
        }
    }
}