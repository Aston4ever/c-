string myString1 = "23";
string myString2 = "56";
int num1 = int.Parse(myString1); //если не парсится то Unhandled exeption
int num2 = int.Parse(myString2);

string result = myString1 + myString2;
int numresult = num1 + num2;
Console.WriteLine(numresult);
Console.ReadLine();

