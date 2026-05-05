using System;

class Student
{
    public string name;
    public int marks;
}

class Program
{
    static void Main()
    {
        Student s = new Student();

        s.name = "Nikhil";
        s.marks = 90;

        Console.WriteLine(s.name + " " + s.marks);
    }
}