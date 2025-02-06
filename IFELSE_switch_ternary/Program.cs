int age = 17;
switch (age)
{
    case 1:
        Console.WriteLine("Hello World!");
        break;
    case 2:
        Console.WriteLine("Hello AGAIN!");
        break;
    case 25:
        Console.WriteLine("You can drive");
        break;
    default:
        Console.WriteLine("no age was found");
        break;
}
string myGender = "male";
string gender = myGender == "male" ? "male" : 
    myGender == "female" ? "female" : "no gender";

/*
 *  if (true\false) {
 *      code to execute if TRUE
 *  } else {
 *      code to execute if FALSE
 *  }
 */
 
 /*
  string temperature = Console.ReadLine();
 int numTemp;

 if (int.TryParse(temperature, out int temperatureInt))
 {
     numTemp = temperatureInt;
 }
 else
 {
     Console.WriteLine("Please enter a valid temperature");
 }
 */
Console.Write("Enter your UserName to register ");
string registerUserName = Console.ReadLine();
Console.Write("Enter your passowrd to register ");
string registerUserPassword = Console.ReadLine();
Console.Write("Register Successful");
Console.Write($"Welcome! Enter your username: ");
string userNameInput = Console.ReadLine();
string userPasswordInput;

if (CheckIfUserExists(userNameInput))
{
    Console.Write($"Enter your password: ");
    userPasswordInput = Console.ReadLine();
    if (CheckIfPasswordCorrect(userPasswordInput))
    {
        Console.WriteLine($"Welcome {userNameInput}!");
    }
    else
    {
        Console.WriteLine("Wrong password!");
    }
}
else
{
    Console.WriteLine("Invalid username");
}

bool CheckIfUserExists(string userName)
{
    return userName == registerUserName;
}
bool CheckIfPasswordCorrect(string password)
{
    return registerUserPassword == userPasswordInput;
}

