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
int methodInside = Add(Add(5,6), Add(3,4)); //Метод как параметр
Console.WriteLine($"Enter your friend's name");
string friendName = Console.ReadLine();

void PrintName(string friendName)
{
    Console.WriteLine($"Hello from Method!!!{friendName} My Friend!");
}
PrintName(friendName);

//Arrays as parameters
int[] gradesArray = { 11, 22, 34, 46, 50, 6, 7, 83, 9, 10 };
double res = GetAverage(gradesArray);
Console.WriteLine($"Average grade is {res:N1}");
double GetAverage(int[] gradesArray)
{
    int size = gradesArray.Length;
    double average;
    int sum = 0;
    foreach (var mark in gradesArray)
    {
        sum+=mark;
    }
    double res = sum / size;
    return result;
}

//Arrays as parameters