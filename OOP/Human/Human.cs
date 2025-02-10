using OOP.Human;

namespace OOP.Human;

class Human
{
    public string name;
    private string lastName;
    private int age = 10;

    public void Introduce()
    {
        Console.WriteLine($"Hello, {name + " " + lastName}!, you are {1}");
    }
}