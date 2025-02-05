Console.Write("Enter a number: ");
string userInput = Console.ReadLine();
try
{
    int num = int.Parse(userInput);
}
catch (OverflowException)
{
    Console.WriteLine("too long number");
}
catch (FormatException)
{
    Console.WriteLine("invalid number");
}
finally
{
    Console.WriteLine("Goodbye");
}