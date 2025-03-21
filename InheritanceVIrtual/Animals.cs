namespace InheritanceVIrtual;

public class Animals
{
     public string Name { get; set; }
     public int Age { get; set; }
     public bool IsHungry { get; set; }

     public Animals(string name, int age)
     {
          Name = name;
          Age = age;
          IsHungry = true;
     }

     public virtual void MakeSound()
     {
          Console.WriteLine("making sound");
     }
     public virtual void Eat()
     {
          if (IsHungry)
          {
               Console.WriteLine($"{Name} eating....");
          }
          else
          {
               Console.WriteLine($"{Name} is not hungry");
          }
     }
     public virtual void Play()
     {
          Console.WriteLine($"{Name} is playing...");
     }
}