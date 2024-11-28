
using Cs_advance.classes;

namespace Cs_advance;

public static class Program
{
    public static void Main(string[] args)
    {
        Person person1 = new Person("John", 25, 5.8, false);
        Person person2 = new Person("Jane", 30, 5.6, true);
        
        Console.WriteLine(person1.GetFullDetails());
        Console.WriteLine(person2.GetFullDetails());
        
        Animal animal1 = new Animal("Dog", 5);
        Animal animal2 = new Animal("Cat", 3);
        animal1.Name = "Puppy";
        animal2.Age = 2;
        
    }
}