using System;
using System.Text;

public partial class Person
{
    public void Print()
    {
        Console.WriteLine($"{Name}: {Age}");
    }
}

public partial class Person
{
    public string Name { get; set; }
    public int Age { get; set; }
}

