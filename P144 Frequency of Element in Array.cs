using System;

class Program
{
    static void Main()
    {
        int[] arr = {1,2,2,3,3,3};
        int target = 3;
        int count = 0;

        foreach(int num in arr)
        {
            if(num == target)
                count++;
        }

        Console.WriteLine(count);
    }
}