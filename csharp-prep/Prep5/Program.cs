using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();

        string name = PromptUserName();
        int number = PromptUserNumber();
        int squareNumber = SquareNumber(number);

        DisplayResults(name, squareNumber);
    }

    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the program!");
    }

    static string PromptUserName()
    {
        Console.Write("What is your name? ");
        string name = Console.ReadLine();

        return name;
    }

    static int PromptUserNumber()
    {
        Console.Write("What is your favorite number? ");
        string stringNumber = Console.ReadLine();
        int number = int.Parse(stringNumber);

        return number;
    }

    static int SquareNumber(int number)
    {
        int square = number * number;

        return square;
    }

    static void DisplayResults(string name, int square)
    {
        Console.WriteLine($"{name}, the square of your favorite number is {square}.");
    }
}