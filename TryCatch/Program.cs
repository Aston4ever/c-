Console.Write("Enter a number: ");
string userInput = Console.ReadLine();
try
{
    int num = int.Parse(userInput);
    int numX = num / 0;
}
catch (OverflowException)
{
    Console.WriteLine("too long number");
}
catch (FormatException)
{
    Console.WriteLine("invalid number");
}
catch (Exception e)
{
    Console.WriteLine("Division by zero " + e.Message);
}
finally
{
    Console.WriteLine("Goodbye");
}