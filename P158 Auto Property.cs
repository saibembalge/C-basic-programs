using System;

class Student
{
    public int Age { get; set; }
}

class Program
{
    static void Main()
    {
        Student s = new Student();
        s.Age = 20;

        Console.WriteLine(s.Age);
    }
}