using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is your First name? ");
        string firstName = Console.ReadLine();

        Console.WriteLine("What is your Last name? ");
        string lastName = Console.ReadLine();

        Console.WriteLine($"Your name is {lastName}, {firstName} {lastName}.");

    }
}