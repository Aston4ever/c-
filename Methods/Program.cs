int x = 3;
 void WriteSmth(string str)
{
 
 Console.WriteLine($"Hello from Method!!!{str}");
 Console.WriteLine();
}
WriteSmth("Bubl");

int Add(int x, int y)
{
  return x + y;
}
int result = Add(2, 5);
int methodInside = Add(Add(5,6), Add(3,4));//Метод как параметр
Console.WriteLine($"Enter your friend's name");
string friendName = Console.ReadLine();

void PrintName(string friendName)
{
    Console.WriteLine($"Hello from Method!!!{friendName} My Friend!");
}
PrintName(friendName);