using System;

public interface IPerson
{
    string Name { get; set; }
    string Email { get; set; }
    void ShowName();
}
public class Person: IPerson
{
    private string _name;
    private string _email;

    public string Name
    {
        get { return _name; }
        set { _name = value; }
    }

    public string Email
    {
        get { return _email; }
        set { _email = value; } 
    }

    public void ShowName()
    {
        Console.WriteLine($"Person's Name: { Name }");
    }
}

public class Student : IPerson
{
    private string _name;
    private string _email;
    private string[] _grades;
    public string Name { get => _name; set => _name = value; }
    public string Email { get => _email; set => _email = value; }
    public string[] Grades { get => _grades; set => _grades = value; }

    public void ShowName()
    {
        Console.WriteLine($"Students's Name: { Name }");
    }
}

// An abstract class is a special type of class that cannot be instantiated.
// An abstract class is designed to be inherited by subclasses that either implement or override its methods.
// black boxing.
public abstract class Teacher : IPerson
{
    public string Name { get; set; }
    public string Email { get; set; }
    public string Subject { get; set; }

    public void ShowName()
    {
        Console.WriteLine($"Teacher's Name: { Name }");
    }
}