double myDouble = 3.65;
int myInt;

myInt = (int)myDouble; //explicite conversion (CAST) Просто убираются символы 
Console.WriteLine(myInt);

float myFloat = 3.6f; //implicite conversion мегьший тип большему типу
double myDouble2 = myFloat; //Если нет потери данных то можно присваивать значения напряму

//TYpe conversion
string myString = myDouble2.ToString(); //Преобразование лбого типа в строку

int userInput = Convert.ToInt32(Console.ReadLine());
int userInput2 = Convert.ToByte(Console.ReadLine());
int userInput3 = Convert.ToChar(Console.ReadLine());