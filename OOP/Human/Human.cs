using OOP.Human;

namespace OOP.Human;

class Human
{
    private string name;
    private string lastName;
    private int age;
    

    private void Introduce()
    {
        Console.WriteLine($"Hello, {name + " " + lastName}!, you are {1}");
    }
}