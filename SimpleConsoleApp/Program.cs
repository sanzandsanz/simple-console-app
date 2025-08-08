// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Console.WriteLine(Maths.Add(3, 4));

public static class Maths
{
    public static int Add(int number1, int number2)
    {
        return number1 + number2;
    }
}