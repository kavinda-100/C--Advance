namespace Cs_advance.classes;

public class Animal
{
    public string Name { get; set; }
    public int Age { get; set; }
    
    public Animal(string name, int age)
    {
        Name = name;
        Age = age;
    }
    
    public string GetFullDetails()
    {
        return $"Name = {Name}, Age = {Age}";
    }
}