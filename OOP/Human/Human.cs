using OOP.Human;

namespace OOP.Human;

class Human
{ // Members - это части этого класса например переменные, методы и т.д.
    private string name; // field
    private string lastName;
    private string eyeColor;
    private int age;

    public Human() //Default 
    {
        
    }
    //Параметризированный Конструктор
    public Human(string name) 
    {
        this.name  = name;
    }
    public Human(string name, string lastName) 
    {
        this.name  = name;
        this.lastName = lastName;
    }
    public Human(string name, string lastName, string eyeColor) 
    {
        this.name  = name;
        this.lastName = lastName;
        this.eyeColor = eyeColor;
    }
    public Human(string name, string lastName, string eyeColor , int age) 
    {
        this.name  = name;
        this.lastName = lastName;
        this.eyeColor = eyeColor;
        this.age = age;
    }

    public void Introduce() //methods
    {
        if (age != 0 && eyeColor != null && lastName != null)
        {
            Console.WriteLine($"Hello, {name + " " + lastName}!, you are {age}");
        }
        else if (age != 0 && eyeColor != null)
        {
            Console.WriteLine($"Hello, {name + " " + lastName}!");
        }
       
    }
}