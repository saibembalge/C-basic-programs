using System;

class Program
{
    static void Main()
    {
        int[] a = {1,2,3};
        int[] b = {4,5,6};

        int[] result = new int[a.Length + b.Length];

        a.CopyTo(result,0);
        b.CopyTo(result,a.Length);

        foreach(int num in result)
            Console.Write(num + " ");
    }
}