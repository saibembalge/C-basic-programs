using System;

class Employee
{
    private int salary;

    public void SetSalary(int s)
    {
        salary = s;
    }

    public int GetSalary()
    {
        return salary;
    }
}

class Program
{
    static void Main()
    {
        Employee e = new Employee();
        e.SetSalary(50000);
        Console.WriteLine(e.GetSalary());
    }
}