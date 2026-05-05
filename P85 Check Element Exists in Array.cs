using System;

class Program
{
    static void Main()
    {
        int[] arr = {5,10,15,20};
        int target = 15;

        bool found = false;

        foreach(int num in arr)
        {
            if(num == target)
                found = true;
        }

        Console.WriteLine(found);
    }
}