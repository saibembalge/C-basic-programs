using System;

class Program
{
    static bool IsArmstrong(int num)
    {
        int temp = num, sum = 0;

        while(temp > 0)
        {
            int rem = temp % 10;
            sum += rem*rem*rem;
            temp /= 10;
        }

        return sum == num;
    }

    static void Main()
    {
        Console.WriteLine(IsArmstrong(153));
    }
}