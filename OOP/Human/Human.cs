using OOP.Human;

namespace OOP.Human;

class Human
{ // Members - это части этого класса например переменные, методы и т.д.
    private string name; // field
    private string lastName;
    private string eyeColor;
    private int age;


    public Human(string name, string lastName, string eyeColor , int age) //Конструктор
    {
        this.name  = name;
        this.lastName = lastName;
        this.eyeColor = eyeColor;
        this.age = age;
    }

    public void Introduce() //methods
    {
        Console.WriteLine($"Hello, {name + " " + lastName}!, you are {age}");
    }
}