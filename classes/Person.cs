namespace Cs_advance.classes;

public class Person
{
    private readonly string _name;
    private readonly int _age;
    private readonly double _height;
    private readonly bool _isMarried;
    
    public Person(string name, int age, double height, bool isMarried)
    {
        this._name = name;
        this._age = age;
        this._height = height;
        this._isMarried = isMarried;
    }
    //TODO: This is another way to write the constructor
    // public Person(string name, int age, double height, bool isMarried)
    // {
    //     _name = name;
    //     _age = age;
    //     _height = height;
    //     _isMarried = isMarried;
    // }
    
    public string GetFullDetails()
    {
        return $"Name = {_name}, Age = {_age}, Height = {_height}, Is Married = {_isMarried}";
    }
}