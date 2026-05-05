using System;

class Program
{
    static void Main()
    {
        int[] arr = {1,2,3,4,5,6};
        int count = 0;

        foreach(int num in arr)
        {
            if(num % 2 == 0)
                count++;
        }

        Console.WriteLine(count);
    }
}