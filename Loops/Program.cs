for (int i = 0; i <= 100; i += 2)
{
    if (i % 2 == 0)
    {
        Console.WriteLine(i);
        
    }
}

Console.WriteLine("For loop is done");

//DO WHILE
int counter = 0;
do
{
    Console.Write(counter + " ");
} while (counter >= 100);

//WHILE
int age = 0;

while (age < 18)
{
    Console.WriteLine("Your age is {0} Grow a little bit more", age);
    age++;
}
string x = Console.ReadLine();
Console.WriteLine(x);
Console.WriteLine("now you are an adult");