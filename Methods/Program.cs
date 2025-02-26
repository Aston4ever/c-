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
    {
        {
            
        }
    }
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
paramsMethod(1, 3,4,5,6,7,8,9,10,11,77,12, 67);  //Можно указывать сколько угодно параметров, и даже не указывать вовсе

void paramsMethod(params int[] gradesArray) //превращает кучу параметров в массив
{
    for (int i = 0; i < gradesArray.Length; i++)
    {
        Console.Write(gradesArray[i] + " ");
    }
}
paramsObjMethod(1, "hello", true, 1.324, 0x100010010);
void paramsObjMethod(params object[] obj)
{
    for (int i = 0; i < obj.Length; i++)
    {
        Console.Write(obj[i]);
    }
}

int min = minV(3,-1,-1000, 199, 56);
int minV(params int[] numbers)
{
    int min = int.MaxValue;
    foreach (var k in numbers)
    {
        if (k < min)
        {
            min = k;
        }
    }
    return min;
}