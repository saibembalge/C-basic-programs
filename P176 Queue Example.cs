using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Queue<int> q = new Queue<int>();
        q.Enqueue(5);
        q.Enqueue(10);

        Console.WriteLine(q.Dequeue());
    }
}