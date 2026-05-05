using System;

class Program
{
    static void Main()
    {
        int num = 153;
        int temp = num;
        int sum = 0;

        while(temp > 0)
        {
            int rem = temp % 10;
            sum += rem * rem * rem;
            temp /= 10;
        }

        if(sum == num)
            Console.WriteLine("Armstrong");
        else
            Console.WriteLine("Not Armstrong");
    }
}