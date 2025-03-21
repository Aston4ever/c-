namespace InheritanceVIrtual;

public class Dog : Animals
{
    public  bool isHappy;
    public Dog(string name, int age) : base(name, age)
    {
        isHappy = true;
    }

    public override void MakeSound()
    {
        Console.WriteLine("Woof!");
    }

    public override void Eat()
    {
        base.Eat();
    }

    public override void Play()
    {
        if (isHappy)
        {
            base.Play();
        }
    }
    
}