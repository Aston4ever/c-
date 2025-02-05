/*

string name = "Aston";
CoolMethod();
///<summary>
// Hello
///</summary>
void CoolMethod()
{
    Console.WriteLine(name);
}
string x = Console.ReadLine();
int x2 = Console.Read();
Console.Clear();
Console.WriteLine(x);
Console.WriteLine(x2);
string capsName = name.ToUpper();


//Concatenation
string concatenation = "Hello" + " " + name.ToUpper();
// String formatting
string userName = "Aston";
string password = "qwerty";
Console.WriteLine("My name is {0} and my pass is {1}", userName, password);
// String interpolation
Console.WriteLine($"My name is {userName} and my pass is {password}");
//Verbatim strngs
Console.WriteLine(
    @" Hello
    My name is {0} and my pass is {1}

    1asdgf");

//Verbatim string + interpolation
Console.WriteLine($@"   Hello 
    My name is {userName} and my pass is {password}");
*/
//HomeWork
string? str = Console.ReadLine();
Console.WriteLine($"you have entered {str}");
char symbolToFind = Console.ReadKey().KeyChar;
Console.WriteLine($"you have entered key {symbolToFind}");
int ind = str.IndexOf(symbolToFind); 
Console.WriteLine($"The first index of entered symbol is {ind}");




