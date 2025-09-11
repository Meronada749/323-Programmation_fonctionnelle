// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

public class Person
{
    // Constructor
    public Person(string name, int age)
    {
        Name = name;
        Age = age;
    }

    // Auto-properties
    public string Name { get; set; }
    public int Age { get; set; }

}
